using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flappy_Bird.api;
using Newtonsoft.Json;

namespace Flappy_Bird
{
    public partial class screen : Form
    {
        private bool local = false;
        int pipeSpeed = 15;
        int gravity = 15;
        int score = 0;
        public screen()
        {
            InitializeComponent();
            Mainscreenpanel.Visible = true;
            Mainscreenpanel.BringToFront();
            KeyPreview = true;
        }

        static TextBox topTenBox(string text)
        {
            TextBox txtBox = new TextBox
            {
                BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 15F),
                Location = new Point(3, 39),
                Name = "TopTenTxtBox",
                ReadOnly = true,
                ShortcutsEnabled = false,
                Size = new Size(398, 23),
                TabIndex = 2,
                Text = text,
                TextAlign = HorizontalAlignment.Center
            };
            return txtBox;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // HOME SCREEN START BUTTON CLICK EVENT
            if (FlappyGamePanel.Visible)
            {
                return;
            }
            Mainscreenpanel.Visible = false;
            FlappyGamePanel.Visible = true;
            startGame();
        }

        private void showLeaderBoard(object sender, EventArgs e)
        {
            // HOME SCREEN LEADERBOARD BUTTON CLICK EVENT
            Mainscreenpanel.Visible = false;
            LeaderBoardPanel.Visible = true;
            LeaderBoardPanel.BringToFront();
        }

        private void mainscreenpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeaderBoardPanel_VisibleChanged(object sender, EventArgs e)
        {
            Console.WriteLine(LeaderBoardPanel.Visible);
            if (LeaderBoardPanel.Visible == false)
            {
                return;
            }
            string host = local == false ? "188.166.85.248:5555" : "localhost:5555";
            RestClient restClient = new RestClient(httpVerb.GET);
            restClient.endPoint = $"http://{host}/api/v1/stats/top/10";
            restClient.host = host;
            string responseString = restClient.makeRequest();
            Data response = JsonConvert.DeserializeObject<Data>(responseString);
            for (int i = 0; i < response.amount; ++i)
            {
                TopTenTable.Controls.Add(topTenBox($"#{i + 1} {response.data[i].username}"));
                TopTenTable.Controls.Add(topTenBox($"{response.data[i].score}"));
            }
        }

        private void TopTenBackButton_Click(object sender, EventArgs e)
        {
            // TOPTEN BACK BUTTON
            LeaderBoardPanel.Visible = false;
            TopTenTable.Controls.Clear();
            Mainscreenpanel.Visible = true;
            Mainscreenpanel.BringToFront();
            LeaderBoardPanel.SendToBack();
        }

        private void FlappyTimerEvent(object sender, EventArgs e)
        {
            Flappy.Top += gravity;
            PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            ScoreLabel.Text = $"Score: {score}";
            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
            }
            if (PipeBottom.Left < -180)
            {
                PipeBottom.Left = 950;
            }

            if (Flappy.Bounds.IntersectsWith(PipeTop.Bounds) || Flappy.Bounds.IntersectsWith(PipeBottom.Bounds) || Flappy.Bounds.IntersectsWith(groundPictureBox.Bounds))
            {
                stopGame();
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        void startGame()
        {
            Timer.Start();
            Form.ActiveForm.Select();
        }

        void stopGame()
        {
            Timer.Stop();
        }
    }
}
