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
        public int Interval;
        public int MissedBalls = 0;
        public int MissedThreshold;
        public string Rules = string.Empty;
        public GameController(int missedThreshold, int interval=1000) 
        {
            Interval = interval;
            MissedThreshold = missedThreshold;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("У випадкових місцях у межах вікна з'являються різноколірні кружечки на нетривалий період." +
                "За цей час потрібно клацнути на них мишкою. За кожне попадання нараховують очки, за кожен пропущений " +
                "кружечок нараховують штраф. Гра завершується, коли штраф досягає" + $" {MissedThreshold} або кількість очок менша за -50");
            stringBuilder.AppendLine("Різна ціна кульок: червона - 10, жовта - 5, синя - 0, зелена - (-20)");
            stringBuilder.AppendLine("Якщо збити серію кульок однакового кольору, то очки подвоюються.");
            stringBuilder.AppendLine("Поступово зменшується період відображення кружечка");

            Rules = stringBuilder.ToString();
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
