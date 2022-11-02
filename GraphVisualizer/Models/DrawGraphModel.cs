using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphVisualizer.Models
{
    public class DrawGraphModel
    {
        Graphics g;
        PictureBox _pictureBox;
        List<Node> nodes = new List<Node>();
        int diam = 80;
        private int scrollNumber = 0;
        private const int scrollNumberAllowed = 3;
        const float scalingCoefficient = 1.2F;
        string[,] _matrix = {
            { "2", "1", "0", "0", "0" ,"0" },
            { "1", "0", "2", "0", "0", "0" },
            { "0","2", "0", "1", "1", "0" },
            { "0", "0", "1", "0", "1", "0" },
            { "0", "0", "1", "1", "0", "3" },
            { "0", "0", "0", "0", "3", "1" }
        };

        public DrawGraphModel(PictureBox pictureBox, string[,] matrix)
        {
            _matrix = matrix;
            _pictureBox = pictureBox;
            g = _pictureBox.CreateGraphics();
        }

        public void IncreaseScale() {
            if (scrollNumber == scrollNumberAllowed) {
                Debug.WriteLine("scrollNumber=" + scrollNumber + ", can't scale up");
                return;
            }

            scrollNumber++;

            Matrix scalingMatrix = new Matrix();

            scalingMatrix.Scale(scalingCoefficient, scalingCoefficient);
            
            g.MultiplyTransform(scalingMatrix);

            Render();
        }

        public void DecreaseScale() {
            if (scrollNumber == -scrollNumberAllowed) {
                Debug.WriteLine("scrollNumber=" + scrollNumber + ", can't scale down");
                return;
            }

            scrollNumber--;

            Matrix scalingMatrix = new Matrix();

            scalingMatrix.Scale(1 / scalingCoefficient, 1 / scalingCoefficient);

            g.MultiplyTransform(scalingMatrix);

            Render();
        }

        public void Render()
        {
            //g = this.pictureBox1.CreateGraphics();
            //g = button1.CreateGraphics();
            nodes.Clear();
            int textOffset = 15;
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 3f);
            SolidBrush solidBrush = new SolidBrush(Color.YellowGreen);

            double angle = Math.PI * 2.0 / Math.Sqrt(_matrix.Length);
            var radius = _pictureBox.Height / 2 - 5;
            var centerX = _pictureBox.Width / 2;
            var centerY = _pictureBox.Height / 2;
            if (_matrix.Length == 1)
            {
                nodes.Add(new Node(centerX, centerY));
            }
            else
            {
                for (double currentAngle = 0; currentAngle < Math.PI * 2; currentAngle += angle)
                {
                    int x = (int)(radius * Math.Cos(currentAngle) + centerX);
                    int y = (int)(radius * Math.Sin(currentAngle) + centerY);

                    nodes.Add(new Node(x + diam, y + diam));
                }
            }

            for (int i = 1; i < Math.Sqrt(_matrix.Length); i++)
            {

                for (int j = 1; j < Math.Sqrt(_matrix.Length); j++)
                {
                    if (Convert.ToInt32(_matrix[i, j]) > 0)
                    {
                        if (i == j)
                        {
                            g.DrawEllipse(pen, nodes[i].x + diam / 2, nodes[i].y - diam / 4, diam / 2, diam / 2);
                        }
                        else
                        {
                            g.DrawLine(pen, nodes[i].x + diam / 2, nodes[i].y + diam / 2,
                                nodes[j].x + diam / 2, nodes[j].y + diam / 2);
                        }
                    }
                }
            }
            for (int i = 1; i < Math.Sqrt(_matrix.Length); i++)
            {
                g.FillEllipse(solidBrush, nodes[i].x, nodes[i].y, diam, diam);
                g.DrawEllipse(pen, nodes[i].x, nodes[i].y, diam, diam);
                g.DrawString(_matrix[i, 0].ToString(), new Font("Courier New", diam / 4, FontStyle.Bold), new SolidBrush(Color.Magenta), new Point(nodes[i].x - textOffset, nodes[i].y - textOffset));


                for (int j = i; j < Math.Sqrt(_matrix.Length); j++)
                {
                    if (Convert.ToInt32(_matrix[i, j]) > 0)
                    {
                        g.DrawString(_matrix[i, j], new Font("Courier New", diam / 4, FontStyle.Bold), new SolidBrush(Color.OrangeRed),
                            new Point((nodes[i].x + nodes[j].x) / 2 + diam / 2, (nodes[i].y + nodes[j].y) / 2 + diam / 2 - 2 * textOffset));
                    }
                }

            }
        }
    }

    class Node
    {
        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x, y;
    }
}
