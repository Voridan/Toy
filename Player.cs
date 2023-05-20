using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy
{
    public class Player
    {
        public string Name { get; set; }
        public int BestScore { get; set; }
        public int Score { get; set; }
        public Player(string name, bool newPlayer) 
        {
            Name = name;
            // read from file best score
            if(!newPlayer)
            {
                string line;
                try
                {
                    StreamReader sr = new StreamReader("..\\..\\players.txt");
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] splitLine = line.Split(',');
                        if (splitLine[0] == Name)
                        {
                            BestScore = int.Parse(splitLine[1]);
                            break;
                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void EndGame()
        {
            // write to the file name and last score if it is greater then best score
            if (Score > BestScore)
            {
                int row = 0;
                string line;

                try
                {
                    StreamReader sr = new StreamReader("..\\..\\players.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] splitLine = line.Split(',');
                        if (splitLine[0] == Name)
                            break;
                        line = sr.ReadLine();
                        row++;
                    }
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    string[] lines = File.ReadAllLines("..\\..\\players.txt");
                    lines[row] = $"{Name},{Score}";
                    File.WriteAllLines("..\\..\\players.txt", lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
