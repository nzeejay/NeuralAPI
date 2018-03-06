using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualisationClient {
    public partial class Main : Form {

        private void iniErrorPane() {

            ErrorHistory.Add(0f);

            for (int i = 0; i < 200; i++)
                ErrorHistory.Add((80000f - (float)Math.Pow(i, 2.2)) / 80000f);

            drawError(null, null);
        }


        int yPointWidth = 100;

        bool errorCanDraw = true;
        bool errorDrawCursor = false;

        private void drawError(object sender, EventArgs e) {
            if (errorCanDraw) {
                errorCanDraw = false;

                if (ErrorGraph.Image != null)
                    ErrorGraph.Image.Dispose();

                var bmp = new Bitmap(ErrorGraph.Width, ErrorGraph.Height);
                var g = Graphics.FromImage(bmp);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen linePen = new Pen(Color.SlateGray);
                linePen.Width = 1f;
                linePen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
                linePen.DashPattern = new float[] { 4.0F, 6.0F };

                float xInterval = ErrorGraph.Width / (yPointWidth - 1f);

                //g.Clear(Color.White);

                int ErrorHistoryIndex = Math.Max(0, ErrorHistory.Count - yPointWidth - 1);

                int[] mouseMatchingPoints = new int[0];

                for (int i = 0; i < yPointWidth - 1; i++) {
                    if (ErrorHistoryIndex + i < ErrorHistory.Count - 1) {
                        float xPos = xInterval * (i + 1);

                        float bottom = ErrorGraph.Height - 14;

                        g.DrawLine(linePen, xPos, 0, xPos, bottom);

                        float xPos1 = xInterval * (i);
                        float yPos1 = bottom - (ErrorHistory[ErrorHistoryIndex + i] * bottom);

                        float xPos2 = xInterval * (i + 1);
                        float yPos2 = bottom - (ErrorHistory[ErrorHistoryIndex + i + 1] * bottom);


                        g.DrawLine(new Pen(Color.Red, 1), xPos1, yPos1, xPos2, yPos2);

                        if (errorDrawCursor)
                            if (ErrorGraph.PointToClient(MousePosition).X > xPos1 - (xInterval / 2) &&
                               ErrorGraph.PointToClient(MousePosition).X < xPos1 + (xInterval / 2))
                                mouseMatchingPoints = new int[] { (int)xPos1, (int)yPos1, ErrorHistoryIndex + i + 1 };

                    }
                }

                if(mouseMatchingPoints.Length > 0) {
                    int x = mouseMatchingPoints[0];
                    int y = mouseMatchingPoints[1];

                    int pos = mouseMatchingPoints[2];

                    g.DrawEllipse(new Pen(Color.Black, 2f), x - 1.5f, y - 1.5f, 3, 3);

                    drawMouse(g, new Point(x, y), pos);
                }

                ErrorGraph.Image = bmp;

                //don't let it draw again soon
                Task.Run(action: async () => {
                    await Task.Delay(12);
                    errorCanDraw = true;
                });
            }
        }

        protected void errorDrawing_Paint(object sender, PaintEventArgs e) {
            drawError(null, null);
        }

        private void ErrorMouseInteractions(object sender, MouseEventArgs e) {
            errorDrawCursor = true;

            drawError(null, null);
        }

        private void drawMouse(Graphics g, Point pos, int currentItem) {
            Point start = pos;
            start.X += 4;
            start.Y -= 20;

            Size size = new Size(72, 16);

            Rectangle r = new Rectangle(start, size);

            g.DrawRectangle(new Pen(Color.Black), r);
            g.FillRectangle(new Pen(BackColor).Brush, new Rectangle(start, size));

            g.DrawString("" + ErrorHistory[currentItem-1], new Font("System Bold", 11), new Pen(Color.Black).Brush, start);
        }

        private void ErrorGraph_MouseLeave(object sender, EventArgs e) {
            errorDrawCursor = false;
            drawError(null, null);
        }

        private void trckErrorScale_ValueChanged(object sender, EventArgs e) {
            yPointWidth = trckErrorScale.Value * 50;

            lblErrorScale.Text = $"Scale: {yPointWidth}";

            drawError(null, null);
        }
    }
}
