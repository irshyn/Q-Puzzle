/*
 * Tile class: derives from PictureBox, has width, height and border properties
 * initialized; contains additional property: number corresponding to the this
 * tile's image
 * Revision History
 *                  Iryna Shynkevych:   20.09.2018 Created 
 */
using System.Windows.Forms;

namespace QPuzzleGame
{
    /// <summary>
    /// New class Tile that inherits from PictureBox and is used to facilitate game implemetation
    /// </summary>
    public class Tile : PictureBox
    {
        public static int WIDTH = 50;
        public static int HEIGHT = 50;

        // New property retaining a number corresponding to one of tile types
        public int TileType { set; get; } = -1;
        public int Column { set; get; } = 0;
        public int Row { set; get; } = 0;

        // <summary>
        /// Expansion of default constructor initializing some properties
        /// </summary>
        public Tile()
        {
            Width = WIDTH;
            Height = HEIGHT;
            Visible = true;
            BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Assigns picture to the instance based on the argument value
        /// </summary>
        /// <param name="tileTypeNumber">int valure of type of tyle we what
        /// our instance to display as image for: wall, blue door, etc.</param>
        public void AssignTyleType(int tileTypeNumber)
        {
            this.TileType = tileTypeNumber;

            switch (tileTypeNumber)
            {
                case -1:
                    if (this.Image != null)
                    {
                        this.Image.Dispose();
                        this.Image = null;
                    }
                    break;
                case 0:
                    this.Image = QPuzzleGame.Properties.Resources.Wall;
                    break;
                case 1:
                    this.Image = QPuzzleGame.Properties.Resources.RedDoor;
                    break;
                case 2:
                    this.Image = QPuzzleGame.Properties.Resources.BlueDoor;
                    break;
                case 3:
                    this.Image = QPuzzleGame.Properties.Resources.GreenDoor;
                    break;
                case 4:
                    this.Image = QPuzzleGame.Properties.Resources.YellowDoor;
                    break;
                case 5:
                    this.Image = QPuzzleGame.Properties.Resources.RedBall;
                    break;
                case 6:
                    this.Image = QPuzzleGame.Properties.Resources.BlueBall;
                    break;
                case 7:
                    this.Image = QPuzzleGame.Properties.Resources.GreenBall;
                    break;
                case 8:
                    this.Image = QPuzzleGame.Properties.Resources.YellowBall;
                    break;
                default:
                    break;
            }
        }
    }
}