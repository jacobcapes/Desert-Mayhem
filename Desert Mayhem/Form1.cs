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
        int startx, starty;
        decimal m1 = 0.09M; // Better
        decimal m2 = 0.05M; // Better


        private void tmrAllyCar_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                AllyCar.rotationAngle += 4;
            }
            if (turnLeft)
            {
                AllyCar.rotationAngle -= 4;
            }
            if (up) // if left arrow key pressed
            {

                if (AllyCar.speed < 10)
                {
                    AllyCar.speed += m1;
                }

            }
            if (up != true) // if left arrow key pressed
            {
                if (AllyCar.speed > 0)
                {
                    AllyCar.speed -= m2;
                }
                
               
            }
            if (down) // if left arrow key pressed
            {

                if (AllyCar.speed > -3)
                {
                    AllyCar.speed -= m1;
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
            if (shoot)
            {
                //if you have missiles available shoot.
                missiles.Add(new Missile(AllyCar.AllyCarRec, AllyCar.rotationAngle));
             
                shoot = false;

            }
            //update the rotation angle and movment of blueplane
            AllyCar.Rotatecar(AllyCar.rotationAngle,  (int)AllyCar.speed);
            AllyCar.MoveAllyCar();
            PnlGame.Invalidate();
        }

        private void DrawEnemy1tmr_Tick(object sender, EventArgs e)
        {
            Enemy1.Add(new Enemy1());
            //draw new enemy with new speed
            Espeed = 4;
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
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            AllyCar.DrawAllyCar(g);


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
