﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Filters;

namespace PruebaAforge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (openFileDialog1.ShowDialog()==(System.Windows.Forms.DialogResult.OK))
            {
                pictureBox1.Image = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
                GrayscaleBT709 gray = new GrayscaleBT709();
                pictureBox2.Image = gray.Apply((Bitmap)pictureBox1.Image);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
