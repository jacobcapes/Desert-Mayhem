﻿
namespace Desert_Mayhem
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.PnlGame = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.tmrAllyCar = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DrawEnemy1tmr = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.FuelTank = new System.Windows.Forms.ProgressBar();
            this.Fueltmr = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmrFuel = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Tan;
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Controls.Add(this.GameOver);
            this.PnlGame.Location = new System.Drawing.Point(12, 49);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1000, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PnlGame_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Desert_Mayhem.Properties.Resources.pause;
            this.pictureBox1.Location = new System.Drawing.Point(395, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameOver
            // 
            this.GameOver.Image = ((System.Drawing.Image)(resources.GetObject("GameOver.Image")));
            this.GameOver.Location = new System.Drawing.Point(418, 223);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(106, 60);
            this.GameOver.TabIndex = 0;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // tmrAllyCar
            // 
            this.tmrAllyCar.Enabled = true;
            this.tmrAllyCar.Interval = 10;
            this.tmrAllyCar.Tick += new System.EventHandler(this.tmrAllyCar_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DrawEnemy1tmr
            // 
            this.DrawEnemy1tmr.Enabled = true;
            this.DrawEnemy1tmr.Interval = 10000;
            this.DrawEnemy1tmr.Tick += new System.EventHandler(this.DrawEnemy1tmr_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 3;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1063, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(1063, 157);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // FuelTank
            // 
            this.FuelTank.Location = new System.Drawing.Point(1040, 199);
            this.FuelTank.Name = "FuelTank";
            this.FuelTank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FuelTank.Size = new System.Drawing.Size(123, 31);
            this.FuelTank.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FuelTank.TabIndex = 3;
            this.FuelTank.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Fueltmr
            // 
            this.Fueltmr.Enabled = true;
            this.Fueltmr.Tick += new System.EventHandler(this.Fueltmr_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(1063, 288);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "0";
            // 
            // tmrFuel
            // 
            this.tmrFuel.Enabled = true;
            this.tmrFuel.Interval = 3;
            this.tmrFuel.Tick += new System.EventHandler(this.tmrFuel_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuPause});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStart
            // 
            this.menuStart.BackColor = System.Drawing.Color.Green;
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(43, 20);
            this.menuStart.Text = "Start";
            this.menuStart.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // menuPause
            // 
            this.menuPause.BackColor = System.Drawing.Color.Orange;
            this.menuPause.Name = "menuPause";
            this.menuPause.Size = new System.Drawing.Size(50, 20);
            this.menuPause.Text = "Pause";
            this.menuPause.Click += new System.EventHandler(this.menuPause_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.FuelTank);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGame";
            this.Text = "Desert Mayhem";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer tmrAllyCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer DrawEnemy1tmr;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ProgressBar FuelTank;
        private System.Windows.Forms.Timer Fueltmr;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tmrFuel;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuPause;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

