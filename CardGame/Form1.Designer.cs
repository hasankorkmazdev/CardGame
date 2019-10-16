namespace CardGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblGamer2 = new System.Windows.Forms.Label();
            this.lblGamer1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGamerNow = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlLeftBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftBar.Controls.Add(this.btnStartGame);
            this.pnlLeftBar.Controls.Add(this.btnShutDown);
            this.pnlLeftBar.Controls.Add(this.panel1);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(200, 550);
            this.pnlLeftBar.TabIndex = 0;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShutDown.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShutDown.Location = new System.Drawing.Point(2, 481);
            this.btnShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(192, 64);
            this.btnShutDown.TabIndex = 11;
            this.btnShutDown.Text = "Kapat";
            this.btnShutDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutDown.UseVisualStyleBackColor = false;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblScoreTitle);
            this.panel1.Controls.Add(this.lblGamer2);
            this.panel1.Controls.Add(this.lblGamer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScoreTitle.Location = new System.Drawing.Point(41, 0);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(104, 21);
            this.lblScoreTitle.TabIndex = 2;
            this.lblScoreTitle.Text = "Skor Tablosu";
            // 
            // lblGamer2
            // 
            this.lblGamer2.AutoSize = true;
            this.lblGamer2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGamer2.Location = new System.Drawing.Point(11, 59);
            this.lblGamer2.Name = "lblGamer2";
            this.lblGamer2.Size = new System.Drawing.Size(80, 21);
            this.lblGamer2.TabIndex = 1;
            this.lblGamer2.Text = "Oyuncu :";
            // 
            // lblGamer1
            // 
            this.lblGamer1.AutoSize = true;
            this.lblGamer1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGamer1.Location = new System.Drawing.Point(11, 36);
            this.lblGamer1.Name = "lblGamer1";
            this.lblGamer1.Size = new System.Drawing.Size(80, 21);
            this.lblGamer1.TabIndex = 0;
            this.lblGamer1.Text = "Oyuncu :";
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.lblGamerNow);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(991, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(31, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 25);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Oyuncu :";
            // 
            // lblGamerNow
            // 
            this.lblGamerNow.AutoSize = true;
            this.lblGamerNow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGamerNow.Location = new System.Drawing.Point(32, 36);
            this.lblGamerNow.Name = "lblGamerNow";
            this.lblGamerNow.Size = new System.Drawing.Size(80, 21);
            this.lblGamerNow.TabIndex = 2;
            this.lblGamerNow.Text = "Oyuncu :";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(991, 450);
            this.pnlMain.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerCounter);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnStartGame.FlatAppearance.BorderSize = 0;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartGame.Location = new System.Drawing.Point(2, 413);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(192, 64);
            this.btnStartGame.TabIndex = 12;
            this.btnStartGame.Text = "Yeniden Başlat";
            this.btnStartGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 550);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeftBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLeftBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGamer1;
        private System.Windows.Forms.Label lblGamer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGamerNow;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Button btnStartGame;
    }
}

