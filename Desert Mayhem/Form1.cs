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
        AllyCar AllyCar = new AllyCar(); //create the object, BluePlane
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
