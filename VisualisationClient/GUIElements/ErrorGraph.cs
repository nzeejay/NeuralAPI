using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualisationClient.GUIElements {
    public partial class ErrorGraph : UserControl {
        List<float> ErrorHistory = new List<float>();

        int yPointWidth = 100;
        int yStartPos = 0;

        bool errorCanDraw = true;
        bool errorDrawCursor = false;

        public ErrorGraph() {
            DoubleBuffered = true;

            setupListeners();

            drawError(null, null);
        }

        public void linkErrorList(ref List<float> ErrorHistory) {
            this.ErrorHistory = ErrorHistory;

            for (float i = -1; i < 7; i += 0.01f)
                ErrorHistory.Add((float)(Math.Sin(i) + 1) / 2);
            //ErrorHistory.Add(1 / (1 + (float)Math.Exp(-i)));

            drawError(null, null);
        }

        private void setupListeners() {
            MouseLeave += new EventHandler(ErrorGraph_MouseLeave);
            MouseMove += new MouseEventHandler(ErrorMouseInteractions);
            Resize += new EventHandler(drawError);
        }

        public void drawError(object sender, EventArgs e) {
            if (errorCanDraw) {
                errorCanDraw = false;

                var bmp = new Bitmap(Width, Height);
                var g = Graphics.FromImage(bmp);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen linePen = new Pen(Color.SlateGray);
                linePen.Width = 1f;
                linePen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
                linePen.DashPattern = new float[] { 4.0F, 6.0F };

                float xInterval = Width / (yPointWidth - 1f);

                int[] mouseMatchingPoints = new int[0];

                for (int i = yStartPos; i < yStartPos + yPointWidth - 1; i++) {
                    int location = i - yStartPos;
                    if (i < ErrorHistory.Count - 1) {
                        float xPos = xInterval * (location);

                        float bottom = Height;

                        Pen defaultPen = new Pen(linePen.Brush, 0.5f);

                        //10 marker
                        if (i % 10 == 0) {
                            defaultPen.Color = Color.Black;
                            defaultPen.DashPattern = new float[] { 7.0F, 6.0F };
                            g.DrawLine(defaultPen, xPos, 0, xPos, bottom);
                        }
                        else
                            g.DrawLine(linePen, xPos, 0, xPos, bottom);

                        float xPos1 = xInterval * (location);
                        float yPos1 = bottom - (ErrorHistory[i] * bottom);

                        float xPos2 = xInterval * (location + 1);
                        float yPos2 = bottom - (ErrorHistory[i + 1] * bottom);

                        g.DrawLine(new Pen(Color.Red, 1), xPos1, yPos1, xPos2, yPos2);

                        if (errorDrawCursor)
                            if (PointToClient(MousePosition).X > xPos1 - (xInterval / 2) &&
                               PointToClient(MousePosition).X < xPos1 + (xInterval / 2))
                                mouseMatchingPoints = new int[] { (int)xPos1, (int)yPos1, i };

                    }
                }

                if (mouseMatchingPoints.Length > 0) {
                    int x = mouseMatchingPoints[0];
                    int y = mouseMatchingPoints[1];

                    int pos = mouseMatchingPoints[2];

                    float size = 2f;
                    float sizeDiv = size / 2;

                    g.DrawEllipse(new Pen(Color.Black, 2f), x - sizeDiv, y - sizeDiv, size, size);

                    drawMouse(g, new Point(x, y), pos);
                }

                BackgroundImage = bmp;

                //don't let it draw again soon
                Task.Run(action: async () => {
                    await Task.Delay(2);
                    errorCanDraw = true;
                });
            }
        }

        private void drawMouse(Graphics g, Point pos, int currentItem) {
            Point start = pos;

            string errStr = "" + ErrorHistory[currentItem];
            string epochStr = "Epoch: " + currentItem;

            int sizeWidth = Math.Max(errStr.Length, epochStr.Length);

            //height correction
            if (ErrorHistory[currentItem] < 0.5f) {
                start.Y -= 40;
            }
            else {
                start.Y += 6;
            }

            //width correction
            if (PointToClient(MousePosition).X < Width / 2) {
                start.X += 8;
            }
            else {
                start.X -= sizeWidth * 8 + 4;
            }

            Point errorDetailsTxt = start;
            errorDetailsTxt.X += 1;

            Point epochCounter = errorDetailsTxt;
            epochCounter.Y += 15;

            Size size = new Size(sizeWidth * 8, 34);

            Rectangle r = new Rectangle(start, size);

            g.DrawRectangle(new Pen(Color.Black), r);
            g.FillRectangle(new Pen(Color.FromName("Control")).Brush, new Rectangle(start, size));

            g.DrawString(errStr, new Font("Terminal", 11), new Pen(Color.Black).Brush, errorDetailsTxt);
            g.DrawString(epochStr, new Font("Terminal", 11), new Pen(Color.Black).Brush, epochCounter);
        }

        private void errorDrawing_Paint(object sender, PaintEventArgs e) {
            drawError(null, null);
        }

        public void ErrorMouseInteractions(object sender, MouseEventArgs e) {
            errorDrawCursor = true;

            drawError(null, null);
        }

        public void ErrorGraph_MouseLeave(object sender, EventArgs e) {
            errorDrawCursor = false;
            drawError(null, null);
        }

        public void trackErrorScale_ValueChanged(object sender, EventArgs e) {
            dynamic tag = ((Control)sender).Tag;

            yPointWidth = tag.track.Value * 25;

            tag.label.Text = $"Scale: {yPointWidth}";

            if (tag.track.Value == tag.track.Maximum) {
                yPointWidth = ErrorHistory.Count;
                tag.label.Text = "Scale: Full";
            }

            TbErrorYPos_ValueChanged(tag.YPos, null);

            drawError(null, null);
        }

        public void TbErrorYPos_ValueChanged(object sender, EventArgs e) {
            dynamic tag = ((Control)sender).Tag;

            float scale = (ErrorHistory.Count - yPointWidth) / (float)tag.track.Maximum;

            yStartPos = Math.Max(0, (int)(scale * tag.track.Value));

            drawError(null, null);
        }

    }
}
