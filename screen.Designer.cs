namespace Flappy_Bird
{
    partial class screen
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
            this.Mainscreenpanel = new System.Windows.Forms.Panel();
            this.MainscreenButtons = new System.Windows.Forms.TableLayoutPanel();
            this.MainscreenLeaderboardButton = new System.Windows.Forms.Button();
            this.MainscreenStartButton = new System.Windows.Forms.Button();
            this.LeaderBoardPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TopTenTable = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TopTenBackButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DiedPanel = new Flappy_Bird.GamePanel();
            this.DiedLeaderBoardButton = new System.Windows.Forms.Button();
            this.DiedMainMenuButton = new System.Windows.Forms.Button();
            this.DiedCurrectScore = new System.Windows.Forms.Label();
            this.DiedButtonRevive = new System.Windows.Forms.Button();
            this.DiedFinalScore = new System.Windows.Forms.Label();
            this.DiedLabelFooter = new System.Windows.Forms.Label();
            this.DiedLabelHeader = new System.Windows.Forms.Label();
            this.highScoreReachedpanel = new Flappy_Bird.GamePanel();
            this.button1 = new System.Windows.Forms.Button();
            this.HighScoreReachedName = new System.Windows.Forms.TextBox();
            this.HighScoreReachedPlace = new System.Windows.Forms.Label();
            this.HighScoreReachedScore = new System.Windows.Forms.Label();
            this.HighScoreReachedHeader = new System.Windows.Forms.Label();
            this.FlappyGamePanel = new Flappy_Bird.GamePanel();
            this.collitionBox = new System.Windows.Forms.PictureBox();
            this.groundPictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.Flappy = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Mainscreenpanel.SuspendLayout();
            this.MainscreenButtons.SuspendLayout();
            this.LeaderBoardPanel.SuspendLayout();
            this.TopTenTable.SuspendLayout();
            this.DiedPanel.SuspendLayout();
            this.highScoreReachedpanel.SuspendLayout();
            this.FlappyGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collitionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainscreenpanel
            // 
            this.Mainscreenpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainscreenpanel.BackgroundImage = global::Flappy_Bird.Properties.Resources.mainscreen21;
            this.Mainscreenpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mainscreenpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mainscreenpanel.Controls.Add(this.MainscreenButtons);
            this.Mainscreenpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainscreenpanel.Name = "Mainscreenpanel";
            this.Mainscreenpanel.Size = new System.Drawing.Size(935, 562);
            this.Mainscreenpanel.TabIndex = 1;
            this.Mainscreenpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainscreenpanel_Paint);
            // 
            // MainscreenButtons
            // 
            this.MainscreenButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainscreenButtons.BackColor = System.Drawing.Color.Transparent;
            this.MainscreenButtons.ColumnCount = 2;
            this.MainscreenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainscreenButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainscreenButtons.Controls.Add(this.MainscreenLeaderboardButton, 1, 0);
            this.MainscreenButtons.Controls.Add(this.MainscreenStartButton, 0, 0);
            this.MainscreenButtons.Location = new System.Drawing.Point(159, 346);
            this.MainscreenButtons.Name = "MainscreenButtons";
            this.MainscreenButtons.RowCount = 1;
            this.MainscreenButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainscreenButtons.Size = new System.Drawing.Size(614, 108);
            this.MainscreenButtons.TabIndex = 0;
            // 
            // MainscreenLeaderboardButton
            // 
            this.MainscreenLeaderboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MainscreenLeaderboardButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.MainscreenLeaderboardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainscreenLeaderboardButton.Location = new System.Drawing.Point(310, 3);
            this.MainscreenLeaderboardButton.Name = "MainscreenLeaderboardButton";
            this.MainscreenLeaderboardButton.Size = new System.Drawing.Size(232, 102);
            this.MainscreenLeaderboardButton.TabIndex = 3;
            this.MainscreenLeaderboardButton.Text = "Leaderboard";
            this.MainscreenLeaderboardButton.UseVisualStyleBackColor = false;
            this.MainscreenLeaderboardButton.Click += new System.EventHandler(this.showLeaderBoard);
            // 
            // MainscreenStartButton
            // 
            this.MainscreenStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MainscreenStartButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainscreenStartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainscreenStartButton.Location = new System.Drawing.Point(3, 3);
            this.MainscreenStartButton.Name = "MainscreenStartButton";
            this.MainscreenStartButton.Size = new System.Drawing.Size(232, 102);
            this.MainscreenStartButton.TabIndex = 0;
            this.MainscreenStartButton.Text = "Start";
            this.MainscreenStartButton.UseVisualStyleBackColor = false;
            this.MainscreenStartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LeaderBoardPanel
            // 
            this.LeaderBoardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderBoardPanel.BackgroundImage = global::Flappy_Bird.Properties.Resources.leaderboardscreen;
            this.LeaderBoardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeaderBoardPanel.Controls.Add(this.textBox1);
            this.LeaderBoardPanel.Controls.Add(this.TopTenTable);
            this.LeaderBoardPanel.Controls.Add(this.TopTenBackButton);
            this.LeaderBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.LeaderBoardPanel.Name = "LeaderBoardPanel";
            this.LeaderBoardPanel.Size = new System.Drawing.Size(935, 562);
            this.LeaderBoardPanel.TabIndex = 1;
            this.LeaderBoardPanel.Visible = false;
            this.LeaderBoardPanel.VisibleChanged += new System.EventHandler(this.LeaderBoardPanel_VisibleChanged);
            this.LeaderBoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainscreenpanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Top Ten Leaderboard";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopTenTable
            // 
            this.TopTenTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopTenTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TopTenTable.ColumnCount = 2;
            this.TopTenTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTenTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTenTable.Controls.Add(this.textBox3, 1, 0);
            this.TopTenTable.Controls.Add(this.textBox2, 0, 0);
            this.TopTenTable.Location = new System.Drawing.Point(182, 98);
            this.TopTenTable.Name = "TopTenTable";
            this.TopTenTable.RowCount = 11;
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.TopTenTable.Size = new System.Drawing.Size(622, 403);
            this.TopTenTable.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(314, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(305, 23);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Score";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.CausesValidation = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.HideSelection = false;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(305, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Name";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopTenBackButton
            // 
            this.TopTenBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopTenBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TopTenBackButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTenBackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopTenBackButton.Location = new System.Drawing.Point(406, 507);
            this.TopTenBackButton.Name = "TopTenBackButton";
            this.TopTenBackButton.Size = new System.Drawing.Size(178, 50);
            this.TopTenBackButton.TabIndex = 0;
            this.TopTenBackButton.Text = "Back";
            this.TopTenBackButton.UseVisualStyleBackColor = false;
            this.TopTenBackButton.Click += new System.EventHandler(this.TopTenBackButton_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.FlappyTimerEvent);
            // 
            // DiedPanel
            // 
            this.DiedPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(153)))), ((int)(((byte)(85)))));
            this.DiedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DiedPanel.Controls.Add(this.DiedLeaderBoardButton);
            this.DiedPanel.Controls.Add(this.DiedMainMenuButton);
            this.DiedPanel.Controls.Add(this.DiedCurrectScore);
            this.DiedPanel.Controls.Add(this.DiedButtonRevive);
            this.DiedPanel.Controls.Add(this.DiedFinalScore);
            this.DiedPanel.Controls.Add(this.DiedLabelFooter);
            this.DiedPanel.Controls.Add(this.DiedLabelHeader);
            this.DiedPanel.ForeColor = System.Drawing.Color.Black;
            this.DiedPanel.Location = new System.Drawing.Point(164, 64);
            this.DiedPanel.Name = "DiedPanel";
            this.DiedPanel.Size = new System.Drawing.Size(575, 403);
            this.DiedPanel.TabIndex = 1;
            this.DiedPanel.Visible = false;
            // 
            // DiedLeaderBoardButton
            // 
            this.DiedLeaderBoardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedLeaderBoardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiedLeaderBoardButton.Font = new System.Drawing.Font("Consolas", 19F, System.Drawing.FontStyle.Bold);
            this.DiedLeaderBoardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiedLeaderBoardButton.Location = new System.Drawing.Point(333, 325);
            this.DiedLeaderBoardButton.Name = "DiedLeaderBoardButton";
            this.DiedLeaderBoardButton.Size = new System.Drawing.Size(177, 49);
            this.DiedLeaderBoardButton.TabIndex = 6;
            this.DiedLeaderBoardButton.Text = "Leaderboard";
            this.DiedLeaderBoardButton.UseVisualStyleBackColor = false;
            // 
            // DiedMainMenuButton
            // 
            this.DiedMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedMainMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiedMainMenuButton.Font = new System.Drawing.Font("Consolas", 19F, System.Drawing.FontStyle.Bold);
            this.DiedMainMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiedMainMenuButton.Location = new System.Drawing.Point(93, 325);
            this.DiedMainMenuButton.Name = "DiedMainMenuButton";
            this.DiedMainMenuButton.Size = new System.Drawing.Size(177, 49);
            this.DiedMainMenuButton.TabIndex = 5;
            this.DiedMainMenuButton.Text = "Main menu";
            this.DiedMainMenuButton.UseVisualStyleBackColor = false;
            // 
            // DiedCurrectScore
            // 
            this.DiedCurrectScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedCurrectScore.AutoSize = true;
            this.DiedCurrectScore.Font = new System.Drawing.Font("Rockwell", 30F);
            this.DiedCurrectScore.Location = new System.Drawing.Point(109, 139);
            this.DiedCurrectScore.Name = "DiedCurrectScore";
            this.DiedCurrectScore.Size = new System.Drawing.Size(299, 46);
            this.DiedCurrectScore.TabIndex = 4;
            this.DiedCurrectScore.Text = "Current score: ";
            this.DiedCurrectScore.Visible = false;
            // 
            // DiedButtonRevive
            // 
            this.DiedButtonRevive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedButtonRevive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiedButtonRevive.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.DiedButtonRevive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiedButtonRevive.Location = new System.Drawing.Point(198, 325);
            this.DiedButtonRevive.Name = "DiedButtonRevive";
            this.DiedButtonRevive.Size = new System.Drawing.Size(177, 49);
            this.DiedButtonRevive.TabIndex = 3;
            this.DiedButtonRevive.Text = "Revive";
            this.DiedButtonRevive.UseVisualStyleBackColor = false;
            this.DiedButtonRevive.Visible = false;
            this.DiedButtonRevive.Click += new System.EventHandler(this.DiedButtonRevive_Click);
            // 
            // DiedFinalScore
            // 
            this.DiedFinalScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedFinalScore.AutoSize = true;
            this.DiedFinalScore.Font = new System.Drawing.Font("Rockwell", 30F);
            this.DiedFinalScore.Location = new System.Drawing.Point(109, 139);
            this.DiedFinalScore.Name = "DiedFinalScore";
            this.DiedFinalScore.Size = new System.Drawing.Size(244, 46);
            this.DiedFinalScore.TabIndex = 2;
            this.DiedFinalScore.Text = "Final score: ";
            this.DiedFinalScore.Visible = false;
            // 
            // DiedLabelFooter
            // 
            this.DiedLabelFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedLabelFooter.AutoSize = true;
            this.DiedLabelFooter.Font = new System.Drawing.Font("Rockwell", 30F);
            this.DiedLabelFooter.Location = new System.Drawing.Point(85, 80);
            this.DiedLabelFooter.Name = "DiedLabelFooter";
            this.DiedLabelFooter.Size = new System.Drawing.Size(425, 46);
            this.DiedLabelFooter.TabIndex = 1;
            this.DiedLabelFooter.Text = "You have no lives left.";
            // 
            // DiedLabelHeader
            // 
            this.DiedLabelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiedLabelHeader.AutoSize = true;
            this.DiedLabelHeader.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiedLabelHeader.Location = new System.Drawing.Point(158, 21);
            this.DiedLabelHeader.Name = "DiedLabelHeader";
            this.DiedLabelHeader.Size = new System.Drawing.Size(251, 59);
            this.DiedLabelHeader.TabIndex = 0;
            this.DiedLabelHeader.Text = "You died!";
            // 
            // highScoreReachedpanel
            // 
            this.highScoreReachedpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.highScoreReachedpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(153)))), ((int)(((byte)(85)))));
            this.highScoreReachedpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.highScoreReachedpanel.Controls.Add(this.button1);
            this.highScoreReachedpanel.Controls.Add(this.HighScoreReachedName);
            this.highScoreReachedpanel.Controls.Add(this.HighScoreReachedPlace);
            this.highScoreReachedpanel.Controls.Add(this.HighScoreReachedScore);
            this.highScoreReachedpanel.Controls.Add(this.HighScoreReachedHeader);
            this.highScoreReachedpanel.ForeColor = System.Drawing.Color.Black;
            this.highScoreReachedpanel.Location = new System.Drawing.Point(164, 64);
            this.highScoreReachedpanel.Name = "highScoreReachedpanel";
            this.highScoreReachedpanel.Size = new System.Drawing.Size(575, 403);
            this.highScoreReachedpanel.TabIndex = 1;
            this.highScoreReachedpanel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(198, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighScoreReachedName
            // 
            this.HighScoreReachedName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HighScoreReachedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HighScoreReachedName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreReachedName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HighScoreReachedName.Location = new System.Drawing.Point(198, 251);
            this.HighScoreReachedName.Name = "HighScoreReachedName";
            this.HighScoreReachedName.Size = new System.Drawing.Size(177, 39);
            this.HighScoreReachedName.TabIndex = 3;
            this.HighScoreReachedName.Text = "Name here";
            this.HighScoreReachedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HighScoreReachedPlace
            // 
            this.HighScoreReachedPlace.AutoSize = true;
            this.HighScoreReachedPlace.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreReachedPlace.Location = new System.Drawing.Point(138, 185);
            this.HighScoreReachedPlace.Name = "HighScoreReachedPlace";
            this.HighScoreReachedPlace.Size = new System.Drawing.Size(155, 42);
            this.HighScoreReachedPlace.TabIndex = 2;
            this.HighScoreReachedPlace.Text = "Place: #";
            // 
            // HighScoreReachedScore
            // 
            this.HighScoreReachedScore.AutoSize = true;
            this.HighScoreReachedScore.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreReachedScore.Location = new System.Drawing.Point(138, 126);
            this.HighScoreReachedScore.Name = "HighScoreReachedScore";
            this.HighScoreReachedScore.Size = new System.Drawing.Size(134, 42);
            this.HighScoreReachedScore.TabIndex = 1;
            this.HighScoreReachedScore.Text = "Score: ";
            // 
            // HighScoreReachedHeader
            // 
            this.HighScoreReachedHeader.AutoSize = true;
            this.HighScoreReachedHeader.Font = new System.Drawing.Font("Rockwell", 28F, System.Drawing.FontStyle.Bold);
            this.HighScoreReachedHeader.Location = new System.Drawing.Point(13, 37);
            this.HighScoreReachedHeader.Name = "HighScoreReachedHeader";
            this.HighScoreReachedHeader.Size = new System.Drawing.Size(551, 47);
            this.HighScoreReachedHeader.TabIndex = 0;
            this.HighScoreReachedHeader.Text = "You\'ve reached a highscore!";
            // 
            // FlappyGamePanel
            // 
            this.FlappyGamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlappyGamePanel.BackgroundImage = global::Flappy_Bird.Properties.Resources.leaderboardscreen;
            this.FlappyGamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlappyGamePanel.Controls.Add(this.collitionBox);
            this.FlappyGamePanel.Controls.Add(this.groundPictureBox);
            this.FlappyGamePanel.Controls.Add(this.ScoreLabel);
            this.FlappyGamePanel.Controls.Add(this.PipeBottom);
            this.FlappyGamePanel.Controls.Add(this.Flappy);
            this.FlappyGamePanel.Controls.Add(this.PipeTop);
            this.FlappyGamePanel.Location = new System.Drawing.Point(0, 0);
            this.FlappyGamePanel.Name = "FlappyGamePanel";
            this.FlappyGamePanel.Size = new System.Drawing.Size(1055, 562);
            this.FlappyGamePanel.TabIndex = 1;
            this.FlappyGamePanel.Visible = false;
            // 
            // collitionBox
            // 
            this.collitionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.collitionBox.BackColor = System.Drawing.Color.Transparent;
            this.collitionBox.Location = new System.Drawing.Point(805, 0);
            this.collitionBox.Name = "collitionBox";
            this.collitionBox.Size = new System.Drawing.Size(10, 512);
            this.collitionBox.TabIndex = 6;
            this.collitionBox.TabStop = false;
            this.collitionBox.Tag = "movable";
            // 
            // groundPictureBox
            // 
            this.groundPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groundPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.groundPictureBox.Location = new System.Drawing.Point(0, 497);
            this.groundPictureBox.Name = "groundPictureBox";
            this.groundPictureBox.Size = new System.Drawing.Size(935, 65);
            this.groundPictureBox.TabIndex = 5;
            this.groundPictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(3, 2);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(210, 59);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // PipeBottom
            // 
            this.PipeBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.PipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(674, 389);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(141, 323);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 3;
            this.PipeBottom.TabStop = false;
            this.PipeBottom.Tag = "movable";
            // 
            // Flappy
            // 
            this.Flappy.BackColor = System.Drawing.Color.Transparent;
            this.Flappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Flappy.ErrorImage = null;
            this.Flappy.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Flappy.InitialImage = null;
            this.Flappy.Location = new System.Drawing.Point(170, 203);
            this.Flappy.Name = "Flappy";
            this.Flappy.Size = new System.Drawing.Size(80, 60);
            this.Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy.TabIndex = 2;
            this.Flappy.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PipeTop.BackColor = System.Drawing.Color.Transparent;
            this.PipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(674, -140);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(141, 321);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            this.PipeTop.Tag = "movable";
            // 
            // screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.DiedPanel);
            this.Controls.Add(this.highScoreReachedpanel);
            this.Controls.Add(this.Mainscreenpanel);
            this.Controls.Add(this.FlappyGamePanel);
            this.Controls.Add(this.LeaderBoardPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            this.Mainscreenpanel.ResumeLayout(false);
            this.MainscreenButtons.ResumeLayout(false);
            this.LeaderBoardPanel.ResumeLayout(false);
            this.LeaderBoardPanel.PerformLayout();
            this.TopTenTable.ResumeLayout(false);
            this.TopTenTable.PerformLayout();
            this.DiedPanel.ResumeLayout(false);
            this.DiedPanel.PerformLayout();
            this.highScoreReachedpanel.ResumeLayout(false);
            this.highScoreReachedpanel.PerformLayout();
            this.FlappyGamePanel.ResumeLayout(false);
            this.FlappyGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collitionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainscreenButtons;
        private System.Windows.Forms.Button MainscreenLeaderboardButton;
        private System.Windows.Forms.Button MainscreenStartButton;
        private System.Windows.Forms.Button TopTenBackButton;
        private System.Windows.Forms.Panel Mainscreenpanel;
        private System.Windows.Forms.Panel LeaderBoardPanel;
        private System.Windows.Forms.TableLayoutPanel TopTenTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Flappy;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox groundPictureBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox collitionBox;
        private GamePanel FlappyGamePanel;
        private GamePanel DiedPanel;
        private GamePanel highScoreReachedpanel;
        private System.Windows.Forms.Label DiedLabelHeader;
        private System.Windows.Forms.Label DiedLabelFooter;
        private System.Windows.Forms.Label DiedFinalScore;
        private System.Windows.Forms.Button DiedButtonRevive;
        private System.Windows.Forms.Label HighScoreReachedHeader;
        private System.Windows.Forms.TextBox HighScoreReachedName;
        private System.Windows.Forms.Label HighScoreReachedPlace;
        private System.Windows.Forms.Label HighScoreReachedScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DiedCurrectScore;
        private System.Windows.Forms.Button DiedLeaderBoardButton;
        private System.Windows.Forms.Button DiedMainMenuButton;
    }
}