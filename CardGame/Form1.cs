using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
            btnShutDown.Image = ApplicationData.Data.Shutdown64px;
            btnStartGame.Image = ApplicationData.Data.Play_64px;
            this.Player1 = Player1;
            this.Player2 = Player2;

        }
        #region define-variable
        Gamer gamer1;
        Gamer gamer2;
        Game newGame;
        List<Card> newCards;
        int changeGamer = 0;
        string Player1, Player2;
        PictureBox firstCard, lastCard;
        int cardFlag = 0;
        int cardStatus = 0;
        int timerCounter = 5;
        bool isLoad = true;
        bool colorTracking = false;
        bool waitOneMiliSecond = false;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            int scroolTracing = 0;
            int scroolY = 0;
            int scroolX = 0;
            gamer1 = new Gamer(Player1);
            gamer2 = new Gamer(Player2);
            newGame = new Game(gamer1, gamer2);
            newCards = newGame.MainDeck;

            lblGamer1.Text = gamer1.Name + " : " + gamer1.Score;
            lblGamer2.Text = gamer2.Name + " : " + gamer2.Score;
            lblGamerNow.Text = "Sıradaki Oyuncu : " + gamer1.Name;
            lblTime.Text = "Kalan Zaman : " + timerCounter;
            lblTime.BackColor = Color.GreenYellow;
            foreach (var item in newCards)
            {
                if (scroolTracing == 10)
                {
                    scroolTracing = 0;
                    scroolY += 105;
                    scroolX = 0;
                }
                PictureBox img = new PictureBox();
                img.Click += new EventHandler(CardClick);
                img.Name = "ID" + item.Id;
                img.Text = "ID : " + item.Id;
                img.Tag = item.Id;
                img.Size = new Size(75, 100);
                img.Location = new Point(95 * scroolX + 20, scroolY + 15);
                img.SizeMode = PictureBoxSizeMode.Zoom;
                img.Image = new Bitmap(item.Image);
                //Oyun Başlamadan Tıkılamak Yok 
                img.Enabled = false;
                pnlMain.Controls.Add(img);
                scroolX += 1;
                scroolTracing++;
            }
            timer1.Start();
        }
        private void CardClick(object sender, EventArgs e)
        {
            timer1.Start();
            if (cardFlag == 0)
            {
                firstCard = (PictureBox)sender;
                cardFlag = 1;
                firstCard.Image = new Bitmap(newGame.FindCardImage((int)firstCard.Tag));

            }
            else if (cardFlag == 1)
            {
                lastCard = (PictureBox)sender;
                cardFlag = 0;
                lastCard.Image = new Bitmap(newGame.FindCardImage((int)lastCard.Tag));

                if (changeGamer == 0)
                {
                    timerCounter = 5;
                    cardStatus = newGame.CheckCard(gamer1, (int)firstCard.Tag, (int)lastCard.Tag);
                    if (cardStatus == 1)
                    {
                        firstCard.Visible = false;
                        lastCard.Visible = false;
                    }
                }
                else if (changeGamer == 1)
                {
                    timerCounter = 5;
                    cardStatus = newGame.CheckCard(gamer2, (int)firstCard.Tag, (int)lastCard.Tag);
                    if (cardStatus == 1)
                    {
                        firstCard.Visible = false;
                        lastCard.Visible = false;
                    }

                }
                if (cardStatus == 0)
                {
                    firstCard.Visible = false;
                    lastCard.Visible = false;
                    timer1.Stop();
                    lblGamer1.Text = "";
                    
                    if (gamer1.Score>=gamer2.Score)
                    {
                        MessageBox.Show("Oyun Bitti...\nKazanan Oyuncu : "+gamer1.Name, "Win Win Win");
                    }
                    else
                    {
                        MessageBox.Show("Oyun Bitti...\nKazanan Oyuncu : " + gamer2.Name,"Win Win Win");
                    }
                    
                }
                ChangeGamer(ref changeGamer);

            }
            lblGamer1.Text = gamer1.Name + " : " + gamer1.Score;
            lblGamer2.Text = gamer2.Name + " : " + gamer2.Score;
        }
        private void TimerCounter(object sender, EventArgs e)
        {
            //Tüm Kartlar 5 Saniye Gösterildi. Kartlar Kapatılıyor.
            if (timerCounter == 0 && isLoad == true)
            {
                foreach (PictureBox imgBox in pnlMain.Controls)
                {
                    imgBox.Image = ApplicationData.Data.Card_Behind;
                    imgBox.Enabled = true;
                }
                timerCounter = 5;
                isLoad = false;
                timer1.Stop();
            }
            else if (waitOneMiliSecond == true)
            {
                waitOneMiliSecond = false;
            }
            else if (timerCounter == 0)
            {

                timerCounter = 5;
                //Oyuncuyu Değiştir
                ChangeGamer(ref changeGamer);
            }
            else
            {
                lblTime.Text = "Kalan Zaman : " + timerCounter + " sn";
                timerCounter--;
                if (colorTracking == true)
                {
                    lblTime.BackColor = Color.GreenYellow;
                }
                else
                {
                    lblTime.BackColor = Color.Red;
                }
                colorTracking = (colorTracking == true) ? false : true;
            }
            lblTime.Text = "Kalan Zaman : " + timerCounter + " sn";
        }
        public void ChangeGamer(ref int gamerID)
        {

            if (firstCard != null)
            {
                firstCard.Image = ApplicationData.Data.Card_Behind;


            }
            if (lastCard != null)
            {
                lastCard.Image = ApplicationData.Data.Card_Behind;
            }

            firstCard = null;
            lastCard = null;
            cardFlag = 0;

            changeGamer = changeGamer == 0 ? 1 : 0;
            if (gamerID == 0)
            {
                lblGamerNow.Text = "Sıradaki Oyuncu : " + gamer1.Name.ToString(); ;
            }
            else
            {
                lblGamerNow.Text = "Sıradaki Oyuncu : " + gamer2.Name.ToString(); ;
            }
        }



        //TODO: Oyun Bitiş Kontrol Yapılcak


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(Player1,Player2);
            f1.Show();
            this.Hide();

        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
