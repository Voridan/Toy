using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Toy
{

    public partial class Game : Form
    {
        GameController Controller;
        public Game()
        {
            InitializeComponent();
            Controller = new GameController(5);
        }
        private void Game_Load_1(object sender, EventArgs e)
        {
            content.Text = "у випадкових місцях у межах вікна з'являються різноколірні кружечки на нетривалий період. " +
                "За цей час потрібно клацнути на них мишкою. За кожне попадання нараховують очки, за кожен пропущений " +
                "кружечок нараховують штраф. Гра завершується, коли штраф досягає" + $" {Controller.MissedThreshold}";
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            ShowPopUp();
            content.Visible = false;
            showPlayers.Visible = false;
            startGame.Visible = false;
            scoreInfo.Visible = true;
            stopGame.Visible = true;
            bestScore.Text = Controller.Player.BestScore.ToString();
        }   
        private void showPlayers_Click(object sender, EventArgs e)
        {
            content.Text = Controller.GetPlayersFromFile();
        }
        public void GameProccess()
        {
            Controller.Timer.Tick += BallLifeCycle;
            Controller.Timer.Tick += PenaltyWatcher;
            Controller.Timer.Interval = Controller.Interval;
            Controller.Timer.Start();
        }
        public void PenaltyWatcher(object sender, EventArgs args)
        {
            if(Controller.MissedBalls >= Controller.MissedThreshold)
                EndGame();
        }
        public void BallOnClick(object sender, EventArgs args)
        {
            Controller.LastBalls.Add(Controller.CurrentBall);
            Controls.Remove(Controller.CurrentBall);

            if (Controller.LastBalls.Count > 1)
            {
                if (Controller.AllBallsEqual())
                    Controller.Player.Score += Controller.CurrentBall.Cost * 2;
                else
                    Controller.LastBalls.Clear();
            }

            score.Text = $"{Controller.Player.Score += Controller.CurrentBall.Cost}";
            
            if (Controller.Player.Score != 0 && Controller.Player.Score % 4 == 0)
            {
                Controller.Interval -= 100;
            }
        }
        public void BallLifeCycle(object sender, EventArgs args)
        {
            if (Controls.Contains(Controller.CurrentBall))
            {
                Controller.MissedBalls++;
                Controls.Remove(Controller.CurrentBall);
            }
            Controller.CurrentBall = new Ball(ClientSize.Width, ClientSize.Height); ;
            Controller.CurrentBall.Click += BallOnClick;
            Controls.Add(Controller.CurrentBall);
            Controller.CurrentBall.BringToFront();
        }
       
        private void ShowPopUp()
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 200;
            prompt.Text = "Увійти";
            prompt.Location = new Point(500,500);
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "введіть своє ім'я" };
            TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            if (!Controller.CheckPlayer(inputBox.Text)) // if player doesn't exists
                Controller.NewPlayer = true;
            Controller.InitializePlayer(inputBox.Text);
            GameProccess();
        }
        private void stopGame_Click(object sender, EventArgs e)
        {
            EndGame();
        }
        private void EndGame()
        {
            Controller.Timer.Stop();

            if (Controller.NewPlayer)
            {
                MessageBox.Show($"Гравець {Controller.Player.Name}, Результат {Controller.Player.Score}, Найкращий результат {Controller.Player.Score}");
                Controller.WritePlayerToFile();
            }
            else
            {
                MessageBox.Show($"Гравець {Controller.Player.Name}, Результат {Controller.Player.Score}, Найкращий результат {Controller.Player.BestScore}");
                Controller.Player.EndGame();
            }
            content.Visible = true;
            showPlayers.Visible = true;
            startGame.Visible = true;
            scoreInfo.Visible = false;
            stopGame.Visible = false;

            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is Ball)
                    Controls.RemoveAt(i);
            }
        }
    }
}
