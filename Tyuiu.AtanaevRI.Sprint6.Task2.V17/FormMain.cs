using System;
using System.Windows.Forms;
using Tyuiu.AtanaevRI.Sprint6.Task2.V17.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ARI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ARI.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ARI.Text);

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_ARI.Titles.Clear();
                this.chartFunction_ARI.Titles.Add("График функции F(x)");

                this.chartFunction_ARI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ARI.ChartAreas[0].AxisY.Title = "Ось F(x)";

                textBoxResult_ARI.Text = "";

                chartFunction_ARI.Series[0].Points.Clear();
                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.chartFunction_ARI.Series[0].Points.AddXY(startStep + i, valueArray[i]);
                    textBoxResult_ARI.AppendText("x = " + (startStep + i) + ", F(x) = " + valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) = cos(x) + 4x/2 - sin(x)*3x на диапазоне [-5;5]. Выполнил: студент группы РППБ-25-1 Атанаев Р.И.", "Справка");
        }
    }
}