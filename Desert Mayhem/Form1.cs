﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;


namespace Desert_Mayhem
{
    public partial class FrmGame : Form
    {
        Graphics g; //declare a graphics object called g
        AllyCar AllyCar = new AllyCar(); //create the object, AllyCar
        List<Enemy1> Enemy1 = new List<Enemy1>(); //create the object, BluePlane
        List<Missile> missiles = new List<Missile>();
        bool turnLeft, turnRight, up, down, shoot;
        int Espeed;
        int AllyCarPosX, AllyCarPosY, Enemy1PosX, Enemy1PosY;
        int Score = 0;
        int Level = 0;
        Random rand = new Random();
        bool death;
        Rectangle FuelRec = new Rectangle(15, 20, 20, 20);
        Image FuelImage = Properties.Resources.fueltank;
        string playerName;
        int startx, starty;
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Fueltmr_Tick(object sender, EventArgs e)
        {

            //Parameters for the fuel bar (so that the bar does not exceed the max or min values)
            if (FuelTank.Value > FuelTank.Maximum - 1)
            {
                FuelTank.Value = FuelTank.Maximum;
            }

            if (FuelTank.Value < FuelTank.Minimum + 1)
            {
                FuelTank.Value = FuelTank.Minimum;
            }

            //Lowering fuel bar
            if (up)
            {
                if (FuelTank.Value != FuelTank.Minimum + 1 && FuelTank.Value != FuelTank.Minimum - 1)
                {
                    FuelTank.Value -= 1;
                }

            }
            if (turnRight)
            {
                if (AllyCar.speed < 2)
                    {
                    if (FuelTank.Value != FuelTank.Minimum + 1 && FuelTank.Value != FuelTank.Minimum - 1)
                    {
                        FuelTank.Value -= 1;
                    }
                }

            }
            if (turnLeft)
            {
                if (AllyCar.speed < 2)
                {
                    if (FuelTank.Value != FuelTank.Minimum + 1 && FuelTank.Value != FuelTank.Minimum - 1)
                    {
                        FuelTank.Value -= 1;
                    }
                }

            }
            //increasing fuel bar
        }

        private void tmrFuel_Tick(object sender, EventArgs e)
        {
           //change ammo location to random and stop the timer
           FuelRec.X = rand.Next(50, 950);
           FuelRec.Y = rand.Next(50, 450);
           tmrFuel.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Turn your vehicle side to side with the arrow keys. \n Press space to shoot at the enemy cars. \n collect fuel to make sure your tank can continue to move. \n Type your name in and press the start to begin. \n Warning you will explode if you are struck by an enemy \n \n press 'ok' to begin \n\n\n Images accredited to \n Blue tank - Seek PNG\n Red Enemy Car - Seek PNG\n Missile - Martin Burch", "Game Instructions");
            TxtName.Focus();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                pictureBox2.Visible = false;
                lblPause.Visible = false;
                pictureBox1.Visible = true;
                death = false;
                //if playerName valid (only letters) 
                GameOver.Visible = false;
                //stop all timers and show death
                tmrEnemy.Enabled = true;
                tmrFuel.Enabled = true;
                Fueltmr.Enabled = true;
                tmrAllyCar.Enabled = true;
                DrawEnemy1tmr.Enabled = true;
                Score = 0;
                Enemy1.Clear();
                TxtName.Enabled = false;
                BtnCheck.Enabled = false;
                BtnQuit.Enabled = false;
                FuelTank.Value = 100;
                menuStart.Enabled = false;
                menuStart2.Enabled = false;
                menuHelp.Enabled = false;
                missileRegen.Enabled = true;
                AllyCar.xSpeed = 0;
                AllyCar.ySpeed = 0;
                AllyCar.x = startx;
                AllyCar.y = starty;
                AllyCar.rotationAngle = 145;
            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                TxtName.Clear();
                TxtName.Focus();
            }

        }

        private void menuPause_Click(object sender, EventArgs e)
        {
            lblPause.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            //stop all timers and show death
            tmrEnemy.Enabled = false;
            tmrFuel.Enabled = false;
            Fueltmr.Enabled = false;
            tmrAllyCar.Enabled = false;
            DrawEnemy1tmr.Enabled = false;
            menuStart.Enabled = true;
            menuStart2.Enabled = true;
            menuHelp.Enabled = true;
            missileRegen.Enabled = false;
        }
            private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblPause.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            //stop all timers and show death
            tmrEnemy.Enabled = false;
            tmrFuel.Enabled = false;
            Fueltmr.Enabled = false;
            tmrAllyCar.Enabled = false;
            DrawEnemy1tmr.Enabled = false;
            menuStart.Enabled = true;
            menuStart2.Enabled = true;
            menuHelp.Enabled = true;
            missileRegen.Enabled = false;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmHighScores FrmHighScore2 = new FrmHighScores(TxtName.Text, lblScore.Text);
            Hide();
            FrmHighScore2.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_MouseClick(object sender, MouseEventArgs e)
        {
            TxtName.Enabled = true;
        }

        private void missileRegen_Tick(object sender, EventArgs e)
        {

            if  (missileDisplay.Value < 99)
            {
                missileDisplay.Value += 3;
            }
         
        }

        private void missileDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void menuStart2_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
                pictureBox2.Visible = false;
                lblPause.Visible = false;
                pictureBox1.Visible = true;
                death = false;
                //if playerName valid (only letters) 
                GameOver.Visible = false;
                //stop all timers and show death
                tmrEnemy.Enabled = true;
                tmrFuel.Enabled = true;
                Fueltmr.Enabled = true;
                tmrAllyCar.Enabled = true;
                DrawEnemy1tmr.Enabled = true;
                Score = 0;
                Enemy1.Clear();
                TxtName.Enabled = false;
                BtnCheck.Enabled = false;
                BtnQuit.Enabled = false;
                FuelTank.Value = 100;
                menuStart.Enabled = false;
                menuStart2.Enabled = false;
                missileRegen.Enabled = true;
                menuHelp.Enabled = false;
                AllyCar.xSpeed = 0;
                AllyCar.ySpeed = 0;
                AllyCar.x = startx;
                AllyCar.y = starty;
                AllyCar.rotationAngle = 145;
            

            }
            else
            {
                //invalid playerName, clear txtName and focus on it to try again
                MessageBox.Show("please enter a name using letters only!");
                TxtName.Clear();
                TxtName.Focus();
            }

        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turn your vehicle side to side with the arrow keys. \n Press space to shoot at the enemy cars. \n collect fuel to make sure your tank can continue to move. \n Type your name in and press the start to begin. \n Warning you will explode if you are struck by an enemy \n \n press 'ok' to begin\n\n\n Images accredited to \n Blue tank - Seek PNG\n Red Enemy Car - Seek PNG\n Missile - Martin Burch", "Game Instructions");
        }

        private void velocityBar_Click(object sender, EventArgs e)
        {

        }

        private void lblSpeed_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            lblPause.Visible = false;
            pictureBox1.Visible = true;
            tmrEnemy.Enabled = true;
            Fueltmr.Enabled = true;
            tmrAllyCar.Enabled = true;
            DrawEnemy1tmr.Enabled = true;
            menuStart.Enabled = false;
            menuStart2.Enabled = false;
            menuHelp.Enabled = false;
            missileRegen.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tmrAllyCar_Tick(object sender, EventArgs e)
        {
            //if fueltank is less than 5 car slows down and has new speed variables
            if (FuelTank.Value < 5)
            {
                if (AllyCar.speed < 0.99m)
                {

                    AllyCar.speed += 0.03m;
                }
                if (AllyCar.speed > 3)
                {
                    AllyCar.speed -= 0.2m;
                }
                if (up) // if up arrow key pressed
                {
                    if (AllyCar.speed < 2.5m)
                    {
                        if (AllyCar.speed < 0.99m)
                        {
                            AllyCar.speed += 0.2m;
                        }
                        if (AllyCar.speed > 0.99m)
                        {

                            AllyCar.speed += 0.03m;
                        }
                        AllyCar.speed += 0.03m;
                    }



                }
                if (up != true) // if up arrow key not pressed
                {
                    if (AllyCar.speed > 0.99m)
                    {

                        AllyCar.speed -= 0.09m;
                    }


                }
                if (turnRight) // if right arrow key pressed
                {
                    AllyCar.rotationAngle += 2;
                }
                if (turnLeft) // if left arrow key pressed
                {
                    AllyCar.rotationAngle -= 2;
                }

            }
            //if car has more than 5 fuel car has fastest speed values
            if (FuelTank.Value > 5)
            {
                // if right arrow key pressed
                if (turnRight)
                {
                    AllyCar.rotationAngle += 2;
                }
                // if left arrow key pressed
                if (turnLeft)
                {
                    AllyCar.rotationAngle -= 2;
                }
                if (up) // if up arrow key pressed
                {
                    if (AllyCar.speed < 5)
                    {
                        if (AllyCar.speed < 0.99m)
                        {
                            AllyCar.speed += 0.2m;
                        }
                        if (AllyCar.speed > 0.99m)
                        {

                            AllyCar.speed += 0.03m;
                        }
                        AllyCar.speed += 0.03m;
                    }
                }
                if (up != true) // if up arrow key not pressed
                {
                    if (AllyCar.speed > 0.99m)
                    {

                        AllyCar.speed -= 0.09m;
                    }
                }

                if (down) // if down arrow key pressed
                {
                    if (AllyCar.speed < 2.5m)
                    {
                        if (AllyCar.speed > -3)
                        {
                            AllyCar.speed -= 0.2m;
                        }
                    } 
                }
                if (down != true) // if dowh arrow key not pressed
                {
                    if (AllyCar.speed < -1.99m)
                    {
                        AllyCar.speed += 0.09m;
                    }
                }
            }
             //Parameters for the sides and top of panel
            if (AllyCar.x < 10)
            {
                AllyCar.x = 10;
            }

            if (AllyCar.x > 950)
            {
                AllyCar.x = 950;
            }
            if (AllyCar.y < 5)
            {
                AllyCar.y = 5;
            }
            if (AllyCar.y > 445)
            {
                AllyCar.y = 445;
            }

            //if you have missiles reloaded and reload bar is full allow the car to shoot
            if (missileDisplay.Value == 99)
                {
                    if (shoot)
                    {
                    shoot = true;  
                        missiles.Add(new Missile(AllyCar.AllyCarRec, AllyCar.rotationAngle));
                        missileDisplay.Value = 0;


                    }
                }
            //increasing speed of enemy spawndifficulty
            if (Score == 2)
            {
                Level = 1;
                DrawEnemy1tmr.Interval = 9000;
            }
            if (Score == 4)
            {
                Level = 2;
                DrawEnemy1tmr.Interval = 8000;
            }
            if (Score == 6)
            {
                Level = 3;
                DrawEnemy1tmr.Interval = 7500;
            }
            if (Score == 8)
            {
                Level = 4;
                DrawEnemy1tmr.Interval = 7000;
            }
            if (Score == 10)
            {
                Level = 5;
                DrawEnemy1tmr.Interval = 6000;
            }
            if (Score == 12)
            {
                Level = 6;
                DrawEnemy1tmr.Interval = 5500;
            }
            if (Score == 14)
            {
                Level = 7;
                DrawEnemy1tmr.Interval = 5000;
            }
            if (Score == 16)
            {
                Level = 8;
                DrawEnemy1tmr.Interval = 4500;
            }
            if (Score == 18)
            {
                Level = 9;
                DrawEnemy1tmr.Interval = 4000;
            }
            if (Score == 20)
            {
                Level = 10;
                DrawEnemy1tmr.Interval = 3500;
            }
            lblLevel.Text = Level.ToString();

            //if enemy hits into player end game
            foreach (Enemy1 Enemy in Enemy1)
            {

                if (AllyCar.AllyCarRec.IntersectsWith(Enemy.Enemy1Rec))
                {
                    Image AllyCarImage = Properties.Resources.explosion;
                    Enemy1.Remove(Enemy);
                    death = true;
                    break;
        
                }
          
            }
            // stop all timers and show death
            if (death == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                lblPause.Visible = false;
                Image AllyCarImage = Properties.Resources.explosion;
                Enemy1.Clear();
                GameOver.Visible = true;
                tmrEnemy.Enabled = false;
                tmrFuel.Enabled = false;
                Fueltmr.Enabled = false;
                tmrAllyCar.Enabled = false;
                DrawEnemy1tmr.Enabled = false;
                TxtName.Enabled = true;
                BtnCheck.Enabled = true;
                BtnQuit.Enabled = true;
                menuStart.Enabled = true;
                menuStart2.Enabled = true;
                menuHelp.Enabled = true;
                missileRegen.Enabled = false;


            }
            //update the rotation angle and movment of AllyCar
            AllyCar.Rotatecar(AllyCar.rotationAngle, (int)AllyCar.speed);
            AllyCar.MoveAllyCar();
            PnlGame.Invalidate();
            if (AllyCar.AllyCarRec.IntersectsWith(FuelRec))
            {
                //give more fuel when touching fuel box
                tmrFuel.Enabled = true;
                FuelTank.Value = 100;
            }
        }

        private void DrawEnemy1tmr_Tick(object sender, EventArgs e)
        {
            Enemy1.Add(new Enemy1());
            //draw new enemy with new speed
            Espeed = 2;
        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {

            //update enemy movement
            foreach (Enemy1 Enemy1 in Enemy1)
            {
                Enemy1.MoveEnemy1();
                Enemy1.RotateEnemy1(Espeed);
            }
            AllyCarPosX = AllyCar.AllyCarRec.Location.X;
            AllyCarPosY = AllyCar.AllyCarRec.Location.Y;
            foreach (Enemy1 Enemy1 in Enemy1)
            {
                //cacluate the roatation angle
                Enemy1PosX = Enemy1.Enemy1Rec.Location.X;
                Enemy1PosY = Enemy1.Enemy1Rec.Location.Y;
                Enemy1.rotationAngle = (int)Enemy1.CalculateAngle(Enemy1PosX, Enemy1PosY, AllyCarPosX, AllyCarPosY);
            }

            foreach (Enemy1 Enemy in Enemy1)
            {

                foreach (Missile m in missiles)
                {
                    if (Enemy.Enemy1Rec.IntersectsWith(m.missileRec))
                    {
                        Score += 1;
                        //if a missile hits a enemy
                        missiles.Remove(m);// remove missile
                        Enemy1.Remove(Enemy);
                        break;
                    }


                }
                break;

            }
            lblScore.Text = Score.ToString();
        }

        private void PnlGame_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
            if (e.KeyData == Keys.Space)
            {
                shoot = true;
            }
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
            if (e.KeyData == Keys.Space) { shoot = false; }

        }

        public FrmGame()
        {
            //sets up game before start
            InitializeComponent();
            //stops the panel and everything on it from buffering constantly
            FuelTank.Value = 100;
            missileDisplay.Value = 0;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //draws and redraws images depending on message being sent
            g = e.Graphics;
            
            g.DrawImage(FuelImage, FuelRec);
            if (death == false)
            {
                AllyCar.DrawAllyCar(g);
            }

            if (death == true)
            {
                AllyCar.DrawExplosion(g);
            }

                      foreach (Enemy1 Enemy in Enemy1)

            {    
          Enemy.DrawEnemy1(g);
            }
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile();
            }
        }
    }
}

