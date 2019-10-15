using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame.ApplicationFiles;

namespace CardGame
{
    public partial class Form1 : Form
    {

        public Form1(string Player1, string Player2)
        {
            InitializeComponent();
            this.Player1 = Player1;
            this.Player2 = Player2;

        }
        Gamer gamer1;
        Gamer gamer2;
        Game NewGame;
        List<Card> newCards;
        int GamerFlag=0;
        string Player1, Player2;
        private void Form1_Load(object sender, EventArgs e)
        {
            gamer1 = new Gamer(Player1);
            gamer2 = new Gamer(Player2);
            NewGame = new Game(gamer1, gamer2);
            newCards = NewGame.MainDeck;
            int scroolTracing = 0;
            int scroolY = 0;
            int scroolX = 0;
            label1.Text = gamer1.Name + " : " + gamer1.Score;
            label2.Text = gamer2.Name + " : " + gamer2.Score;



            foreach (var item in newCards)
            {
                if (scroolTracing == 10)
                {
                    scroolTracing = 0;
                    scroolY += 105;
                    scroolX = 0;
                }
                Button btn = new Button();
                btn.Click += new EventHandler(CardClick);
                btn.Name = "ID" + item.Id;
                btn.Text = "ID : " + item.Id;
                btn.Size = new Size(75, 100);
                btn.Location = new Point(80 * scroolX + 15, scroolY + 15);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.Red;
                pnlMain.Controls.Add(btn);
                scroolX += 1;
                scroolTracing++;

            }
        }
        private void CardClick(object sender, EventArgs e)
        {
            Card
           /* if (GamerFlag==0)
            {
                GamerFlag = 1;
               
            }
            else if (GamerFlag==1)
            {
                GamerFlag = 0;
            }*/
          NewGame.FindCard()
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Control> FocusTracking = new List<Control>();
            Control lastFocus = FocusTracking[FocusTracking.Count - 1];
        }


    }
}
