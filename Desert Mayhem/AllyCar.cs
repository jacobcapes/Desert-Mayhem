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
        public Rectangle AllyCarRec;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)


        public int rotationAngle;
        public AllyCar()
        {
            x = 100;
            y = 100;
            width = 30;
            height = 30;
            //AllyCar contains the Car1.png image
            AllyCarImage = Properties.Resources.car1;
            AllyCarRec = new Rectangle(x, y, width, height);
           
        }

        public void DrawAllyCar(Graphics g)
        {
            g.DrawImage(AllyCarImage, AllyCarRec);
        }
        public void Start(int startx, int starty)
        {
            x = startx;
            x = starty;
            rotationAngle = 0;
        }
    }
}
