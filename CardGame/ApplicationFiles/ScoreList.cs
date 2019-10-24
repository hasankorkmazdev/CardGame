using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame.ApplicationFiles
{
    public partial class ScoreList : Form
    {
        public ScoreList()
        {
            InitializeComponent();
        }
        ApplicationFiles.Score score = new ApplicationFiles.Score();
        private void ScoreList_Load(object sender, EventArgs e)
        {
            List<string> score;

            score = this.score.ScoreList();

            dgvList.Columns.Add("Date", "Tarih");
            dgvList.Columns.Add("Gamer1Name", "Oyuncu 1");
            dgvList.Columns.Add("Gamer1Score", "Puanı ");
            dgvList.Columns.Add("Gamer2Name", "Oyuncu 2");
            dgvList.Columns.Add("Gamer2Score", "Puanı ");
            this.dgvList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            foreach (string item in score)
            {
                dgvList.Rows.Add(item.Split('|')[0], item.Split('|')[1], item.Split('|')[2] + " Puan", item.Split('|')[3], item.Split('|')[4] + " Puan");
            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
