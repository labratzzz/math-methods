using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportationProblem
{
    public partial class TranspProblem : Form
    {
        #region Initialization
        NumberFormatInfo info = new NumberFormatInfo();
        char sep;
        int defRows = 4, defCols = 4;
        double[,] custcm = { { 80,  215 },
                             { 100, 108 },
                             { 102, 68  }
                            };
        double[] custA = { 1000, 1500, 1200 };
        double[] custB = { 2300, 1400 };
        
        public TranspProblem()
        {
            
            InitializeComponent();
            sep = Convert.ToChar(info.NumberDecimalSeparator);
            InGrid.RowHeadersDefaultCellStyle.Padding = new Padding(InGrid.RowHeadersWidth);
            RowsCount.Value = defRows;
            ColsCount.Value = defCols;
            SetGrid(defRows, defCols, true);
        }
        #endregion

        void SetGrid(int rows, int cols, bool clear)
        {
            //params
            InGrid.RowCount = rows + 1;
            InGrid.ColumnCount = cols + 1;
            //text
            InGrid.Columns[0].HeaderCell.Value = "a[i]";
            InGrid.Rows[0].HeaderCell.Value = "b[j]";
            for (int i = 1; i < InGrid.ColumnCount; i++)
            {
                InGrid.Columns[i].HeaderCell.Value = "B" + i;
                InGrid.Rows[0].Cells[i].Style.BackColor = Color.Silver;
            }
            for (int i = 1; i < InGrid.RowCount; i++)
            {
                InGrid.Rows[i].HeaderCell.Value = "A" + i;
                InGrid.Rows[i].Cells[0].Style.BackColor = Color.Silver;
            }
            //type
            for (int i = 0; i < InGrid.RowCount; i++)
            {
                for (int j = 0; j < InGrid.ColumnCount; j++)
                {
                    InGrid.Rows[i].Cells[j].ValueType = typeof(double);
                    if (clear)
                    {
                        InGrid.Rows[i].Cells[j].Value = 0;
                    }
                    else if (InGrid.Rows[i].Cells[j].Value == null) InGrid.Rows[i].Cells[j].Value = 0;
                }
            }
            //style
            InGrid.Rows[0].Cells[0].Value = null;
            InGrid.Rows[0].Cells[0].ReadOnly = true;
            InGrid.Rows[0].Cells[0].Style.BackColor = Color.DimGray;

            foreach (DataGridViewColumn col in InGrid.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void NumericGridChange(object sender, EventArgs e)
        {
            SetGrid((int)RowsCount.Value, (int)ColsCount.Value, false);
        }
        //style
        private void InGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            object o = InGrid.Rows[e.RowIndex].HeaderCell.Value;

            e.Graphics.DrawString(
                o != null ? o.ToString() : "",
                InGrid.Font,
                Brushes.Black,
                new PointF((float)e.RowBounds.Left + 2, (float)e.RowBounds.Top + 4));
        }
        //entered value checker
        private void InGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox temp = (TextBox)e.Control;
            temp.KeyPress -= this.TempControl_KeyPress;
            temp.KeyPress += this.TempControl_KeyPress;
        }
        private void TempControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = ((TextBox)sender).Text;

            if (Char.IsDigit(e.KeyChar) ||
                (e.KeyChar == sep && text.IndexOf(sep) == -1 && !String.IsNullOrWhiteSpace(text)) ||
                e.KeyChar == 8)
                return;
            e.Handled = true;
        }

        private void ClearCellsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InGrid.RowCount; i++)
            {
                for (int j = 0; j < InGrid.ColumnCount; j++)
                {
                    InGrid.Rows[i].Cells[j].ValueType = typeof(double);
                    InGrid.Rows[i].Cells[j].Value = 0;
                }
            }
            //style
            InGrid.Rows[0].Cells[0].Value = null;
            InGrid.Rows[0].Cells[0].ReadOnly = true;
            InGrid.Rows[0].Cells[0].Style.BackColor = Color.DimGray;
        }
        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            RowsCount.Value = defRows;
            ColsCount.Value = defCols;
            SetGrid(defRows, defCols, true);
            OutGrid.Rows.Clear();
            CostValue.Text = "Ожидание";
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            double[,] CostMatrix;
            double[] Providers, Consumers;

            Providers = new double[InGrid.RowCount - 1];
            for (int i = 0; i < Providers.Length; i++)
            {
                Providers[i] = (double)InGrid.Rows[i + 1].Cells[0].Value;
            }

            Consumers = new double[InGrid.ColumnCount - 1];
            for (int i = 0; i < Consumers.Length; i++)
            {
                Consumers[i] = (double)InGrid.Rows[0].Cells[i + 1].Value;
            }

            CostMatrix = new double[Providers.Length, Consumers.Length];
            for (int i = 0; i < Providers.Length; i++)
            {
                for (int j = 0; j < Consumers.Length; j++)
                {
                    CostMatrix[i, j] = (double)InGrid.Rows[i + 1].Cells[j + 1].Value;
                }
            }

            Solver transp = new Solver(CostMatrix, Providers, Consumers);
            double[,] output = transp.Solve();

            OutGrid.RowCount = output.GetLength(0);
            OutGrid.ColumnCount = output.GetLength(1);
            for (int i = 0; i < OutGrid.RowCount; i++)
            {
                for (int j = 0; j < OutGrid.ColumnCount; j++)
                {
                    OutGrid.Rows[i].Cells[j].Value = output[i, j];
                }
            }
            CostValue.Text = transp.GetCostFunc().ToString();
        }
    }

    public class Solver
    {
        double[,] cm; //cost matrix
        double[,] curSP; //current SP (supporting plan)
        double[] A, B; //A - provider resources, B - consumer needs
        double[] u, v; //potentials

        public Solver(double[,] cost_matrix, double[] providers, double[] consumers)
        {
            if (GetArraySum(providers) < GetArraySum(consumers))
            {
                A = new double[providers.Length + 1];
                providers.CopyTo(A, 0);
                B = consumers;
                A[A.Length - 1] = GetArraySum(consumers) - GetArraySum(providers);
            }
            else if (GetArraySum(providers) > GetArraySum(consumers))
            {
                A = providers;
                B = new double[consumers.Length + 1];
                consumers.CopyTo(B, 0);
                B[B.Length - 1] = GetArraySum(providers) - GetArraySum(consumers);
            }
            else
            {
                A = providers;
                B = consumers;
            }
            u = new double[A.Length];
            v = new double[B.Length];
            cm = new double[A.Length, B.Length];
            cm = InsertArray(cost_matrix, cm);
        }
        public double[,] Solve()
        {
            SearchForSP(GetMinSeq(cm));
            return curSP;
        }

        private static double GetArraySum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        private static double[,] InsertArray(double[,] array, double[,] to_array)
        {
            if (array.Length > to_array.Length) throw new ArgumentException();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    to_array[i, j] = array[i, j];
                }
            }
            return to_array;
        }

        private void SearchForSP(Point[] MinInd) //minimal element method
        {
            int i = 0;
            curSP = new double[cm.GetLength(0), cm.GetLength(1)];
            while (GetArraySum(A) != 0)
            {
                if (A[MinInd[i].X] == 0 || B[MinInd[i].Y] == 0) { i++; continue; }
                if (A[MinInd[i].X] < B[MinInd[i].Y])
                {
                    curSP[MinInd[i].X, MinInd[i].Y] = A[MinInd[i].X];
                    B[MinInd[i].Y] -= A[MinInd[i].X];
                    A[MinInd[i].X] = 0;
                }
                else
                {
                    curSP[MinInd[i].X, MinInd[i].Y] = B[MinInd[i].Y];
                    A[MinInd[i].X] -= B[MinInd[i].Y];
                    B[MinInd[i].Y] = 0;
                }
                i++;
            }
        }
        private Point[] GetMinSeq(double[,] array) //minimal elements row
        {
            double[] array_s = ConvertToSingle(array);
            Point[] ind = new Point[array_s.Length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    ind[j + i * array.GetLength(1)] = new Point(i, j);
                }
            }
            double tempd; Point tempp;
            for (int i = 0; i < array_s.Length; i++)
            {
                for (int j = array_s.Length - 1; j > i; j--)
                {
                    if (array_s[j - 1] > array_s[j])
                    {
                        tempd = array_s[j - 1];
                        tempp = ind[j - 1];

                        array_s[j - 1] = array_s[j];
                        ind[j - 1] = ind[j];

                        array_s[j] = tempd;
                        ind[j] = tempp;
                    }
                }
            }
            return ind;
        }  
        private double[] ConvertToSingle(double[,] array) //convert matrix single array
        {
            double[] output = new double[array.Length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output[j + i * array.GetLength(1)] = array[i, j];
                }
            }
            return output;
        } 

        private void CalcPotentials()
        {
            List<Point> eqs = new List<Point>();
            int[] UCount = new int[curSP.GetLength(0)]; int indU = 0;
            for (int i = 0; i < curSP.GetLength(0); i++)
            {
                for (int j = 0; j < curSP.GetLength(1); j++)
                {
                    if (curSP[i, j] > 0)
                    {
                        UCount[i]++;
                        eqs.Add(new Point(i, j));
                    }
                }
                if (UCount[i] > UCount[indU]) indU = i; //выбор потенциала U, который встречается в уравнениях чаще всего
            }          
        }
        public double GetCostFunc()
        {
            double sum = 0;
            for (int i = 0; i < cm.GetLength(0); i++)
            {
                for (int j = 0; j < cm.GetLength(1); j++)
                {
                    sum += cm[i, j] * curSP[i, j];
                }
            }
            return sum;
        } //calculate cost function - Z(x)

        struct Potentials
        {
            double[] u, v;
            Point[] eqs;
            double[,] cm;
            public Potentials(int ucount, int vcount, int indU, Point[] equations, double[,] cm)
            {
                u = new double[ucount];
                v = new double[vcount];
                eqs = equations;
                this.cm = cm;
                for (int i = 0; i < ucount; i++)
                {
                    u[i] = Double.NaN;
                }
                u[indU] = 0;
                for (int i = 0; i < vcount; i++)
                {
                    v[i] = Double.NaN;
                }
            }
        }
    }
}