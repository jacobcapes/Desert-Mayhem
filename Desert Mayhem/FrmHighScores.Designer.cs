﻿
namespace Desert_Mayhem
{
    partial class FrmHighScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.BoxName1 = new System.Windows.Forms.ListBox();
            this.BoxScore1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player\'s Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(217, 263);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player\'s Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(217, 331);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerScore.TabIndex = 5;
            this.lblPlayerScore.Text = "Score";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(66, 391);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "label7";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(375, 321);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return to Game Form";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // BoxName1
            // 
            this.BoxName1.FormattingEnabled = true;
            this.BoxName1.Location = new System.Drawing.Point(30, 56);
            this.BoxName1.Name = "BoxName1";
            this.BoxName1.Size = new System.Drawing.Size(120, 199);
            this.BoxName1.TabIndex = 8;
            // 
            // BoxScore1
            // 
            this.BoxScore1.FormattingEnabled = true;
            this.BoxScore1.Location = new System.Drawing.Point(187, 56);
            this.BoxScore1.Name = "BoxScore1";
            this.BoxScore1.Size = new System.Drawing.Size(120, 199);
            this.BoxScore1.TabIndex = 9;
            // 
            // FrmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxScore1);
            this.Controls.Add(this.BoxName1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHighScores";
            this.Text = "High Scores";
            this.Load += new System.EventHandler(this.FrmHighScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox BoxName1;
        private System.Windows.Forms.ListBox BoxScore1;
    }
}