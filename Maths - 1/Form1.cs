﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maths___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x* Math.PI/180.0));
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = Convert.ToDouble(textBox1.Text);
            double A = Convert.ToDouble(textBox2.Text);
            double Fx = F * cos(A);
            double Fy = F * sin(A);
            label1.Text = cos.ToString();
        }
    }
}
