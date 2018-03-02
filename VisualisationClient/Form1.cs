using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//using NeuralAPI;
//
//namespace VisualisationClient
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }
//
//        NeuralNetwork nn = new NeuralNetwork();
//
//        private void Form1_Load(object sender, EventArgs e)
//        {
//
//            nn.buildNetwork(new dynamic[] {new {size = new Int3(2,1,1), type = 0 },
//                                           new {size = new Int3(4,1,1), type = 0 },
//                                           new {size = new Int3(1,1,1), type = 0 }});
//
//
//            nn.trainingItems.Add(new TrainingItem(new float[] { 0, 0 }, new float[] { 0 }));
//            nn.trainingItems.Add(new TrainingItem(new float[] { 1, 0 }, new float[] { 1 }));
//            nn.trainingItems.Add(new TrainingItem(new float[] { 0, 1 }, new float[] { 1 }));
//            nn.trainingItems.Add(new TrainingItem(new float[] { 1, 1 }, new float[] { 0 }));
//            //nn.trainingItems.Add(new TrainingItem(new float[] { 1, 0.5f }, new float[] { 1 }));
//            //nn.trainingItems.Add(new TrainingItem(new float[] { 0, 0.5f }, new float[] { 1 }));
//            //nn.trainingItems.Add(new TrainingItem(new float[] { 0.25f, 0.5f }, new float[] { 0.5f }));
//            //nn.trainingItems.Add(new TrainingItem(new float[] { 0.75f, 0.5f }, new float[] { 0.5f }));
//
//        }
//
//        private void draw(object sender, EventArgs e)
//        {
//            for (int i = 0; i < 100; i++)
//            {
//                nn.trainStep(-1, 0.1f, 0.9f);
//            }
//
//            Text = "" + nn.printError(-1);
//
//            var g = pictureBox1.CreateGraphics();
//
//            Color clr;
//
//            int w = 30;
//
//            int[][] clrArr = new int[w][];
//
//            for (int x = 0; x < w; x++)
//            {
//                clrArr[x] = new int[w];
//                for (int y = 0; y < w; y++)
//                {
//
//                    nn.clearNetwork();
//
//                    nn.layers[0].data[0] = (x) / (w - 1f);
//                    nn.layers[0].data[1] = (y) / (w - 1f);
//
//                    nn.runNetwork();
//
//                    clrArr[x][y] = (int)(nn.layers[nn.layers.Length - 1].data[0] * 255);
//
//                }
//            }
//            g.Clear(Color.White);
//            for (int x = 0; x < w; x++)
//                for (int y = 0; y < w; y++)
//                {
//                    clr = Color.FromArgb(Math.Max(0,Math.Min(clrArr[x][y],255)), 0, 0, 0);
//                    g.FillRectangle(new SolidBrush(clr), y * 25, x * 25, 25, 25);
//                }
//
//            nn.clearNetwork();
//
//            //Thread.Sleep(60);
//
//            draw(null, null);
//        }
//    }
//}