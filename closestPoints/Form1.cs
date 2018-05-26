using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace closestPoints
{
    public partial class closestPointsProgram : Form
    {
        private List<Point> points = new List<Point>();
        private List<Rectangle> rects = new List<Rectangle>();
        private Point MOM = new Point(-1,-1);

        private void setStatusText(string text)
        {
            this.statusLabel.Text += text + "\n";
        }

        public closestPointsProgram()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generatePointsButton_Click(object sender, EventArgs e)
        {
            this.generatePointsButton.Enabled = false;
            this.resetButton.Enabled = true;
            this.highlightMOMButton.Enabled = true;
            this.showMOMLineButton.Enabled = false;
            setStatusText("Gerando pontos");
            generatePoints();
            setStatusText("Desenhando pontos");
            drawPoints();
        }

        private void drawPoints()
        {
            Graphics formGraphics = this.CreateGraphics();
            for (int count = 0; count < rects.Count; count++)
                panel1.CreateGraphics().FillEllipse(new SolidBrush(Color.Black), rects[count]);
            
        }

        private float findClosestPoints(List<Point> list, out List<Point> sortedPoints, out List<int> closestPair)
        {
            if(list.Count == 1)
            {
                sortedPoints = list;
                closestPair = new List<int>();
                closestPair.Add(0);
                return float.MaxValue;
            }
            Point median = findMOM(list, list.Count / 2);
            List<Point> A = new List<Point>(), B = new List<Point>();
            List<Point> sortedAList = new List<Point>();
            List<int> closestA = new List<int>();
            List<Point> sorted = new List<Point>();
            List<Point> sortedBList = new List<Point>();
            List<int> closestB = new List<int>();
            List<int> closest = new List<int>();
            foreach (Point point in list)
            {
                if(point.X >= median.X)
                {
                    A.Add(point);
                }
                else
                {
                    B.Add(point);
                }
            }
            if(A.Count == 0 || B.Count == 0)
            {
                if(A.Count == 0)
                {
                    A.Add(B[0]);
                    B.RemoveAt(0);
                }
                else
                {
                    B.Add(A[A.Count - 1]);
                    A.RemoveAt(A.Count - 1);
                }
            }
            float minA = findClosestPoints(A, out sortedAList, out closestA);
            float minB = findClosestPoints(B, out sortedBList, out closestB);
            float min = minA < minB ? minA : minB;
            closest = minA < minB ? closestA : closestB;
            int i = 0, j = 0;
            while(i < A.Count || j < B.Count)
            {
                if(i >= A.Count)
                {
                    sorted.Add(B[j]);
                    j++;
                    continue;
                }
                if(j >= B.Count)
                {
                    sorted.Add(A[i]);
                    i++;
                    continue;
                }
                if(A[i].Y < B[j].Y)
                {
                    sorted.Add(A[i++]);
                }
                else
                {
                    sorted.Add(B[j++]);
                }
            }
            List<Point> filtered = new List<Point>();
            for (int c = 0; c < sorted.Count; c++)
            {
                if (sorted[c].X > median.X - min && sorted[c].X < median.X + min)
                {
                    filtered.Add(sorted[c]);
                }
            }

            for (int c1 = 1; c1 < filtered.Count; c1++)
            {
                int start = c1 < 7 ? 0 : c1 - 7;
                for(int c2 = start; c2 < c1; c2++)
                {
                    float a = (float)(filtered[c1].X - filtered[c2].X);
                    float b = (float)(filtered[c1].Y - filtered[c2].Y);
                    float newMin = (float)Math.Sqrt(a * a + b * b);
                    if (newMin < min)
                    {
                        closest.Clear();
                        min = newMin;
                        closest.Add(points.IndexOf(filtered[c1]));
                        closest.Add(points.IndexOf(filtered[c2]));
                    }
                }
            }
            closestPair = closest;
            sortedPoints = sorted;
            return min;
        }

        private void generatePoints()
        {
            Point point;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            bool valid = true;
            for (int count = 0; count < pointsNumber.Value; count++)
            {
                do
                {
                    valid = true;
                    point = new Point(rand.Next(10, 390), rand.Next(10, 390));
                    for(int intCount = 1; intCount <= 10; intCount++)
                    {
                        if(points.Contains(new Point(point.X + intCount, point.Y + intCount))){
                            valid = false;
                        }
                    }
                    for (int c = 0; c < points.Count; c++)
                    {
                        if (points[c].X == point.X)
                        {
                            valid = false;
                        }
                    }
                } while (valid && points.Contains(point));
                points.Add(point);
            }
            for (int count = 0; count < pointsNumber.Value; count++)
            {
                Rectangle rect = new Rectangle(points[count].X, points[count].Y, 3, 3);
                rects.Add(rect);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.generatePointsButton.Enabled = true;
            this.pointsNumber.Value = 50;
            this.resetButton.Enabled = false;
            this.highlightMOMButton.Enabled = false;
            this.showMOMLineButton.Enabled = false;
            points.Clear();
            panel1.CreateGraphics().Clear(Color.White);
            statusLabel.Text = "Status:\n";
            rects.Clear();
            MOM = new Point(-1, -1);
        }

        private Point findMOM(List<Point> list, int i)
        {
            Point pivotIndex;
            List<List<Point>> subGroups = new List<List<Point>>();
            List<Point> medians = new List<Point>();
            List<Point> low = new List<Point>();
            List<Point> high = new List<Point>();
            //Divide em subgrupos ordenados
            for (int count = 0; count < list.Count; count += 5)
            {
                subGroups.Add(list.GetRange(count, Math.Min(5, list.Count - count)));
            }
            for (int count = 0; count < subGroups.Count; count += 5)
            {
                subGroups[count] = subGroups[count].OrderBy(p => p.X).ToList();
            }
  
            // Cria o vetor de medianas
            foreach (List<Point> sublist in subGroups)
            {
                medians.Add(sublist[sublist.Count / 2]);
            }

            //verifica se chama recursivo ou não
            if(medians.Count < 5)
            {
                pivotIndex = medians.OrderBy(p => p.X).ToList()[medians.Count / 2];
            }
            else
            {
                pivotIndex = findMOM(medians, medians.Count / 2);
            }
            //divide em maior e menor
            foreach(Point point in list)
            {
                if (point.X < pivotIndex.X)
                {
                    low.Add(point);
                }
                else
                {
                    high.Add(point);
                }
            }
            int k = low.Count;
            if (i < k)
            {
                return findMOM(low, i);
            }
            else if(i > k)
            {
                return findMOM(high, i - k - 1);
            }
            else
            {
                return pivotIndex;
            }

        }

        private Point select(List<Point> L, int k)
        {
            List<Point> filtered = new List<Point>();
            List<List<Point>> subGroups = new List<List<Point>>();
            if (L.Count < 10)
            {
                L = L.OrderBy(p => p.X).ToList();
                return L[L.Count/2];
            }
            for (int count = 0; count < L.Count; count += 5)
            {
                subGroups.Add(L.GetRange(count, Math.Min(5, L.Count - count)));
            }

            foreach(List<Point> sub in subGroups)
            {
                filtered.Add(select(sub, 3));
            }

            Point M = select(filtered, L.Count / 10);

            List<Point> L1 = new List<Point>(), L2 = new List<Point>(), L3 = new List<Point>();

            foreach(Point point in L)
            {
                if(point.X < M.X)
                {
                    L1.Add(point);
                }
                else if(point.Y > M.X)
                {
                    L3.Add(point);
                }
                else
                {
                    L2.Add(point);
                }
            }

            if (k < L1.Count)
            {
                return select(L1, k);
            }
            else if (k > L1.Count + L2.Count)
            {
                return select(L3, k - L1.Count - L2.Count);
            }
            else
            {
                return M;
            }
        }

        private void highlightMOMButton_Click(object sender, EventArgs e)
        {
            MOM = findMOM(points, points.Count/2);
            setStatusText("MOM = " + MOM.ToString());
            Rectangle rect = new Rectangle(MOM.X, MOM.Y, 4, 4);

            panel1.CreateGraphics().FillEllipse(new SolidBrush(Color.Red), rect);
            ((Control)sender).Enabled = false;
            this.showMOMLineButton.Enabled = true;
        }

        private void showMOMLineButton_Click(object sender, EventArgs e)
        {
            ((Control)sender).Enabled = false;
            Pen blackPen = new Pen(Color.Black, 2);
            panel1.CreateGraphics().DrawLine(blackPen, new Point(MOM.X+4, 0), new Point(MOM.X+4, 400));
        }

        private void findClosestPointsButton_Click(object sender, EventArgs e)
        {
            List<Point> sorted = new List<Point>();
            List<int> closestPair = new List<int>();
            float minDist = findClosestPoints(points, out sorted, out closestPair);
            setStatusText("Menor distância: " + minDist.ToString());
            panel1.CreateGraphics().DrawLine(new Pen(Color.Black, 1), points[closestPair[0]], points[closestPair[1]]);
        }
    }
}
