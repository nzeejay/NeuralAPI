using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualisationClient
{
    public partial class Main : Form
    {
        public List<float> ErrorHistory = new List<float>();

        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            Random r = new Random();

            ErrorHistory.Add(0.5f);

            for (int i = 0; i < 99; i++) {
                ErrorHistory.Add((float)Math.Min(ErrorHistory[i] - (r.NextDouble() - 0.46f) * 0.1f, 0.5f));
            }
        }

        private void drawError(object sender, EventArgs e) {
            var g = errorDrawing.CreateGraphics();

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen linePen = new Pen(Color.SlateGray);
            linePen.Width = 1f;
            linePen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            linePen.DashPattern = new float[] { 4.0F, 6.0F};

            float xInterval = errorDrawing.Width / (ErrorHistory.Count-1f);

            //g.Clear(Color.White);

            for (int i = 0; i < ErrorHistory.Count-1; i++) {
                float xPos = xInterval * (i + 1);
                g.DrawLine(linePen, xPos, 0, xPos, errorDrawing.Height - 10);

                if (i < ErrorHistory.Count - 1) {
                    float xPos1 = xInterval * (i);
                    float yPos1 = errorDrawing.Height - (int)(ErrorHistory[i] * errorDrawing.Height / 0.5);

                    float xPos2 = xInterval * (i + 1);
                    float yPos2 = errorDrawing.Height - (int)(ErrorHistory[i + 1] * errorDrawing.Height / 0.5);


                    g.DrawLine(new Pen(Color.Red), xPos1, yPos1, xPos2, yPos2);
                }
            }
        }

        private void errorDrawing_Paint(object sender, PaintEventArgs e) {
            drawError(null, null);
        }
    }
}
