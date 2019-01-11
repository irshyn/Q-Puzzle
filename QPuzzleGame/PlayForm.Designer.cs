namespace QPuzzleGame
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGenerateGrid = new System.Windows.Forms.Panel();
            this.textBoxNumberBalls = new System.Windows.Forms.TextBox();
            this.labelNumberBalls = new System.Windows.Forms.Label();
            this.textBoxNbrMoves = new System.Windows.Forms.TextBox();
            this.labelNbrMoves = new System.Windows.Forms.Label();
            this.groupBoxAnimation = new System.Windows.Forms.GroupBox();
            this.checkBoxAnimation = new System.Windows.Forms.CheckBox();
            this.groupBoxSelection = new System.Windows.Forms.GroupBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.menuStripFile.SuspendLayout();
            this.panelGenerateGrid.SuspendLayout();
            this.groupBoxAnimation.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(809, 25);
            this.menuStripFile.TabIndex = 0;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // panelGenerateGrid
            // 
            this.panelGenerateGrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGenerateGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGenerateGrid.Controls.Add(this.textBoxNumberBalls);
            this.panelGenerateGrid.Controls.Add(this.labelNumberBalls);
            this.panelGenerateGrid.Controls.Add(this.textBoxNbrMoves);
            this.panelGenerateGrid.Controls.Add(this.labelNbrMoves);
            this.panelGenerateGrid.Location = new System.Drawing.Point(0, 29);
            this.panelGenerateGrid.Name = "panelGenerateGrid";
            this.panelGenerateGrid.Size = new System.Drawing.Size(809, 42);
            this.panelGenerateGrid.TabIndex = 22;
            // 
            // textBoxNumberBalls
            // 
            this.textBoxNumberBalls.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumberBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberBalls.Location = new System.Drawing.Point(462, 9);
            this.textBoxNumberBalls.Name = "textBoxNumberBalls";
            this.textBoxNumberBalls.ReadOnly = true;
            this.textBoxNumberBalls.Size = new System.Drawing.Size(58, 22);
            this.textBoxNumberBalls.TabIndex = 4;
            // 
            // labelNumberBalls
            // 
            this.labelNumberBalls.AutoSize = true;
            this.labelNumberBalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberBalls.Location = new System.Drawing.Point(293, 11);
            this.labelNumberBalls.Name = "labelNumberBalls";
            this.labelNumberBalls.Size = new System.Drawing.Size(149, 16);
            this.labelNumberBalls.TabIndex = 3;
            this.labelNumberBalls.Text = "The number of balls left:";
            // 
            // textBoxNbrMoves
            // 
            this.textBoxNbrMoves.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNbrMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbrMoves.Location = new System.Drawing.Point(181, 11);
            this.textBoxNbrMoves.Name = "textBoxNbrMoves";
            this.textBoxNbrMoves.ReadOnly = true;
            this.textBoxNbrMoves.Size = new System.Drawing.Size(58, 22);
            this.textBoxNbrMoves.TabIndex = 2;
            // 
            // labelNbrMoves
            // 
            this.labelNbrMoves.AutoSize = true;
            this.labelNbrMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrMoves.Location = new System.Drawing.Point(11, 11);
            this.labelNbrMoves.Name = "labelNbrMoves";
            this.labelNbrMoves.Size = new System.Drawing.Size(141, 16);
            this.labelNbrMoves.TabIndex = 1;
            this.labelNbrMoves.Text = "The number of moves:";
            // 
            // groupBoxAnimation
            // 
            this.groupBoxAnimation.Controls.Add(this.checkBoxAnimation);
            this.groupBoxAnimation.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnimation.Location = new System.Drawing.Point(12, 434);
            this.groupBoxAnimation.Name = "groupBoxAnimation";
            this.groupBoxAnimation.Size = new System.Drawing.Size(204, 86);
            this.groupBoxAnimation.TabIndex = 25;
            this.groupBoxAnimation.TabStop = false;
            this.groupBoxAnimation.Text = "Animation";
            // 
            // checkBoxAnimation
            // 
            this.checkBoxAnimation.AutoSize = true;
            this.checkBoxAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAnimation.Location = new System.Drawing.Point(9, 46);
            this.checkBoxAnimation.Name = "checkBoxAnimation";
            this.checkBoxAnimation.Size = new System.Drawing.Size(169, 24);
            this.checkBoxAnimation.TabIndex = 0;
            this.checkBoxAnimation.Text = "Select for animation";
            this.checkBoxAnimation.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelection
            // 
            this.groupBoxSelection.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSelection.Location = new System.Drawing.Point(12, 77);
            this.groupBoxSelection.Name = "groupBoxSelection";
            this.groupBoxSelection.Size = new System.Drawing.Size(204, 145);
            this.groupBoxSelection.TabIndex = 24;
            this.groupBoxSelection.TabStop = false;
            this.groupBoxSelection.Text = "Ball Selected";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonRight);
            this.groupBoxControls.Controls.Add(this.buttonLeft);
            this.groupBoxControls.Controls.Add(this.buttonDown);
            this.groupBoxControls.Controls.Add(this.buttonUp);
            this.groupBoxControls.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxControls.Location = new System.Drawing.Point(12, 239);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(204, 169);
            this.groupBoxControls.TabIndex = 23;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Your Controls";
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(132, 87);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(55, 55);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(9, 87);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(55, 55);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(70, 87);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(55, 55);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(70, 28);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(55, 55);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // dlgLoad
            // 
            this.dlgLoad.Filter = "Savegame files (*.qgame) | *.qgame";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 561);
            this.Controls.Add(this.panelGenerateGrid);
            this.Controls.Add(this.groupBoxAnimation);
            this.Controls.Add(this.groupBoxSelection);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.menuStripFile);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "PlayForm";
            this.Text = "Play Form";
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.panelGenerateGrid.ResumeLayout(false);
            this.panelGenerateGrid.PerformLayout();
            this.groupBoxAnimation.ResumeLayout(false);
            this.groupBoxAnimation.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelGenerateGrid;
        private System.Windows.Forms.TextBox textBoxNumberBalls;
        private System.Windows.Forms.Label labelNumberBalls;
        private System.Windows.Forms.TextBox textBoxNbrMoves;
        private System.Windows.Forms.Label labelNbrMoves;
        private System.Windows.Forms.GroupBox groupBoxAnimation;
        private System.Windows.Forms.CheckBox checkBoxAnimation;
        private System.Windows.Forms.GroupBox groupBoxSelection;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.OpenFileDialog dlgLoad;
    }
}