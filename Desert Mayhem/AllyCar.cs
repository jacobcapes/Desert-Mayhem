using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Desert_Mayhem
{
    class AllyCar
    {
        public int x, y, width, height;//variables for the rectangle
        public Image AllyCarImage;//variable for the cars image
        public Image explosionImage;//variable for the cars image
        public Rectangle AllyCarRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)
        public decimal xSpeed, ySpeed;
        public int rotationAngle;
        public decimal speed;
        public Matrix matrix;
        Point centre;

        public AllyCar()
        {
            x = 100;
            y = 100;
            width = 40;
            height = 50;
            speed = 0;
            rotationAngle = 360;
            //AllyCar contains the Car1.png image
            explosionImage = Properties.Resources.explosion;
            AllyCarImage = Properties.Resources.car1;
            AllyCarRec = new Rectangle(x, y, width, height);
           
        }

        public void DrawAllyCar(Graphics g)
        {
            //find the centre point of AllyCarRec
            centre = new Point(AllyCarRec.X + width / 2, AllyCarRec.Y + height / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (AlllyCarRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the car
            g.DrawImage(AllyCarImage, AllyCarRec);
           
        }
        public void DrawExplosion(Graphics g)
        {
            //find the centre point of AllyCarRec
            centre = new Point(AllyCarRec.X + width / 2, AllyCarRec.Y + height / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (AlllyCarRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the car
            g.DrawImage(explosionImage, AllyCarRec);

        }
        public void MoveAllyCar()
        {
            //move the car with the speeds ot x and y
            x += (int)xSpeed;
            y -= (int)ySpeed;
            AllyCarRec.Location = new Point(x, y);//allycars new location

        }
        public void Start(int startx, int starty)
        {
            xSpeed = 0;
            ySpeed = 0;
            x = startx;
            x = starty;
            rotationAngle = 0;
        }
        public void Rotatecar(int AllyCarRotate, int Speed)
        {
            //find the rotation angle of the blueplane
            xSpeed = (decimal)(Speed * (Math.Cos((AllyCarRotate - 90) * Math.PI / 180)));
            ySpeed = (decimal)(Speed * (Math.Sin((AllyCarRotate + 90) * Math.PI / 180)));
        }
    }
}
