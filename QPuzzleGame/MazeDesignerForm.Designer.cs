namespace QPuzzleGame
{
    partial class MazeDesignerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeDesignerForm));
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGenerateGrid = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxNbrRows = new System.Windows.Forms.TextBox();
            this.labelNbrRows = new System.Windows.Forms.Label();
            this.textBoxNbrColumns = new System.Windows.Forms.TextBox();
            this.labelNbrColumns = new System.Windows.Forms.Label();
            this.groupBoxToolbox = new System.Windows.Forms.GroupBox();
            this.buttonYellowBall = new System.Windows.Forms.Button();
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonGreenBall = new System.Windows.Forms.Button();
            this.buttonYellowDoor = new System.Windows.Forms.Button();
            this.buttonBlueBalls = new System.Windows.Forms.Button();
            this.buttonRedBall = new System.Windows.Forms.Button();
            this.buttonGreenDoor = new System.Windows.Forms.Button();
            this.buttonBlueDoor = new System.Windows.Forms.Button();
            this.buttonRedDoor = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.imageListToolbox = new System.Windows.Forms.ImageList(this.components);
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.menuStripFile.SuspendLayout();
            this.panelGenerateGrid.SuspendLayout();
            this.groupBoxToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFile
            // 
            this.menuStripFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStripFile.Size = new System.Drawing.Size(814, 27);
            this.menuStripFile.TabIndex = 0;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // panelGenerateGrid
            // 
            this.panelGenerateGrid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGenerateGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGenerateGrid.Controls.Add(this.buttonGenerate);
            this.panelGenerateGrid.Controls.Add(this.textBoxNbrRows);
            this.panelGenerateGrid.Controls.Add(this.labelNbrRows);
            this.panelGenerateGrid.Controls.Add(this.textBoxNbrColumns);
            this.panelGenerateGrid.Controls.Add(this.labelNbrColumns);
            this.panelGenerateGrid.Location = new System.Drawing.Point(1, 30);
            this.panelGenerateGrid.Name = "panelGenerateGrid";
            this.panelGenerateGrid.Size = new System.Drawing.Size(800, 42);
            this.panelGenerateGrid.TabIndex = 17;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(626, 5);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(90, 30);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxNbrRows
            // 
            this.textBoxNbrRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbrRows.Location = new System.Drawing.Point(501, 8);
            this.textBoxNbrRows.Name = "textBoxNbrRows";
            this.textBoxNbrRows.Size = new System.Drawing.Size(58, 22);
            this.textBoxNbrRows.TabIndex = 4;
            // 
            // labelNbrRows
            // 
            this.labelNbrRows.AutoSize = true;
            this.labelNbrRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrRows.Location = new System.Drawing.Point(311, 12);
            this.labelNbrRows.Name = "labelNbrRows";
            this.labelNbrRows.Size = new System.Drawing.Size(184, 16);
            this.labelNbrRows.TabIndex = 3;
            this.labelNbrRows.Text = "Enter number of rows (1 to 11):";
            // 
            // textBoxNbrColumns
            // 
            this.textBoxNbrColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbrColumns.Location = new System.Drawing.Point(223, 8);
            this.textBoxNbrColumns.Name = "textBoxNbrColumns";
            this.textBoxNbrColumns.Size = new System.Drawing.Size(58, 22);
            this.textBoxNbrColumns.TabIndex = 2;
            // 
            // labelNbrColumns
            // 
            this.labelNbrColumns.AutoSize = true;
            this.labelNbrColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbrColumns.Location = new System.Drawing.Point(11, 11);
            this.labelNbrColumns.Name = "labelNbrColumns";
            this.labelNbrColumns.Size = new System.Drawing.Size(206, 16);
            this.labelNbrColumns.TabIndex = 1;
            this.labelNbrColumns.Text = "Enter number of columns (1 to 12):";
            // 
            // groupBoxToolbox
            // 
            this.groupBoxToolbox.Controls.Add(this.buttonYellowBall);
            this.groupBoxToolbox.Controls.Add(this.buttonWall);
            this.groupBoxToolbox.Controls.Add(this.buttonGreenBall);
            this.groupBoxToolbox.Controls.Add(this.buttonYellowDoor);
            this.groupBoxToolbox.Controls.Add(this.buttonBlueBalls);
            this.groupBoxToolbox.Controls.Add(this.buttonRedBall);
            this.groupBoxToolbox.Controls.Add(this.buttonGreenDoor);
            this.groupBoxToolbox.Controls.Add(this.buttonBlueDoor);
            this.groupBoxToolbox.Controls.Add(this.buttonRedDoor);
            this.groupBoxToolbox.Controls.Add(this.buttonNone);
            this.groupBoxToolbox.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxToolbox.Location = new System.Drawing.Point(3, 78);
            this.groupBoxToolbox.Name = "groupBoxToolbox";
            this.groupBoxToolbox.Size = new System.Drawing.Size(164, 535);
            this.groupBoxToolbox.TabIndex = 18;
            this.groupBoxToolbox.TabStop = false;
            this.groupBoxToolbox.Text = "Your Toolbox";
            // 
            // buttonYellowBall
            // 
            this.buttonYellowBall.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellowBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellowBall.ImageIndex = 8;
            this.buttonYellowBall.ImageList = this.imageListToolbox;
            this.buttonYellowBall.Location = new System.Drawing.Point(10, 480);
            this.buttonYellowBall.Name = "buttonYellowBall";
            this.buttonYellowBall.Size = new System.Drawing.Size(130, 40);
            this.buttonYellowBall.TabIndex = 16;
            this.buttonYellowBall.Text = "Yellow Ball";
            this.buttonYellowBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellowBall.UseVisualStyleBackColor = true;
            this.buttonYellowBall.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonWall
            // 
            this.buttonWall.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWall.ImageIndex = 0;
            this.buttonWall.ImageList = this.imageListToolbox;
            this.buttonWall.Location = new System.Drawing.Point(10, 80);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.Size = new System.Drawing.Size(130, 40);
            this.buttonWall.TabIndex = 5;
            this.buttonWall.Text = "Wall";
            this.buttonWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonGreenBall
            // 
            this.buttonGreenBall.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreenBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenBall.ImageIndex = 7;
            this.buttonGreenBall.ImageList = this.imageListToolbox;
            this.buttonGreenBall.Location = new System.Drawing.Point(10, 430);
            this.buttonGreenBall.Name = "buttonGreenBall";
            this.buttonGreenBall.Size = new System.Drawing.Size(130, 40);
            this.buttonGreenBall.TabIndex = 15;
            this.buttonGreenBall.Text = "Green Ball";
            this.buttonGreenBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenBall.UseVisualStyleBackColor = true;
            this.buttonGreenBall.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonYellowDoor
            // 
            this.buttonYellowDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYellowDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellowDoor.ImageIndex = 4;
            this.buttonYellowDoor.ImageList = this.imageListToolbox;
            this.buttonYellowDoor.Location = new System.Drawing.Point(10, 280);
            this.buttonYellowDoor.Name = "buttonYellowDoor";
            this.buttonYellowDoor.Size = new System.Drawing.Size(130, 40);
            this.buttonYellowDoor.TabIndex = 4;
            this.buttonYellowDoor.Text = "Yellow Door";
            this.buttonYellowDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellowDoor.UseVisualStyleBackColor = true;
            this.buttonYellowDoor.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonBlueBalls
            // 
            this.buttonBlueBalls.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlueBalls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueBalls.ImageIndex = 6;
            this.buttonBlueBalls.ImageList = this.imageListToolbox;
            this.buttonBlueBalls.Location = new System.Drawing.Point(10, 380);
            this.buttonBlueBalls.Name = "buttonBlueBalls";
            this.buttonBlueBalls.Size = new System.Drawing.Size(130, 40);
            this.buttonBlueBalls.TabIndex = 14;
            this.buttonBlueBalls.Text = "Blue Ball";
            this.buttonBlueBalls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueBalls.UseVisualStyleBackColor = true;
            this.buttonBlueBalls.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonRedBall
            // 
            this.buttonRedBall.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedBall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedBall.ImageIndex = 5;
            this.buttonRedBall.ImageList = this.imageListToolbox;
            this.buttonRedBall.Location = new System.Drawing.Point(10, 330);
            this.buttonRedBall.Name = "buttonRedBall";
            this.buttonRedBall.Size = new System.Drawing.Size(130, 40);
            this.buttonRedBall.TabIndex = 13;
            this.buttonRedBall.Text = "Red Ball";
            this.buttonRedBall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedBall.UseVisualStyleBackColor = true;
            this.buttonRedBall.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonGreenDoor
            // 
            this.buttonGreenDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenDoor.ImageIndex = 3;
            this.buttonGreenDoor.ImageList = this.imageListToolbox;
            this.buttonGreenDoor.Location = new System.Drawing.Point(10, 230);
            this.buttonGreenDoor.Name = "buttonGreenDoor";
            this.buttonGreenDoor.Size = new System.Drawing.Size(130, 40);
            this.buttonGreenDoor.TabIndex = 3;
            this.buttonGreenDoor.Text = "Green Door";
            this.buttonGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenDoor.UseVisualStyleBackColor = true;
            this.buttonGreenDoor.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonBlueDoor
            // 
            this.buttonBlueDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueDoor.ImageIndex = 2;
            this.buttonBlueDoor.ImageList = this.imageListToolbox;
            this.buttonBlueDoor.Location = new System.Drawing.Point(10, 180);
            this.buttonBlueDoor.Name = "buttonBlueDoor";
            this.buttonBlueDoor.Size = new System.Drawing.Size(130, 40);
            this.buttonBlueDoor.TabIndex = 2;
            this.buttonBlueDoor.Text = "Blue Door";
            this.buttonBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueDoor.UseVisualStyleBackColor = true;
            this.buttonBlueDoor.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonRedDoor
            // 
            this.buttonRedDoor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedDoor.ImageIndex = 1;
            this.buttonRedDoor.ImageList = this.imageListToolbox;
            this.buttonRedDoor.Location = new System.Drawing.Point(10, 130);
            this.buttonRedDoor.Name = "buttonRedDoor";
            this.buttonRedDoor.Size = new System.Drawing.Size(130, 40);
            this.buttonRedDoor.TabIndex = 1;
            this.buttonRedDoor.Text = "Red Door";
            this.buttonRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedDoor.UseVisualStyleBackColor = true;
            this.buttonRedDoor.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // buttonNone
            // 
            this.buttonNone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNone.Location = new System.Drawing.Point(10, 30);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(130, 40);
            this.buttonNone.TabIndex = 0;
            this.buttonNone.Text = "None";
            this.buttonNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.TileSelect_Click);
            // 
            // imageListToolbox
            // 
            this.imageListToolbox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolbox.ImageStream")));
            this.imageListToolbox.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListToolbox.Images.SetKeyName(0, "Wall.png");
            this.imageListToolbox.Images.SetKeyName(1, "RedDoor.png");
            this.imageListToolbox.Images.SetKeyName(2, "BlueDoor.png");
            this.imageListToolbox.Images.SetKeyName(3, "GreenDoor.png");
            this.imageListToolbox.Images.SetKeyName(4, "YellowDoor.png");
            this.imageListToolbox.Images.SetKeyName(5, "RedBall.png");
            this.imageListToolbox.Images.SetKeyName(6, "BlueBall.png");
            this.imageListToolbox.Images.SetKeyName(7, "GreenBall.png");
            this.imageListToolbox.Images.SetKeyName(8, "YellowBall.png");
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "Savegame files (*.qgame) | *.qgame";
            // 
            // dlgLoad
            // 
            this.dlgLoad.Filter = "Savegame files (*.qgame) | *.qgame";
            // 
            // MazeDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 616);
            this.Controls.Add(this.panelGenerateGrid);
            this.Controls.Add(this.groupBoxToolbox);
            this.Controls.Add(this.menuStripFile);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripFile;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MazeDesignerForm";
            this.Text = "Design Form";
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.panelGenerateGrid.ResumeLayout(false);
            this.panelGenerateGrid.PerformLayout();
            this.groupBoxToolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelGenerateGrid;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxNbrRows;
        private System.Windows.Forms.Label labelNbrRows;
        private System.Windows.Forms.TextBox textBoxNbrColumns;
        private System.Windows.Forms.Label labelNbrColumns;
        private System.Windows.Forms.GroupBox groupBoxToolbox;
        private System.Windows.Forms.Button buttonYellowBall;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.Button buttonGreenBall;
        private System.Windows.Forms.Button buttonYellowDoor;
        private System.Windows.Forms.Button buttonBlueBalls;
        private System.Windows.Forms.Button buttonRedBall;
        private System.Windows.Forms.Button buttonGreenDoor;
        private System.Windows.Forms.Button buttonBlueDoor;
        private System.Windows.Forms.Button buttonRedDoor;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.ImageList imageListToolbox;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgLoad;
    }
}