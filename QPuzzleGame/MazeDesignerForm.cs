/*
 * MazeDesignerForm allows to create, save and load game level design layout
 * Revision History
 *                  Iryna Shynkevych:   20.09.2018 Created 
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QPuzzleGame
{
    /// <summary>
    /// MazeDesignerForm class defined the parameters and functionning of the
    /// designer panel
    /// </summary>
    public partial class MazeDesignerForm : Form
    {

        private const int MAX_COLUMNS = 12;
        private const int MAX_ROWS = 11;
        private const int LEFT_OFFSET = 200;

        Grid gameGrid;
        int selectedTileType = -1;

        /// <summary>
        /// MazeDesignerForm class constructor
        /// </summary>
        public MazeDesignerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button closing this form and going back to the control panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Form newForm = new ControlPanelForm();
            newForm.Show();
            this.Close();
        }

        /// <summary>
        /// Button saving a file to a specified location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            dlgSave.InitialDirectory = Path.GetFullPath(Path.Combine
                (Application.StartupPath, @"..\..\..\Savegame"));
            DialogResult r = dlgSave.ShowDialog();
            switch (r)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        if (gameGrid == null)
                        {
                            throw new Exception("the game layout does not " +
                                "exists");
                        }
                        string fileName = dlgSave.FileName;
                        SaveFile(fileName);
                        MessageBox.Show("File successfully saved", "QGame");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in file save: " + ex.Message);
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Composes a string out of the grid's tile types and saves it
        /// </summary>
        /// <param name="fileName">Name of the file we're saving into</param>
        private void SaveFile(string fileName)
        {
            string dataToSave = gameGrid.GetLength(0).ToString() + ":" +
                gameGrid.GetLength(1).ToString();

            for (int i = 0; i < gameGrid.GetLength(0); i++)
            {
                for (int j = 0; j < gameGrid.GetLength(1); j++)
                {
                    dataToSave += ":" + gameGrid[i, j].TileType.ToString();
                }
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(dataToSave);
            }
        }

        /// <summary>
        /// Reads a save file and recreates the grid stored in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            dlgLoad.InitialDirectory = Path.GetFullPath(Path.Combine
                (Application.StartupPath, @"..\..\..\Savegame"));
            DialogResult r = dlgLoad.ShowDialog();
            switch (r)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string fileName = dlgLoad.FileName;
                        if (fileName == "")
                        {
                            throw new Exception("You need to choose a file" +
                                "to open!");
                        }
                        if (!File.Exists(fileName))
                        {
                            throw new Exception("The file dos not exist!");
                        }
                        LoadFile(fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in file load: " + ex.Message);
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Reads the file, extracts number of columns and number of rows,
        /// and sends them with the rest of the file data to DrawGrid function
        /// </summary>
        /// <param name="fileName">Name of file we're reading from</param>
        private void LoadFile(string fileName)
        {
            string fileContent;
            string[] savedTiles;

            using (StreamReader reader = new StreamReader(fileName))
            {
                if (reader.EndOfStream)
                {
                    MessageBox.Show("The file is empty");
                    return;
                }
                fileContent = reader.ReadLine();
            }

            try
            {
                int pos = fileContent.IndexOf(":");
                int numberOfColumns = int.Parse(fileContent.Substring(0, pos));
                int numberOfRows = int.Parse(fileContent.Substring(pos + 1,
                    fileContent.IndexOf(":", pos + 1) - pos - 1));
                savedTiles = fileContent.Substring(fileContent
                    .IndexOf(":", pos + 1) + 1).Split(':');

                if (gameGrid != null)
                {
                    gameGrid.DeleteGrid(this);
                }
                gameGrid = new Grid(this, numberOfColumns, numberOfRows, savedTiles, LEFT_OFFSET);
                for (int i = 0; i < gameGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < gameGrid.GetLength(1); j++)
                    {
                        gameGrid[i, j].Click += BuildLayout_Click;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Reading file error");
            }
        }

        /// <summary>
        /// Clicking on this button generates grid with parametized dimensions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {

            int numberOfColumns = 0;
            int numberOfRows = 0;
            try
            {
                if (textBoxNbrColumns.Text == "" || textBoxNbrRows.Text == "")
                {
                    throw new Exception("please indicate both number of " +
                        "columns and number of rows");
                }
                if (!int.TryParse(textBoxNbrColumns.Text, out numberOfColumns)
                    || !int.TryParse(textBoxNbrRows.Text, out numberOfRows))
                {
                    throw new Exception("number of columns and number" +
                        " of rows must be integer numbers");
                }
                if (numberOfColumns > MAX_COLUMNS || numberOfRows > MAX_ROWS)
                {
                    throw new Exception("You went over indicated dimension" +
                        " limits");
                }
                if (gameGrid != null)
                {
                    gameGrid.DeleteGrid(this);
                }
                gameGrid = new Grid(this, numberOfColumns, numberOfRows, null, LEFT_OFFSET);
                for (int i = 0; i < gameGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < gameGrid.GetLength(1); j++)
                    {
                        gameGrid[i, j].Click += BuildLayout_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// On click, the button's tile type is saved to the global variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TileSelect_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
            selectedTileType = buttonClicked.ImageIndex;
        }
        /// <summary>
        /// On click, the selected tile's type of layout is assigned to the grid's cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BuildLayout_Click(object sender, EventArgs e)
        {
            Tile tileClicked = (Tile)sender;
            tileClicked.AssignTyleType(selectedTileType);
        }
    }
}
