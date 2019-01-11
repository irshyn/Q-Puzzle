/*
 * PlayForm allows to play the Q-Puzzle game using a layout saved in a .qgame file
 * Revision History
 *                  Iryna Shynkevych:   20.10.2018 Created 
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QPuzzleGame
{
    /// <summary>
    /// PlayForm class inherits from Form class and contains the game logic
    /// </summary>
    public partial class PlayForm : Form
    {
        private const int LEFT_OFFSET = 250;

        Grid gameGrid;
        Tile selectedTile; 
        int numberBalls = 0;
        bool ballMoved = false;
        string movementDirection = "";

        /// <summary>
        /// PlayForm class constructor
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();

            selectedTile = new Tile();
            selectedTile.Location = new Point(70, 55);
            selectedTile.BringToFront();
            this.groupBoxSelection.Controls.Add(selectedTile);

            textBoxNbrMoves.Text = "0";
            textBoxNumberBalls.Text = "0";
        }

        /// <summary>
        /// Opens a save file and recreates the grid stored in it
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
                    selectedTile.AssignTyleType(-1);
                    gameGrid.DeleteGrid(this);
                    textBoxNbrMoves.Text = "0";
                    numberBalls = 0;
                }
                gameGrid = new Grid(this, numberOfColumns, numberOfRows, savedTiles, LEFT_OFFSET);
                for (int i = 0; i < gameGrid.GetLength(0); i++)
                {
                    for (int j = 0; j < gameGrid.GetLength(1); j++)
                    {
                        gameGrid[i, j].Click += SelectBall_Click;
                        if (gameGrid[i, j].TileType > 4 && gameGrid[i, j].TileType <= 8)
                        {
                            numberBalls++;
                        }
                    }
                }
                gameGrid.Timer.Tick += Timer_Tick;
                textBoxNumberBalls.Text = numberBalls.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Reading file error");
            }
        }
        /// <summary>
        /// Button closing PlayForm form and going back to the control panel
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
        /// On click, the button's tile type is saved to the global variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectBall_Click(object sender, EventArgs e)
        {
            Tile tileClicked = (Tile)sender;
            if (tileClicked.TileType > 4 && tileClicked.TileType <= 8)
            {
                selectedTile.AssignTyleType(tileClicked.TileType);
                selectedTile.Column = tileClicked.Column;
                selectedTile.Row = tileClicked.Row;
            }
        }

        /// <summary>
        /// Click event that verifies if any ball was selected, and if the sender is a ball
        /// and if so, moves the ball in the direction specified by the button until it "hits"
        /// the wall, another ball or a door of a different color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlButton_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
            if (selectedTile.TileType == -1)
            {
                MessageBox.Show("You need to select a ball first!");
                return;
            }

            if (checkBoxAnimation.Checked == false)
            {

                switch (buttonClicked.Text)
                {
                    case "Up":
                        MoveVertically(-1);
                        break;
                    case "Down":
                        MoveVertically(1);
                        break;
                    case "Left":
                        MoveHorizontally(-1);
                        break;
                    case "Right":
                        MoveHorizontally(1);
                        break;
                    default:
                        throw new Exception("Something went wrong");
                }
                textBoxNumberBalls.Text = numberBalls.ToString();
                CheckIfWon();
            }

            else
            {
                movementDirection = buttonClicked.Text;
                if (gameGrid.IsMoving == false)
                {
                    gameGrid.IsMoving = true;
                }
            }
        }

        /// <summary>
        /// The function that determines how many cells up or down the ball can be moved, and
        /// than deletes the ball in the old position and draws it in the new one (if the tile
        /// it 'collides' with is a door of the same color, the ball is just deleted
        /// </summary>
        /// <param name="direction">integer that specifies the direction of vertical movement
        /// (1 is down and -1 is Up)</param>
        private void MoveVertically(int direction)
        {
            int rowMove = selectedTile.Row;

            while (gameGrid[selectedTile.Column, rowMove + direction].TileType == -1)
            {
                rowMove += direction;
            }

            if (gameGrid[selectedTile.Column, rowMove + direction].TileType == selectedTile.TileType - 4)
            {
                numberBalls--;
                gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                selectedTile.AssignTyleType(-1);
                textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                return;
            }

            if (rowMove != selectedTile.Row)
            {
                gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                gameGrid[selectedTile.Column, rowMove].AssignTyleType(selectedTile.TileType);
                selectedTile.Row = rowMove;
                textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
            }
        }

        /// <summary>
        /// The function that determines how many cells left or right the ball can be moved, and
        /// than deletes the ball in the old position and draws it in the new one (if the tile
        /// it 'collides' with is a door of the same color, the ball is just deleted
        /// </summary>
        /// <param name="direction">integer that specifies the direction of horizontal movement
        /// (1 is right and -1 is left)</param>
        private void MoveHorizontally(int direction)
        {
            int columnMove = selectedTile.Column;

            while (gameGrid[columnMove + direction, selectedTile.Row].TileType == -1)
            {
                columnMove += direction;
            }

            if (gameGrid[columnMove + direction, selectedTile.Row].TileType == selectedTile.TileType - 4)
            {
                numberBalls--;
                gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                selectedTile.AssignTyleType(-1);
                textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                return;
            }

            if (columnMove != selectedTile.Column)
            {
                gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                gameGrid[columnMove, selectedTile.Row].AssignTyleType(selectedTile.TileType);
                selectedTile.Column = columnMove;
                textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
            }
        }

        /// <summary>
        /// Timer tick event that moves a selected ball int the specified direction on each tick of
        /// the clock until the ball 'hits' a wall, another ball or a door of a different color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (movementDirection)
            {
                case "Up":
                    if (gameGrid[selectedTile.Column, selectedTile.Row - 1].TileType == -1)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        gameGrid[selectedTile.Column, selectedTile.Row - 1].AssignTyleType(selectedTile.TileType);
                        ballMoved = true;
                        selectedTile.Row--;
                    }
                    else if (gameGrid[selectedTile.Column, selectedTile.Row - 1].TileType == selectedTile.TileType - 4)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        selectedTile.AssignTyleType(-1);
                        numberBalls--;
                        textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                        ballMoved = false;
                        gameGrid.IsMoving = false;
                        CheckIfWon();
                    }
                    else
                    {
                        if (ballMoved == true)
                        {
                            textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                            ballMoved = false;
                        }
                        gameGrid.IsMoving = false;
                    }
                    break;

                case "Down":
                    if (gameGrid[selectedTile.Column, selectedTile.Row + 1].TileType == -1)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        gameGrid[selectedTile.Column, selectedTile.Row + 1].AssignTyleType(selectedTile.TileType);
                        ballMoved = true;
                        selectedTile.Row++;
                    }
                    else if (gameGrid[selectedTile.Column, selectedTile.Row + 1].TileType == selectedTile.TileType - 4)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        selectedTile.AssignTyleType(-1);
                        numberBalls--;
                        textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                        ballMoved = false;
                        gameGrid.IsMoving = false;
                        CheckIfWon();
                    }
                    else
                    {
                        if (ballMoved == true)
                        {
                            textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                            ballMoved = false;
                        }
                        gameGrid.IsMoving = false;
                    }
                    break;

                case "Left":
                    if (gameGrid[selectedTile.Column - 1, selectedTile.Row].TileType == -1)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        gameGrid[selectedTile.Column - 1, selectedTile.Row].AssignTyleType(selectedTile.TileType);
                        ballMoved = true;
                        selectedTile.Column--;
                    }
                    else if (gameGrid[selectedTile.Column - 1, selectedTile.Row].TileType == selectedTile.TileType - 4)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        selectedTile.AssignTyleType(-1);
                        numberBalls--;
                        textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                        ballMoved = false;
                        gameGrid.IsMoving = false;
                        CheckIfWon();
                    }
                    else
                    {
                        if (ballMoved == true)
                        {
                            textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                            ballMoved = false;
                        }
                        gameGrid.IsMoving = false;
                    }
                    break;

                case "Right":
                    if (gameGrid[selectedTile.Column + 1, selectedTile.Row].TileType == -1)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        gameGrid[selectedTile.Column + 1, selectedTile.Row].AssignTyleType(selectedTile.TileType);
                        ballMoved = true;
                        selectedTile.Column++;
                    }
                    else if (gameGrid[selectedTile.Column + 1, selectedTile.Row].TileType == selectedTile.TileType - 4)
                    {
                        gameGrid[selectedTile.Column, selectedTile.Row].AssignTyleType(-1);
                        selectedTile.AssignTyleType(-1);
                        numberBalls--;
                        textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                        ballMoved = false;
                        gameGrid.IsMoving = false;
                        CheckIfWon();
                    }
                    else
                    {
                        if (ballMoved == true)
                        {
                            textBoxNbrMoves.Text = (int.Parse(textBoxNbrMoves.Text) + 1).ToString();
                            ballMoved = false;
                        }
                        gameGrid.IsMoving = false;
                    }
                    break;
                default:
                    throw new Exception("Something went wrong");
            }
            textBoxNumberBalls.Text = numberBalls.ToString();
        }
        /// <summary>
        /// Each time the ball disappears from the grid, this function checks if any balls are left, and if not,
        /// displays the message congratulating the user on the victory and deletes the game layout
        /// </summary>
        private void CheckIfWon()
        {
            if (numberBalls == 0)
            {
                MessageBox.Show($"Congratulations! You won in just {textBoxNbrMoves.Text} moves!\n" +
                    $"If you want to continue playing, load a new game.");
                gameGrid.DeleteGrid(this);
                textBoxNbrMoves.Text = "0";
            }
        }
    }
}
