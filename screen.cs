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
        /// <summary>
        /// Configuration of the app.
        /// </summary>
        private bool local = true;
        static int pipeSpeed = 10;
        static int gravity = 13;
        static int score = 0;
        static int lives = 3;
        static int ticks = 0;
        int bottomYPipe = 0;
        int[] scores = new int[3];
        Point flappyLocation = Point.Empty;
        Point pipeTopLocation = Point.Empty;
        Point pipeBottomLocation = Point.Empty;
        Point collitionBoxLocation = Point.Empty;

        /// <summary>
        /// Constructer of the app. This will get runned when the app starts.
        /// </summary>
        public screen()
        {
            InitializeComponent();
            Mainscreenpanel.Visible = true;
            Mainscreenpanel.BringToFront();
            KeyPreview = true;
        }

        /// <summary>
        /// Creates a text box for the leaderboard.
        /// </summary>
        /// <param name="text">the text that will display in the text box.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Start button. This will start the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This will show the leaderboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showLeaderBoard(object sender, EventArgs e)
        {
            // HOME SCREEN LEADERBOARD BUTTON CLICK EVENT
            Mainscreenpanel.Visible = false;
            if (DiedPanel.Visible)
            {
                DiedPanel.SendToBack();
                DiedPanel.Visible = false;
                FlappyGamePanel.Visible = false;
            }
            LeaderBoardPanel.Visible = true;
            LeaderBoardPanel.BringToFront();
        }

        private void mainscreenpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// This will call the api and update the leaderboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaderBoardPanel_VisibleChanged(object sender, EventArgs e)
        {
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

        /// <summary>
        /// This will send you back to the main screen from the leaderboard screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopTenBackButton_Click(object sender, EventArgs e)
        {
            // TOPTEN BACK BUTTON
            LeaderBoardPanel.Visible = false;
            TopTenTable.Controls.Clear();
            Mainscreenpanel.Visible = true;
            Mainscreenpanel.BringToFront();
            LeaderBoardPanel.SendToBack();
        }

        /// <summary>
        /// This will run every 20ms and will handle everything movable on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlappyTimerEvent(object sender, EventArgs e)
        {
            if (ticks >= 50 * 2 * 5 / (pipeSpeed / 2))
            {
                PictureBox top = CreatePipeTop();
                top.Left = FlappyGamePanel.Right;
                PictureBox bottom = CreatePipeBottom();
                bottom.Left = FlappyGamePanel.Right;
                PictureBox box = CreateCollitionBox();
                box.Left = FlappyGamePanel.Right + 50;
                box.Height = FlappyGamePanel.Height;
                //TODO 50 should be a calculated value for different screen sizes.
                top.Height = new Random().Next(top.Height, (box.Height / 2) + 1 - 50);
                //TODO 150 should be a calculated value for different screen sizes.
                int bottomHeightInc = new Random().Next(bottom.Height, (box.Height / 2) + 1 - 150) - bottom.Height;
                bottom.Height = bottomHeightInc + bottom.Height;
                bottom.Location = new Point(bottom.Location.X, bottom.Location.Y - bottomHeightInc);
                FlappyGamePanel.Controls.Add(top);
                FlappyGamePanel.Controls.Add(bottom);
                FlappyGamePanel.Controls.Add(box);
                ticks = 0;
            }
            Flappy.Top += gravity;
            if (flappyLocation == Point.Empty || pipeTopLocation == Point.Empty || pipeBottomLocation == Point.Empty || collitionBoxLocation == Point.Empty || bottomYPipe == 0)
            {
                flappyLocation = Flappy.Location;
                pipeTopLocation = PipeTop.Location;
                pipeBottomLocation = PipeBottom.Location;
                collitionBoxLocation = collitionBox.Location;
                bottomYPipe = PipeBottom.Location.Y;
            }

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
                        if (score % 5 == 0)
                        {
                            pipeSpeed += 3;
                        }
                    }
                    if (pipe.Name != "collitionBox" && Flappy.Bounds.IntersectsWith(pipe.Bounds) || Flappy.Bounds.IntersectsWith(groundPictureBox.Bounds) || Flappy.Bounds.IntersectsWith(AirPictureBox.Bounds))
                    {
                        died();
                        break;
                    }
                }
            }



            ticks++;
        }

        /// <summary>
        /// This will be runned every time a key gets pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -13;
            }

        }

        /// <summary>
        /// this will be runned every time a key gets released.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 13;
            }
        }

        /// <summary>
        /// Starts the flappy game.
        /// </summary>
        void startGame()
        {
            scores = new int[3];
            lives = 3;
            pipeSpeed = 10;
            Timer.Start();
            ActiveForm.Select();
        }

        /// <summary>
        /// This will resume the game after being dead and still having lives left.
        /// </summary>
        void resumeGame()
        {
            Timer.Start();
            ActiveForm.Select();
        }

        /// <summary>
        /// this will stop the game from runnning.
        /// </summary>
        void stopGame()
        {
            Timer.Stop();
            resetGame();
        }

        /// <summary>
        /// This will handle everything when you died.
        /// </summary>
        void died()
        {
            lives -= 1;
            Timer.Stop();
            resetGame();
            scores[lives] = score;
            score = 0;
            ScoreLabel.Text = $"Score: {score}";
            int scoresSum = scores.Sum();
            if (lives > 0)
            {
                DiedLabelFooter.Text = $"You have {lives} lives left.";
                DiedCurrectScore.Text = $"Current score: {scoresSum}";
                DiedCurrectScore.Visible = true;
                DiedFinalScore.Visible = false;
                DiedButtonRevive.Visible = true;
                DiedMainMenuButton.Visible = false;
                DiedLeaderBoardButton.Visible = false;
            }
            else if (lives <= 0)
            {
                DiedLabelFooter.Text = $"You have no lives left.";
                DiedFinalScore.Text = $"Final score: {scoresSum}";
                DiedCurrectScore.Visible = false;
                DiedFinalScore.Visible = true;
                DiedButtonRevive.Visible = false;
                DiedMainMenuButton.Visible = true;
                DiedLeaderBoardButton.Visible = true;

                int Top10Place = isInTop10(scoresSum);
                if (Top10Place <= 10 && Top10Place != -1)
                {
                    highScoreReachedpanel.Visible = true;
                    highScoreReachedpanel.BringToFront();
                    HighScoreReachedPlace.Text += Top10Place.ToString();
                    HighScoreReachedScore.Text += scoresSum;
                    return;
                }
            }

            DiedPanel.BringToFront();
            DiedPanel.Visible = true;

        }

        /// <summary>
        /// this will do nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void screen_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Button click to save the highscore and username in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveHighScore(object sender, EventArgs e)
        {
            // HIGH SCORE REACHED NAME INPUT SENDING!!
            string name = HighScoreReachedName.Text;
            if (name == "Name here" || name == "")
            {
                return;
            }
            int scorePoints = scores.Sum();
            highScoreReachedpanel.Visible = false;
            highScoreReachedpanel.SendToBack();
            DiedPanel.BringToFront();
            DiedPanel.Visible = true;
            savePoints(name, scorePoints);
        }


        /// <summary>
        /// Revive button for when you've died and still have lives left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            resumeGame();
        }

        /// <summary>
        /// Resets the game.
        /// </summary>
        private void resetGame()
        {
            for (int i = 0; i < FlappyGamePanel.Controls.Count; i++)
            {
                if (FlappyGamePanel.Controls[i].Tag != null && FlappyGamePanel.Controls[i].Tag.ToString() == "movable")
                {
                    FlappyGamePanel.Controls.Remove(FlappyGamePanel.Controls[i]);
                }
            }
        }

        /// <summary>
        /// Creating the top pipe.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Creating the bottom pipe.
        /// </summary>
        /// <returns></returns>
        PictureBox CreatePipeBottom()
        {
            PictureBox pipe = new PictureBox();
            pipe.Anchor = AnchorStyles.Bottom;
            pipe.BackColor = Color.Transparent;
            pipe.Image = Properties.Resources.pipe;
            pipe.Location = pipeBottomLocation;
            pipe.Name = "PipeBottom";
            pipe.Size = new Size(141, 155);
            pipe.SizeMode = PictureBoxSizeMode.StretchImage;
            pipe.TabIndex = 0;
            pipe.TabStop = false;
            pipe.Tag = "movable";
            return pipe;
        }

        /// <summary>
        /// Creating a collition box.
        /// </summary>
        /// <returns></returns>
        PictureBox CreateCollitionBox()
        {
            PictureBox collitionBox = new PictureBox();
            collitionBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom);
            collitionBox.BackColor = Color.Transparent;
            collitionBox.Location = collitionBoxLocation;
            collitionBox.Name = "collitionBox";
            collitionBox.Size = new Size(10, 512);
            collitionBox.TabIndex = 6;
            collitionBox.TabStop = false;
            collitionBox.Tag = "movable";
            return collitionBox;
        }

        /// <summary>
        /// Checks if the points fall in the top ten or not
        /// Gives back the amount the position it's supposed to be at.
        /// </summary>
        /// <param name="points">The points it checks for.</param>
        /// <returns></returns>
        int isInTop10(int points)
        {
            string host = local == false ? "188.166.85.248:5555" : "localhost:5555";
            RestClient restClient = new RestClient(httpVerb.GET);
            restClient.endPoint = $"http://{host}/api/v1/stats/calctop/{points}";
            restClient.host = host;
            string responseString = restClient.makeRequest();
            try
            {
                IsTopTen response = JsonConvert.DeserializeObject<IsTopTen>(responseString);
                return response.place;
            }
            catch
            {
                return -1;
            }
        }
        /// <summary>
        /// Saving the score to the database using the API.
        /// </summary>
        /// <param name="username">The username of the player</param>
        /// <param name="points">The score of the player</param>
        void savePoints(string username, int points)
        {
            // Using localhost or the dedi
            string host = local == false ? "188.166.85.248:5555" : "localhost:5555";
            RestClient restClient = new RestClient(httpVerb.POST);
            restClient.endPoint = $"http://{host}/api/v1/stats/{username}/{points}";
            restClient.host = host;
            restClient.makeRequest();
        }

        /// <summary>
        /// back to main screen panel when you have died 3 times.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiedMainMenuButton_Click(object sender, EventArgs e)
        {
            DiedPanel.Visible = false;
            DiedPanel.SendToBack();
            FlappyGamePanel.Visible = false;
            FlappyGamePanel.SendToBack();
            Mainscreenpanel.Visible = true;
            Mainscreenpanel.BringToFront();
        }
    }
}
