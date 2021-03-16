using System;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace MathMethods
{
    public partial class InvestForm : Form
    {
        #region Initialization
        double[,] ProfitMatrix;
        int defRows = 4;
        int defCols = 4;
        //    = { { 0, 0, 0, 0 },
        //        { 1, 2, 1, 2 },
        //        { 3, 4, 4, 3 },
        //        { 5, 4, 5, 4 }
        //}; 
        double[] investitions; //= { 0, 3.8, 5.4, 8 };
        NumberFormatInfo info = new NumberFormatInfo();
        char sep;
        InvestProblemSolver Solver;
        #endregion
        public InvestForm()
        {
            InitializeComponent();
            sep = Convert.ToChar(info.NumberDecimalSeparator);

            CurcyUnQuan.Value = defRows;
            CompaniesQuan.Value = defCols;
            SetGrid(defRows, defCols);

            InGrid.Columns[0].DefaultCellStyle.BackColor = Color.Silver;
        }

        void SetGrid(int monquan, int facquan)
        {
            InGrid.RowCount = monquan;
            InGrid.ColumnCount = facquan + 1;
            InGrid.Columns[0].HeaderText = "x";
            for (int i = 1; i < InGrid.ColumnCount; i++)
            {
                InGrid.Columns[i].HeaderText = String.Format("f{0}(x)", i);
            }
            for (int i = 0; i < InGrid.RowCount; i++)
            {
                for (int j = 0; j < InGrid.ColumnCount; j++)
                {
                    if (InGrid.Rows[i].Cells[j].Value == null) InGrid.Rows[i].Cells[j].Value = 0;
                }
            }
            foreach (DataGridViewColumn col in InGrid.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SizeChange(object sender, EventArgs e)
        {
            SetGrid((int)CurcyUnQuan.Value, (int)CompaniesQuan.Value);
        }

        private void ClearCellsBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InGrid.RowCount; i++)
            {
                for (int j = 0; j < InGrid.ColumnCount; j++)
                {
                    InGrid.Rows[i].Cells[j].Value = 0;
                }
            }
            ResPanel.Visible = false;
            OutBox.Text = null;
        }
        private void ResetAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InGrid.RowCount; i++)
            {
                for (int j = 0; j < InGrid.ColumnCount; j++)
                {
                    InGrid.Rows[i].Cells[j].Value = null;
                }
            }
            ResPanel.Visible = false;
            OutBox.Text = null;
            SetGrid(defRows, defCols);
            CurcyUnQuan.Value = defRows;
            CompaniesQuan.Value = defCols;
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            ProfitMatrix = new double[(int)CurcyUnQuan.Value, (int)CompaniesQuan.Value];
            investitions = new double[(int)CurcyUnQuan.Value];
            for (int i = 0; i < investitions.Length; i++)
            {
                if (!Double.TryParse(InGrid.Rows[i].Cells[0].Value.ToString(), out investitions[i]))
                {
                    MessageBox.Show("В столбце вариантов распределения денежных средств обнаружено не число. Исправьте ошибку и повторите снова", "Ошибка");
                    return;
                }
            }
            for (int i = 0; i < ProfitMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ProfitMatrix.GetLength(1); j++)
                {
                    if (!Double.TryParse(InGrid.Rows[i].Cells[j + 1].Value.ToString(), out ProfitMatrix[i, j]))
                    {
                        MessageBox.Show("В ячейках прибыли обнаружено не число. Исправьте ошибку и повторите снова", "Ошибка");
                        return;
                    }
                }
            }

            Solver = new InvestProblemSolver(investitions, ProfitMatrix);

            Solver.Solve();

            ResValueLabel.Text = Solver.MaxProfit.ToString();
            ResPanel.Visible = true;
            OutBox.Text = null;
            OutBox.Text += "(";
            for (int i = 0; i < ProfitMatrix.GetLength(1) - 1; i++)
            {
                OutBox.Text += Solver.Result[i].ToString() + ", ";
            }
            OutBox.Text += Solver.Result[ProfitMatrix.GetLength(1) - 1].ToString() + ")";
        }

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
    }

    public class InvestProblemSolver
    {
        int dist_quan; //количество вариантов распределений (кол-во строк)
        int fac_quan;  //количество предприятий
        double[,] matrix;
        double[] investitions;
        public double[] Result { get; private set; }
        public double MaxProfit { get; private set; }

        public InvestProblemSolver(double[] investitions, double[,] matrix)
        {
            this.investitions = investitions;
            this.matrix = matrix;
            dist_quan = investitions.Length;
            fac_quan = matrix.GetLength(1);
        }

        public void Solve()
        {
            Distribution[] dist = new Distribution[dist_quan]; //структура значений распределений
            double dist_maxval;
            for (int i = 0; i < dist_quan; i++)
            {
                dist[i] = new Distribution(i + 1);
                dist_maxval = investitions[i];
                for (int j = 0; j < i + 1; j++)
                {
                    dist[i].val1i[j] = investitions[j];
                    dist[i].val2i[j] = dist_maxval - investitions[j];
                }
            }

            Step[] steps = new Step[fac_quan];
            DistValues[] dist_val;
            for (int k = fac_quan; k > 0; k--) //шаг
            {
                dist_val = new DistValues[dist_quan];
                for (int i = 0; i < dist_quan; i++) //распределение
                {
                    dist_val[i] = new DistValues(i + 1);
                    for (int j = 0; j < i + 1; j++) //член распределения
                    {
                        dist_val[i].val1[j] = matrix[j, k - 1];
                        dist_val[i].val2[j] = (k == fac_quan) ? 0 : steps[k].GetMax(i - j); //0 или пред.рез-тат
                    }
                }
                steps[k - 1] = new Step(dist_val);
            }

            Result = new double[fac_quan];
            int branch = dist_quan - 1;
            MaxProfit = steps[0].GetMax(branch); //
            Result[0] = dist[branch].val1i[steps[0].GetMaxInd(branch)];

            for (int k = 1; k < fac_quan - 1; k++)
            {
                branch = dist[branch].Length - 1 //длина предыдущей ветки - 1
                         -
                         steps[k - 1].GetMaxInd(branch); //минус индекс максимума 

                Result[k] = dist[branch].val1i[steps[k].GetMaxInd(branch)];
            }
            Result[fac_quan - 1] = dist[branch].val2i[steps[fac_quan - 2].GetMaxInd(branch)];
        }
    }

    public struct Distribution
    {
        public int Length { get; private set; }
        public Distribution(int length)
        {
            val1i = new double[length];
            val2i = new double[length];
            Length = length;
        }
        public double[] val1i { get; set; }
        public double[] val2i { get; set; }
    }

    public struct DistValues
    {
        public DistValues(int length)
        {
            val1 = new double[length];
            val2 = new double[length];
        }
        public double[] val1 { get; set; }
        public double[] val2 { get; set; }
        public double GetSum(int index) => val1[index] + val2[index];
        public double MaxVal
        {
            get
            {
                double max = GetSum(0);
                for (int i = 1; i < val1.Length; i++)
                {
                    if (GetSum(i) > max) max = GetSum(i);
                }
                return max;
            }
        }
        public int MaxInd
        {
            get
            {
                int index = 0;
                double max = GetSum(index); 
                for (int i = 1; i < val1.Length; i++)
                {
                    if (GetSum(i) > max) { max = GetSum(i); index = i; }
                }
                return index;
            }
        }
    }

    public struct Step
    {
        public Step(DistValues[] values)
        {
            this.values = values;
        }
        DistValues[] values;
        public int GetMaxInd(int index) => values[index].MaxInd;
        public double GetMax(int index) => values[index].MaxVal;
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                output.Append(String.Format("{0,3} ", GetMax(i)));
            }
            return output.ToString();
        }
    }
}