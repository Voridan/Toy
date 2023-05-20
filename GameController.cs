using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy
{
    public class GameController
    {
        public Timer Timer = new Timer();
        public List<Ball> LastBalls = new List<Ball>();
        public Ball CurrentBall;
        public Player Player;
        public bool NewPlayer = false;
        public int Interval = 1000;
        public int MissedBalls = 0;
        public int MissedThreshold;
        public GameController(int missedThreshold) 
        {
            MissedThreshold = missedThreshold;
        }
        public void InitializePlayer(string name)
        {
            Player = new Player(name, NewPlayer);
        }
        public bool CheckPlayer(string name)
        {
            return GetPlayersFromFile().Contains(name);
        }
        public bool AllBallsEqual()
        {
            return LastBalls.All(x => x.Cost == LastBalls[0].Cost);
        }
        public string GetPlayersFromFile()
        {
            StringBuilder sb = new StringBuilder();
            string line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\players.txt");
                line = sr.ReadLine();
               
                while (line != null)
                {
                    string[] splitLine = line.Split(',');
                    sb.AppendLine($"Name: {splitLine[0]} Best Score: {splitLine[1]}");
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return sb.ToString();
        }
        public void WritePlayerToFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\players.txt", true);
                sw.WriteLine($"{Player.Name},{Player.Score}");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
