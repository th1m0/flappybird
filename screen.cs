using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Flappy_Bird.api;
using Newtonsoft.Json;

namespace Flappy_Bird
{
    public partial class screen : Form
    {
        private bool local = false;
        static int pipeSpeed = 10;
        static int gravity = 15;
        static int score = 0;
        static int lives = 3;
        static int ticks = 0;
        int[] scores = new int[5];
        Point flappyLocation = Point.Empty;
        Point pipeTopLocation = Point.Empty;
        Point pipeBottomLocation = Point.Empty;
        Point collitionBoxLocation = Point.Empty;

        /**
         * 
         * TODO: 
         * better pipe handling
         * saving points
         * fix "air" bug
         * config
         * presentation
         * 
         */


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
            if (ticks == 50 * 2)
            {
                PictureBox top = CreatePipeTop();
                top.Left = FlappyGamePanel.Right;
                PictureBox bottom = CreatePipeBottom();
                bottom.Left = FlappyGamePanel.Right;
                PictureBox box = CreateCollitionBox();
                box.Left = FlappyGamePanel.Right;
                FlappyGamePanel.Controls.Add(top);
                FlappyGamePanel.Controls.Add(bottom);
                FlappyGamePanel.Controls.Add(box);
                Console.WriteLine("Now.");
                ticks = 0;
            }
            Flappy.Top += gravity;
            /*PipeBottom.Left -= pipeSpeed;
            PipeTop.Left -= pipeSpeed;
            collitionBox.Left -= pipeSpeed;*/
            if (flappyLocation == Point.Empty || pipeTopLocation == Point.Empty || pipeBottomLocation == Point.Empty || collitionBoxLocation == Point.Empty)
            {
                flappyLocation = Flappy.Location;
                pipeTopLocation = PipeTop.Location;
                pipeBottomLocation = PipeBottom.Location;
                collitionBoxLocation = collitionBox.Location;
            }
            Console.WriteLine("Controls length: " + FlappyGamePanel.Controls.Count);
            for (int i = 0; i < FlappyGamePanel.Controls.Count; i++)
            {
                if (FlappyGamePanel.Controls[i].Tag != null && FlappyGamePanel.Controls[i].Tag.ToString() == "movable")
                {
                    var pipe = FlappyGamePanel.Controls[i];
                    FlappyGamePanel.Controls[i].Left -= pipeSpeed;

                    if (pipe.Left < FlappyGamePanel.Left - 150)
                    {
                        FlappyGamePanel.Controls.Remove(pipe);
                    }
                    if (pipe.Name == "collitionBox" && Flappy.Bounds.IntersectsWith(pipe.Bounds) && pipe.Visible)
                    {
                        score++;
                        ScoreLabel.Text = $"Score: {score}";
                        pipe.Visible = false;
                    }
                    if (pipe.Name != "collitionBox" && Flappy.Bounds.IntersectsWith(pipe.Bounds) || Flappy.Bounds.IntersectsWith(groundPictureBox.Bounds))
                    {
                        Console.WriteLine("DIED.");
                        died();
                        break;
                    }
                }
            }



            ticks++;
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
            ActiveForm.Select();
        }

        void stopGame()
        {
            Timer.Stop();
            resetGame();
            Console.WriteLine("STOPPED THE GAME.");
        }

        void died()
        {
            lives -= 1;
            Timer.Stop();
            resetGame();
            scores[lives] = score;
            score = 0;
            ScoreLabel.Text = $"Score: {score}";
            if (lives > 0)
            {
                DiedLabelFooter.Text = $"You have {lives} lives left.";
                DiedCurrectScore.Text = $"Current score: {scores.Sum()}";
                DiedCurrectScore.Visible = true;
                DiedFinalScore.Visible = false;
                DiedButtonRevive.Visible = true;
                DiedMainMenuButton.Visible = false;
                DiedLeaderBoardButton.Visible = false;
            }
            else if (score <= 0)
            {
                DiedLabelFooter.Text = $"You have no lives left.";
                DiedFinalScore.Text = $"Final score: {scores.Sum()}";
                DiedCurrectScore.Visible = false;
                DiedFinalScore.Visible = true;
                DiedButtonRevive.Visible = false;
                DiedMainMenuButton.Visible = true;
                DiedLeaderBoardButton.Visible = true;
            }

            DiedPanel.BringToFront();
            DiedPanel.Visible = true;

        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // HIGH SCORE REACHED NAME INPUT SENDING!!
        }

        private void DiedButtonRevive_Click(object sender, EventArgs e)
        {
            // REVIVE BUTTON!!
            if (!DiedPanel.Visible)
            {
                return;
            }
            //resetGame();
            DiedPanel.SendToBack();
            DiedPanel.Visible = false;
            ActiveForm.Select();
            startGame();
        }

        private void resetGame()
        {
            Flappy.Location = flappyLocation;
            PipeTop.Location = pipeTopLocation;
            PipeBottom.Location = pipeBottomLocation;
            collitionBox.Location = collitionBoxLocation;
        }

        PictureBox CreatePipeTop()
        {
            PictureBox pipe = new PictureBox();
            pipe.Anchor = AnchorStyles.Top;
            pipe.BackColor = Color.Transparent;
            pipe.Image = Properties.Resources.pipedown;
            pipe.Location = pipeTopLocation;
            pipe.Name = "PipeTop";
            pipe.Size = new Size(141, 321);
            pipe.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe.TabIndex = 0;
            pipe.TabStop = false;
            pipe.Tag = "movable";
            return pipe;
        }

        PictureBox CreatePipeBottom()
        {
            PictureBox pipe = new PictureBox();
            pipe.Anchor = AnchorStyles.Bottom;
            pipe.BackColor = Color.Transparent;
            pipe.Image = Properties.Resources.pipe;
            pipe.Location = pipeBottomLocation;
            pipe.Name = "PipeBottom";
            pipe.Size = new Size(141, 323);
            pipe.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe.TabIndex = 3;
            pipe.TabStop = false;
            pipe.Tag = "movable";
            return pipe;
        }

        PictureBox CreateCollitionBox()
        {
            PictureBox collitionBox = new PictureBox();
            collitionBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
            collitionBox.BackColor = Color.White;
            collitionBox.Location = collitionBoxLocation;
            collitionBox.Name = "collitionBox";
            collitionBox.Size = new Size(10, 512);
            collitionBox.TabIndex = 6;
            collitionBox.TabStop = false;
            collitionBox.Tag = "movable";
            return collitionBox;
        }
    }
}
