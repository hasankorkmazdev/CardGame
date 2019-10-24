using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame.ApplicationFiles
{
    class Score
    {
        int point1,point2;
        string player1,player2;
        List<string> scoreList = new List<string>();
      

        IO.InputOutput IOSystem = new IO.InputOutput(Application.StartupPath, "Score.txt");

        public string Player1 { get => player1; set => player1 = value; }
        public string Player2 { get => player2; set => player2 = value; }
        public int Point1 { get => point1; set => point1 = value; }
        public int Point2 { get => point2; set => point2 = value; }

        internal int SavePoint()
        {
            try
            {
                IOSystem.Write(DateTime.Now + "|" + Player1 + "|" + Point1+ "|" + Player2 + "|" + Point2);
                return 1;

            }
            catch (Exception)
            {

                return -1;

            }


        }
        internal List<string> ScoreList()
        {
            IOSystem.ReadAll(ref scoreList);
            return scoreList;
        }
    }
}
