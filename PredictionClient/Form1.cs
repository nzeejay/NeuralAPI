﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PredictionNetwork;

namespace PredictionClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NeuralNetwork nn = new NeuralNetwork();

        private void Form1_Load(object sender, EventArgs e)
        {
            nn.buildNetwork(new Int3[] { new Int3(2,1,1),
                                         new Int3(3,1,1),
                                         new Int3(1,1,1)});
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            var g = pictureBox1.CreateGraphics();

            Color clr = Color.Black;

            List<int> vals = new List<int>();

            g.Clear(Color.White);
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    
                    nn.clearNetwork();

                    nn.layers[0].data[0] = x / 20.0f;
                    nn.layers[0].data[1] = y / 20.0f;

                    nn.runNetwork();

                    clr = Color.FromArgb((int)(nn.layers[2].data[0] * 254), 0, 0, 0);
                    vals.Add((int)(nn.layers[2].data[0] * 255));
                    g.FillRectangle(new SolidBrush(clr), x * 25, y * 25, 25, 25);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                nn.trainStep();
            }
        }
    }
}
