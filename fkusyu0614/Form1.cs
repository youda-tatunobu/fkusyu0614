﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fkusyu0614
{
    public partial class Form1 : Form
    {

        int vx = -10;
        int vy = -10;

        Point zpos;
        public Form1()
        {
            

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            zpos = PointToClient(MousePosition);

            label1.Left=zpos.X;
            label1.Top = zpos.Y;



            if(label1.Left<0)
            {
                vx = -vx;
            }

            if (label1.Left>255)
            {
                vx = -vx;
            }

            if (label1.Top < 0)
            {
                vy = -vy;
            }

            if (label1.Top > 255)
            {
                vy = -vy;
            }


        }
    }
}
