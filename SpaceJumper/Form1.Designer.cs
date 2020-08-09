namespace SpaceJumper
{
    partial class SpaceJumper
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
            this.pnlSamples = new System.Windows.Forms.Panel();
            this.picD8Sample = new System.Windows.Forms.PictureBox();
            this.picD6Sample = new System.Windows.Forms.PictureBox();
            this.picIPSFSample = new System.Windows.Forms.PictureBox();
            this.picBSSFSample = new System.Windows.Forms.PictureBox();
            this.picIPSFtoBSSFSample = new System.Windows.Forms.PictureBox();
            this.picBSSFtoIPSFSample = new System.Windows.Forms.PictureBox();
            this.tmrDice = new System.Windows.Forms.Timer(this.components);
            this.lblDice = new System.Windows.Forms.Label();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblDiceLandedOn = new System.Windows.Forms.Label();
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playeragainsntBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMoveCells = new System.Windows.Forms.Timer(this.components);
            this.tmrDiceShrink = new System.Windows.Forms.Timer(this.components);
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.tmrPlayerShrink = new System.Windows.Forms.Timer(this.components);
            this.picOpponent = new System.Windows.Forms.PictureBox();
            this.lblPlayersTurn = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblP1Moves = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblP2Moves = new System.Windows.Forms.Label();
            this.pnlSamples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picD8Sample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD6Sample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPSFSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSSFSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPSFtoBSSFSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSSFtoIPSFSample)).BeginInit();
            this.pnlBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSamples
            // 
            this.pnlSamples.Controls.Add(this.picD8Sample);
            this.pnlSamples.Controls.Add(this.picD6Sample);
            this.pnlSamples.Controls.Add(this.picIPSFSample);
            this.pnlSamples.Controls.Add(this.picBSSFSample);
            this.pnlSamples.Controls.Add(this.picIPSFtoBSSFSample);
            this.pnlSamples.Controls.Add(this.picBSSFtoIPSFSample);
            this.pnlSamples.Location = new System.Drawing.Point(706, 446);
            this.pnlSamples.Name = "pnlSamples";
            this.pnlSamples.Size = new System.Drawing.Size(200, 100);
            this.pnlSamples.TabIndex = 7;
            // 
            // picD8Sample
            // 
            this.picD8Sample.Image = global::SpaceJumper.Properties.Resources.DiceRollButtonD8;
            this.picD8Sample.Location = new System.Drawing.Point(31, 12);
            this.picD8Sample.Name = "picD8Sample";
            this.picD8Sample.Size = new System.Drawing.Size(135, 67);
            this.picD8Sample.TabIndex = 14;
            this.picD8Sample.TabStop = false;
            // 
            // picD6Sample
            // 
            this.picD6Sample.Image = global::SpaceJumper.Properties.Resources.DiceRollButton1;
            this.picD6Sample.Location = new System.Drawing.Point(36, 30);
            this.picD6Sample.Name = "picD6Sample";
            this.picD6Sample.Size = new System.Drawing.Size(135, 67);
            this.picD6Sample.TabIndex = 13;
            this.picD6Sample.TabStop = false;
            // 
            // picIPSFSample
            // 
            this.picIPSFSample.Image = global::SpaceJumper.Properties.Resources.InterPlanetarySpaceFleetAvatar;
            this.picIPSFSample.Location = new System.Drawing.Point(46, 15);
            this.picIPSFSample.Name = "picIPSFSample";
            this.picIPSFSample.Size = new System.Drawing.Size(50, 50);
            this.picIPSFSample.TabIndex = 5;
            this.picIPSFSample.TabStop = false;
            // 
            // picBSSFSample
            // 
            this.picBSSFSample.Image = global::SpaceJumper.Properties.Resources.BattleShipSpaceFleetAvatar;
            this.picBSSFSample.Location = new System.Drawing.Point(121, 15);
            this.picBSSFSample.Name = "picBSSFSample";
            this.picBSSFSample.Size = new System.Drawing.Size(50, 50);
            this.picBSSFSample.TabIndex = 6;
            this.picBSSFSample.TabStop = false;
            // 
            // picIPSFtoBSSFSample
            // 
            this.picIPSFtoBSSFSample.Image = global::SpaceJumper.Properties.Resources.ChangeTeamIPSFtoBCSF;
            this.picIPSFtoBSSFSample.Location = new System.Drawing.Point(46, 30);
            this.picIPSFtoBSSFSample.Name = "picIPSFtoBSSFSample";
            this.picIPSFtoBSSFSample.Size = new System.Drawing.Size(135, 67);
            this.picIPSFtoBSSFSample.TabIndex = 2;
            this.picIPSFtoBSSFSample.TabStop = false;
            // 
            // picBSSFtoIPSFSample
            // 
            this.picBSSFtoIPSFSample.Image = global::SpaceJumper.Properties.Resources.ChangeTeamBCSFtoIPSF;
            this.picBSSFtoIPSFSample.Location = new System.Drawing.Point(36, 15);
            this.picBSSFtoIPSFSample.Name = "picBSSFtoIPSFSample";
            this.picBSSFtoIPSFSample.Size = new System.Drawing.Size(135, 67);
            this.picBSSFtoIPSFSample.TabIndex = 3;
            this.picBSSFtoIPSFSample.TabStop = false;
            // 
            // tmrDice
            // 
            this.tmrDice.Tick += new System.EventHandler(this.tmrDice_Tick);
            // 
            // lblDice
            // 
            this.lblDice.BackColor = System.Drawing.Color.Transparent;
            this.lblDice.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice.Location = new System.Drawing.Point(727, 411);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(135, 41);
            this.lblDice.TabIndex = 9;
            this.lblDice.Text = "...";
            this.lblDice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.lblYouWin);
            this.pnlBoard.Controls.Add(this.lblDiceLandedOn);
            this.pnlBoard.Controls.Add(this.picBoard);
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(700, 745);
            this.pnlBoard.TabIndex = 10;
            // 
            // lblYouWin
            // 
            this.lblYouWin.BackColor = System.Drawing.Color.Transparent;
            this.lblYouWin.Font = new System.Drawing.Font("SimSun", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.ForeColor = System.Drawing.Color.Maroon;
            this.lblYouWin.Location = new System.Drawing.Point(12, 332);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(666, 84);
            this.lblYouWin.TabIndex = 12;
            this.lblYouWin.Text = "IPSF WINS!";
            this.lblYouWin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDiceLandedOn
            // 
            this.lblDiceLandedOn.BackColor = System.Drawing.Color.Transparent;
            this.lblDiceLandedOn.Font = new System.Drawing.Font("SimSun", 399.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceLandedOn.ForeColor = System.Drawing.Color.Maroon;
            this.lblDiceLandedOn.Location = new System.Drawing.Point(132, 129);
            this.lblDiceLandedOn.Name = "lblDiceLandedOn";
            this.lblDiceLandedOn.Size = new System.Drawing.Size(415, 471);
            this.lblDiceLandedOn.TabIndex = 2;
            this.lblDiceLandedOn.Text = "label1";
            this.lblDiceLandedOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoard
            // 
            this.picBoard.BackgroundImage = global::SpaceJumper.Properties.Resources.Board1;
            this.picBoard.Image = global::SpaceJumper.Properties.Resources.boardfinal;
            this.picBoard.Location = new System.Drawing.Point(0, 25);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(700, 700);
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            // 
            // mnsMenu
            // 
            this.mnsMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.diceModeToolStripMenuItem,
            this.gameModeToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(884, 26);
            this.mnsMenu.TabIndex = 13;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.reloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // diceModeToolStripMenuItem
            // 
            this.diceModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidedToolStripMenuItem,
            this.sidedToolStripMenuItem1});
            this.diceModeToolStripMenuItem.Name = "diceModeToolStripMenuItem";
            this.diceModeToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.diceModeToolStripMenuItem.Text = "Dice Mode";
            // 
            // sidedToolStripMenuItem
            // 
            this.sidedToolStripMenuItem.Name = "sidedToolStripMenuItem";
            this.sidedToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidedToolStripMenuItem.Text = "6-Sided";
            this.sidedToolStripMenuItem.Click += new System.EventHandler(this.sidedToolStripMenuItem_Click);
            // 
            // sidedToolStripMenuItem1
            // 
            this.sidedToolStripMenuItem1.Name = "sidedToolStripMenuItem1";
            this.sidedToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.sidedToolStripMenuItem1.Text = "8-Sided";
            this.sidedToolStripMenuItem1.Click += new System.EventHandler(this.sidedToolStripMenuItem1_Click);
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.playeragainsntBotToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gameModeToolStripMenuItem.Text = "Game Mode";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.playerToolStripMenuItem.Text = "2-Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // playeragainsntBotToolStripMenuItem
            // 
            this.playeragainsntBotToolStripMenuItem.Name = "playeragainsntBotToolStripMenuItem";
            this.playeragainsntBotToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.playeragainsntBotToolStripMenuItem.Text = "1-Player (versus bot)";
            this.playeragainsntBotToolStripMenuItem.Click += new System.EventHandler(this.playeragainsntBotToolStripMenuItem_Click);
            // 
            // tmrMoveCells
            // 
            this.tmrMoveCells.Interval = 20;
            this.tmrMoveCells.Tick += new System.EventHandler(this.tmrMoveCells_Tick);
            // 
            // tmrDiceShrink
            // 
            this.tmrDiceShrink.Enabled = true;
            this.tmrDiceShrink.Interval = 30;
            this.tmrDiceShrink.Tick += new System.EventHandler(this.tmrDiceShrink_Tick);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::SpaceJumper.Properties.Resources.InterPlanetarySpaceFleetAvatar;
            this.picAvatar.Location = new System.Drawing.Point(715, 549);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.TabIndex = 4;
            this.picAvatar.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.FlatAppearance.BorderSize = 0;
            this.btnRoll.Image = global::SpaceJumper.Properties.Resources.DiceRollButton;
            this.btnRoll.Location = new System.Drawing.Point(726, 343);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(136, 67);
            this.btnRoll.TabIndex = 8;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // tmrPlayerShrink
            // 
            this.tmrPlayerShrink.Interval = 2;
            this.tmrPlayerShrink.Tick += new System.EventHandler(this.tmrPlayerShrink_Tick);
            // 
            // picOpponent
            // 
            this.picOpponent.Image = global::SpaceJumper.Properties.Resources.BattleShipSpaceFleetAvatar;
            this.picOpponent.Location = new System.Drawing.Point(715, 605);
            this.picOpponent.Name = "picOpponent";
            this.picOpponent.Size = new System.Drawing.Size(50, 50);
            this.picOpponent.TabIndex = 14;
            this.picOpponent.TabStop = false;
            // 
            // lblPlayersTurn
            // 
            this.lblPlayersTurn.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersTurn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPlayersTurn.Location = new System.Drawing.Point(710, 309);
            this.lblPlayersTurn.Name = "lblPlayersTurn";
            this.lblPlayersTurn.Size = new System.Drawing.Size(164, 31);
            this.lblPlayersTurn.TabIndex = 15;
            this.lblPlayersTurn.Text = "P1\'s TURN";
            this.lblPlayersTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGameMode
            // 
            this.lblGameMode.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.ForeColor = System.Drawing.Color.Black;
            this.lblGameMode.Location = new System.Drawing.Point(710, 28);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(164, 31);
            this.lblGameMode.TabIndex = 16;
            this.lblGameMode.Text = "2-PLAYER";
            this.lblGameMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(726, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "P1\'s MOVES";
            // 
            // lblP1Moves
            // 
            this.lblP1Moves.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1Moves.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblP1Moves.Location = new System.Drawing.Point(754, 139);
            this.lblP1Moves.Name = "lblP1Moves";
            this.lblP1Moves.Size = new System.Drawing.Size(83, 24);
            this.lblP1Moves.TabIndex = 18;
            this.lblP1Moves.Text = "...";
            this.lblP1Moves.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(722, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "P2\'s MOVES";
            // 
            // lblP2Moves
            // 
            this.lblP2Moves.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2Moves.ForeColor = System.Drawing.Color.Maroon;
            this.lblP2Moves.Location = new System.Drawing.Point(754, 211);
            this.lblP2Moves.Name = "lblP2Moves";
            this.lblP2Moves.Size = new System.Drawing.Size(83, 24);
            this.lblP2Moves.TabIndex = 20;
            this.lblP2Moves.Text = "...";
            this.lblP2Moves.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SpaceJumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 725);
            this.Controls.Add(this.lblP2Moves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblP1Moves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.lblPlayersTurn);
            this.Controls.Add(this.picOpponent);
            this.Controls.Add(this.mnsMenu);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.lblDice);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pnlSamples);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "SpaceJumper";
            this.Text = "Form1";
            this.pnlSamples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picD8Sample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD6Sample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPSFSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSSFSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPSFtoBSSFSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBSSFtoIPSFSample)).EndInit();
            this.pnlBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOpponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.PictureBox picIPSFtoBSSFSample;
        private System.Windows.Forms.PictureBox picBSSFtoIPSFSample;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.PictureBox picIPSFSample;
        private System.Windows.Forms.PictureBox picBSSFSample;
        private System.Windows.Forms.Panel pnlSamples;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Timer tmrDice;
        private System.Windows.Forms.Label lblDice;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Timer tmrMoveCells;
        private System.Windows.Forms.Timer tmrDiceShrink;
        private System.Windows.Forms.Label lblDiceLandedOn;
        private System.Windows.Forms.PictureBox picD6Sample;
        private System.Windows.Forms.PictureBox picD8Sample;
        private System.Windows.Forms.Timer tmrPlayerShrink;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playeragainsntBotToolStripMenuItem;
        private System.Windows.Forms.PictureBox picOpponent;
        private System.Windows.Forms.Label lblPlayersTurn;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblP1Moves;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblP2Moves;
    }
}

