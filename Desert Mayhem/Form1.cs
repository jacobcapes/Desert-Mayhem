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
        bool turnLeft, turnRight, up, down;
        int Espeed;
        int AllyCarPosX, AllyCarPosY;
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
           
            //update the rotation angle and movment of blueplane
            AllyCar.Rotatecar(AllyCar.rotationAngle,  (int)AllyCar.speed);
            AllyCar.MoveAllyCar();
            PnlGame.Invalidate();
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
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        public FrmGame()
        {
            InitializeComponent();
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            AllyCar.DrawAllyCar(g);
        }
    }
}
