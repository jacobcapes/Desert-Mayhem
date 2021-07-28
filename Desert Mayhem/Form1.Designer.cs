
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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmrAllyCar = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DrawEnemy1tmr = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.FuelTank = new System.Windows.Forms.ProgressBar();
            this.Fueltmr = new System.Windows.Forms.Timer(this.components);
            this.tmrFuel = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.missileRegen = new System.Windows.Forms.Timer(this.components);
            this.missileDisplay = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Fuel = new System.Windows.Forms.Label();
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
            this.PnlGame.Controls.Add(this.lblSpeed);
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
            this.pictureBox1.Location = new System.Drawing.Point(438, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 58);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GameOver
            // 
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Image = ((System.Drawing.Image)(resources.GetObject("GameOver.Image")));
            this.GameOver.Location = new System.Drawing.Point(418, 223);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(106, 60);
            this.GameOver.TabIndex = 0;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(908, 334);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "0";
            // 
            // tmrAllyCar
            // 
            this.tmrAllyCar.Interval = 3;
            this.tmrAllyCar.Tick += new System.EventHandler(this.tmrAllyCar_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DrawEnemy1tmr
            // 
            this.DrawEnemy1tmr.Interval = 10000;
            this.DrawEnemy1tmr.Tick += new System.EventHandler(this.DrawEnemy1tmr_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Interval = 10;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(1111, 120);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // FuelTank
            // 
            this.FuelTank.BackColor = System.Drawing.Color.Goldenrod;
            this.FuelTank.ForeColor = System.Drawing.Color.BurlyWood;
            this.FuelTank.Location = new System.Drawing.Point(1021, 293);
            this.FuelTank.Name = "FuelTank";
            this.FuelTank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FuelTank.Size = new System.Drawing.Size(146, 39);
            this.FuelTank.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FuelTank.TabIndex = 3;
            this.FuelTank.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Fueltmr
            // 
            this.Fueltmr.Tick += new System.EventHandler(this.Fueltmr_Tick);
            // 
            // tmrFuel
            // 
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(1072, 64);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 8;
            this.TxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtName_MouseClick);
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(1021, 349);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(146, 23);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "Check for High Score";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(1021, 526);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(146, 23);
            this.BtnQuit.TabIndex = 11;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // missileRegen
            // 
            this.missileRegen.Enabled = true;
            this.missileRegen.Interval = 70;
            this.missileRegen.Tick += new System.EventHandler(this.missileRegen_Tick);
            // 
            // missileDisplay
            // 
            this.missileDisplay.Location = new System.Drawing.Point(1021, 213);
            this.missileDisplay.Maximum = 99;
            this.missileDisplay.Name = "missileDisplay";
            this.missileDisplay.Size = new System.Drawing.Size(146, 38);
            this.missileDisplay.Step = 0;
            this.missileDisplay.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.missileDisplay.TabIndex = 1;
            this.missileDisplay.Click += new System.EventHandler(this.missileDisplay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Missile Reload";
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.Location = new System.Drawing.Point(1018, 272);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(27, 13);
            this.Fuel.TabIndex = 14;
            this.Fuel.Text = "Fuel";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missileDisplay);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FuelTank);
            this.Controls.Add(this.lblScore);
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
            this.PnlGame.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Timer missileRegen;
        private System.Windows.Forms.ProgressBar missileDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fuel;
    }
}

