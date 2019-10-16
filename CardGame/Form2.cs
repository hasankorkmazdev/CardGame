using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnStart.Image = ApplicationData.Data.Play_32px;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) || !String.IsNullOrWhiteSpace(textBox2.Text))
            {
                Form1 f1 = new Form1(textBox1.Text.ToUpper(), textBox2.Text.ToUpper());
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Boş Değerler Var","isNull Empty or White Space");
            }
            
        }
    }
}
