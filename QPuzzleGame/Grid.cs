/*
 * Grid class: contains a 2D matrix of Tile elements representing
 * the game board
 * Revision History
 *                  Iryna Shynkevych:   20.10.2018 Created 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QPuzzleGame
{
    /// <summary>
    /// Class Grid contains the grid of Tile-typed elements representing the
    /// game board
    /// </summary>
    public class Grid
    {
        public static int TOP_OFFSET = 80;
        public static int GAP = -1;

        private Tile[,] gridOfTiles;

        private Timer timer;
        private bool isMoving = false;

        /// <summary>
        /// The property is Moving identifies whether a ball is moving or not
        /// and based on it, activates and deactivates the timer.
        /// </summary>
        public bool IsMoving
        {
            get { return isMoving; }
            set
            {
                isMoving = value;
                if (isMoving)
                {
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                }
            }
        }
        /// <summary>
        /// The Timer property with its get and set methods
        /// </summary>
        public Timer Timer { get => timer; set => timer = value; }

        /// <summary>
        /// The Grid constructor: draws a grid of different tile types
        /// </summary>
        /// <param name="myForm">form the grid will be drawn on</param>
        ///  <param name="nbrColumns">number of columns in the grid</param>
        ///  <param name="nbrRows">number of rows in the grid</param>
        ///  <param name="tileTypesSaved">an array of strings containing the tile types</param>
        ///  <param name="leftOffset">determines the left offset of the grid (different for
        ///  MazeDesignerForm and PlayForm)</param>
        public Grid(Form myForm, int nbrColumns, int nbrRows, string[] tileTypesSaved,
            int leftOffset)
        {
            // grid is being drawn
            gridOfTiles = new Tile[nbrColumns, nbrRows];
            for (int i = 0; i < nbrColumns; i++)
            {
                for (int j = 0; j < nbrRows; j++)
                {
                    gridOfTiles[i, j] = new Tile();
                    gridOfTiles[i, j].Location = new Point(i * (Tile.WIDTH + GAP) +
                        leftOffset, j * (Tile.HEIGHT + GAP) + TOP_OFFSET);

                    //for when a saved layout is being loaded
                    if (tileTypesSaved != null)
                    {
                        int typeOfTile = int.Parse(tileTypesSaved[i * nbrRows
                            + j]);

                        // no image for empty cell
                        if (typeOfTile != -1)
                        {
                            gridOfTiles[i, j].AssignTyleType(typeOfTile);
                        }
                    }
                    if (myForm is PlayForm)
                    {
                        gridOfTiles[i, j].BorderStyle = BorderStyle.None;
                    }
                    gridOfTiles[i, j].Column = i;
                    gridOfTiles[i, j].Row = j;
                    gridOfTiles[i, j].BringToFront();
                    myForm.Controls.Add(gridOfTiles[i, j]);
                }
            }
            timer = new Timer();
            timer.Interval = 150;
            timer.Enabled = true;
            timer.Stop();
        }

        // The method that allows to determine the dimensions of the matrix
        public int GetLength(int dim)
        {
            if (dim == 0) { return gridOfTiles.GetLength(0); }
            else if (dim == 1) { return gridOfTiles.GetLength(1); }
            else { throw new Exception("The parameter is outside the bounds"); }
        }

        // Index operators overload
        public Tile this[int index1, int index2]
        {
            get
            {
                return gridOfTiles[index1, index2];
            }

            set
            {
                gridOfTiles[index1, index2] = value;
            }
        }

        // The method that deletes the grid after the grid after the game is over
        // or before drawing a new one
        public void DeleteGrid(Form myForm)
        {
            for (int i = 0; i < gridOfTiles.GetLength(0); i++)
            {
                for (int j = 0; j < gridOfTiles.GetLength(1); j++)
                {
                    myForm.Controls.Remove(gridOfTiles[i, j]);
                }
            }
        }
    }
}