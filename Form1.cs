﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рисуем_сетку
{
    public partial class Form1 : Form
    {
        int dx, dy, x, y, nx, ny, dlw, dlh;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            x0 = 10;
            y0 = 10;
            nx = 10;
            ny = 10;

            dx = (fw - x0 - 20) / nx;
            dy = (fh - y0 - 40) / ny;

            dlh = dy * ny;
            dlw = dx * nx;


            for (int i = 0; i <= nx; i++)
            {
                x = x0 + i * dx;
                gr.DrawLine(pen1, x, y0, x, dlh + x0);
            }

            for (int i = 0; i <= ny; i++)
            {
                y = y0 + i * dy;
                gr.DrawLine(pen1, x0, y, dlw + y0, y);
            }

        }

        int x0, y0;
        int fw, fh;  // Ширина и высота формы

        Pen pen1 = new Pen(Color.Black);
        Graphics gr;
        public Form1()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
            this.BackColor = Color.White;
            fw = this.Width;//Текущая ширина формы
            fh = this.Height;//Текущая высота формы   
        }
    }
}
