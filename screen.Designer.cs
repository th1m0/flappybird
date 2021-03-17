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
            this.MainscreenButtons = new System.Windows.Forms.TableLayoutPanel();
            this.MainscreenLeaderboardButton = new System.Windows.Forms.Button();
            this.MainscreenStartButton = new System.Windows.Forms.Button();
            this.Mainscreenpanel = new System.Windows.Forms.Panel();
            this.MainscreenButtons.SuspendLayout();
            this.Mainscreenpanel.SuspendLayout();
            this.SuspendLayout();
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
            this.MainscreenLeaderboardButton.Click += new System.EventHandler(this.button2_Click);
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
            // screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.Mainscreenpanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainscreenButtons.ResumeLayout(false);
            this.Mainscreenpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainscreenButtons;
        private System.Windows.Forms.Button MainscreenLeaderboardButton;
        private System.Windows.Forms.Button MainscreenStartButton;
        private System.Windows.Forms.Panel Mainscreenpanel;
    }
}