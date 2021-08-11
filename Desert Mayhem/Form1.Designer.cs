
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
            this.lblPause = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.menuStart2 = new System.Windows.Forms.Button();
            this.menuHelp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Tan;
            this.PnlGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlGame.BackgroundImage")));
            this.PnlGame.Controls.Add(this.lblPause);
            this.PnlGame.Controls.Add(this.pictureBox2);
            this.PnlGame.Controls.Add(this.pictureBox1);
            this.PnlGame.Controls.Add(this.GameOver);
            this.PnlGame.Location = new System.Drawing.Point(12, 49);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1000, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PnlGame_PreviewKeyDown);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("MS Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.Location = new System.Drawing.Point(391, 220);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(163, 36);
            this.lblPause.TabIndex = 20;
            this.lblPause.Text = "Game paused press play to resume";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(447, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 48);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Desert_Mayhem.Properties.Resources.pause;
            this.pictureBox1.Location = new System.Drawing.Point(948, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
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
            this.GameOver.Size = new System.Drawing.Size(106, 56);
            this.GameOver.TabIndex = 0;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(1018, 418);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "0";
            this.lblSpeed.Click += new System.EventHandler(this.lblSpeed_Click);
            // 
            // tmrAllyCar
            // 
            this.tmrAllyCar.Interval = 2;
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
            this.tmrEnemy.Interval = 1;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1101, 135);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 15);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // FuelTank
            // 
            this.FuelTank.BackColor = System.Drawing.Color.Goldenrod;
            this.FuelTank.ForeColor = System.Drawing.Color.BurlyWood;
            this.FuelTank.Location = new System.Drawing.Point(1021, 331);
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
            this.label2.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1018, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1018, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(1072, 64);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 19);
            this.TxtName.TabIndex = 8;
            this.TxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtName_MouseClick);
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Location = new System.Drawing.Point(1021, 468);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(146, 23);
            this.BtnCheck.TabIndex = 10;
            this.BtnCheck.Text = "Check for High Score";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.missileDisplay.Location = new System.Drawing.Point(1021, 256);
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
            this.label1.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1018, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Missile Reload";
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fuel.Location = new System.Drawing.Point(1018, 313);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(43, 15);
            this.Fuel.TabIndex = 14;
            this.Fuel.Text = "Fuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1018, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Level";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(1101, 169);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(16, 15);
            this.lblLevel.TabIndex = 16;
            this.lblLevel.Text = "0";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStart2
            // 
            this.menuStart2.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStart2.Location = new System.Drawing.Point(1018, 99);
            this.menuStart2.Name = "menuStart2";
            this.menuStart2.Size = new System.Drawing.Size(151, 23);
            this.menuStart2.TabIndex = 17;
            this.menuStart2.Text = "Start";
            this.menuStart2.UseVisualStyleBackColor = true;
            this.menuStart2.Click += new System.EventHandler(this.menuStart2_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Location = new System.Drawing.Point(1021, 497);
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(146, 23);
            this.menuHelp.TabIndex = 18;
            this.menuHelp.Text = "Help";
            this.menuHelp.UseVisualStyleBackColor = true;
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(557, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Desert Mayhem";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Transparent;
            this.lblLives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLives.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(1101, 207);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(16, 15);
            this.lblLives.TabIndex = 20;
            this.lblLives.Text = "2";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1018, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lives";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuHelp);
            this.Controls.Add(this.menuStart2);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label4);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button menuStart2;
        private System.Windows.Forms.Button menuHelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPause;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label6;
    }
}

