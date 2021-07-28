using System;
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
        decimal m1 = 0.09M; // Better
        decimal m2 = 0.05M; // Better
        int Score = 0;
        Random rand = new Random();
        bool death;

        Rectangle FuelRec = new Rectangle(0, 0, 20, 20);
        Image FuelImage = Properties.Resources.fueltank;

        string playerName;

        int startx, starty;
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Fueltmr_Tick(object sender, EventArgs e)
        {

            //Parameters for the stamina bar (so that the bar does not exceed the max or min values
            if (FuelTank.Value > FuelTank.Maximum - 1)
            {
                FuelTank.Value = FuelTank.Maximum;
            }

            if (FuelTank.Value < FuelTank.Minimum + 1)
            {
                FuelTank.Value = FuelTank.Minimum;
            }

            //Lowering stamina bar
            if (up)
            {
                if (FuelTank.Value != FuelTank.Minimum + 1 && FuelTank.Value != FuelTank.Minimum - 1)
                {
                    FuelTank.Value -= 1;
                }

            }
            //increasing stamina bar

          

            //Base stamina regen

            if (FuelTank.Value < FuelTank.Minimum + 3)
            {
                up = false;
            }



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
            MessageBox.Show("Turn your vehicle side to side with the arrow keys. \n Press space to shoot at the enemy cars. \n collect fuel to make sure your tank can continue to move. \n Type your name in and press the start to begin. \n Warning you will explode if you are struck by an enemy \n \n press 'ok' to begin", "Game Instructions");
            TxtName.Focus();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerName = TxtName.Text;


            if (Regex.IsMatch(playerName, @"^[a-zA-Z]+$"))//checks playerName for letters
            {
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
            pictureBox1.Visible = true;
            //stop all timers and show death
            tmrEnemy.Enabled = false;
            tmrFuel.Enabled = false;
            Fueltmr.Enabled = false;
            tmrAllyCar.Enabled = false;
            DrawEnemy1tmr.Enabled = false;
            menuStart.Enabled = true;
        }

        private void GameOver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            tmrEnemy.Enabled = true;
            Fueltmr.Enabled = true;
            tmrAllyCar.Enabled = true;
            DrawEnemy1tmr.Enabled = true;
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

        private void tmrAllyCar_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                AllyCar.rotationAngle += 2;
            }
            if (turnLeft)
            {
                AllyCar.rotationAngle -= 2;
            }
            if (up) // if left arrow key pressed
            {

                if (AllyCar.speed < 5)
                {
                    AllyCar.speed += 0.05M;
                }

            }
            if (up != true) // if left arrow key pressed
            {
                if (AllyCar.speed > 1.99M)
                {
                    AllyCar.speed -= 0.05M;
                }


            }
            if (down) // if left arrow key pressed
            {

                if (AllyCar.speed > -3)
                {
                    AllyCar.speed -= 0.09M;
                }
            }
            //Parameters for the sides and top of panel
            if (AllyCar.x < 0)
            {
                AllyCar.x = 0;
            }

            if (AllyCar.x > 965)
            {
                AllyCar.x = 965;
            }
            if (AllyCar.y < 0)
            {
                AllyCar.y = 0;
            }
            if (AllyCar.y > 465)
            {
                AllyCar.y = 465;
            }


                if (missileDisplay.Value == 99)
                {
                    if (shoot)
                    {
                    shoot = true;  
                        //if you have missiles available shoot.
                        missiles.Add(new Missile(AllyCar.AllyCarRec, AllyCar.rotationAngle));
                        missileDisplay.Value = 0;


                    }
                }

            
            
     
            foreach (Enemy1 Enemy in Enemy1)
            {
                if (AllyCar.AllyCarRec.IntersectsWith(Enemy.Enemy1Rec))
                {
                    
                    death = true;
                    Enemy1.Remove(Enemy);
                    break;
                   

                }
            }
            if (death == true)
            {

                Image AllyCarImage = Properties.Resources.explosion;
                Enemy1.Clear();
                GameOver.Visible = true;
                //stop all timers and show death
                tmrEnemy.Enabled = false;
                tmrFuel.Enabled = false;
                Fueltmr.Enabled = false;
                tmrAllyCar.Enabled = false;
                DrawEnemy1tmr.Enabled = false;
                TxtName.Enabled = true;
                BtnCheck.Enabled = true;
                BtnQuit.Enabled = true;


            }
            //update the rotation angle and movment of blueplane
            AllyCar.Rotatecar(AllyCar.rotationAngle, (int)AllyCar.speed);
            lblSpeed.Text = AllyCar.speed.ToString();
            AllyCar.MoveAllyCar();
            PnlGame.Invalidate();
            if (AllyCar.AllyCarRec.IntersectsWith(FuelRec))
            {
                //give more ammo when touching ammo box
                tmrFuel.Enabled = true;
                FuelTank.Value = 100;
            }
        }

        private void DrawEnemy1tmr_Tick(object sender, EventArgs e)
        {
            Enemy1.Add(new Enemy1());
            //draw new enemy with new speed
            Espeed = 2;
            // Enemy1.Add(new Enemy1());
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
            InitializeComponent();
            //stops the panel and everything on it from buffering constantly
            FuelTank.Value = 100;
            missileDisplay.Value = 0;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
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

