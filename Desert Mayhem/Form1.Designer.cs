
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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.tmrAllyCar = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DrawEnemy1tmr = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Tan;
            this.PnlGame.Location = new System.Drawing.Point(12, 49);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1000, 500);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PnlGame_PreviewKeyDown);
            // 
            // tmrAllyCar
            // 
            this.tmrAllyCar.Enabled = true;
            this.tmrAllyCar.Interval = 10;
            this.tmrAllyCar.Tick += new System.EventHandler(this.tmrAllyCar_Tick);
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
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.PnlGame);
            this.KeyPreview = true;
            this.Name = "FrmGame";
            this.Text = "Desert Mayhem";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer tmrAllyCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer DrawEnemy1tmr;
        private System.Windows.Forms.Timer tmrEnemy;
    }
}

