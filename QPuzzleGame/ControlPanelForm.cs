/*
 * ControlPanelForm contains the first-to-appear form that prompts the user
 * to choose among three options: play, design a game level, or exit
 * Revision History
 *                  Iryna Shynkevych:   20.09.2018 Created 
 */
using System;
using System.Windows.Forms;

namespace QPuzzleGame
{
    /// <summary>
    /// ControlPanelForm prompts the user to choose whether they want to
    /// design a new level or play a game
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        /// <summary>
        /// Default constructor initializing the components
        /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button leading to the Designer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDesign_Click(object sender, EventArgs e)
        {
            Form newForm = new MazeDesignerForm();
            newForm.Show();
            this.Hide();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Form newForm = new PlayForm();
            newForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Button that exits the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
