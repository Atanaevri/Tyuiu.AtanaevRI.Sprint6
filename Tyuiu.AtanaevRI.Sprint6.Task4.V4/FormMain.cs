using System;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AtanaevRI.Sprint6.Task4.V4.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        private DataService ds;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Настройка графика
            chartFunction_ARI.Titles.Clear();
            chartFunction_ARI.Titles.Add("График функции F(x)");

            // Настройка серии
            chartFunction_ARI.Series.Clear();
            var series = chartFunction_ARI.Series.Add("F(x)");
            series.ChartType = SeriesChartType.Line;
            series.Color = System.Drawing.Color.Blue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 6;

            // Настройка осей
            chartFunction_ARI.ChartAreas[0].AxisX.Title = "x";
            chartFunction_ARI.ChartAreas[0].AxisY.Title = "F(x)";
            chartFunction_ARI.ChartAreas[0].AxisX.Interval = 1;
        }

        private void buttonCalculateFunction_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = -5;
                int stopValue = 5;

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

                
                textBoxResult_ARI.Text = "Таблица значений функции:" + Environment.NewLine;
                textBoxResult_ARI.AppendText("-------------------" + Environment.NewLine);
                textBoxResult_ARI.AppendText("    x    |   F(x)  " + Environment.NewLine);
                textBoxResult_ARI.AppendText("-------------------" + Environment.NewLine);

            
                chartFunction_ARI.Series[0].Points.Clear();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startValue + i;
                    double y = valueArray[i];

                
                    textBoxResult_ARI.AppendText(string.Format("{0,6} | {1,8:F2}" + Environment.NewLine, x, y));

                    
                    chartFunction_ARI.Series[0].Points.AddXY(x, y);
                }

                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V4.txt";
                ds.SaveToFileText(valueArray, path);

                MessageBox.Show($"Результаты сохранены в файл:\n{path}", "Успешно",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nДетали: {ex.StackTrace}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpInfo_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 4 | Вариант 4 | Атанаев Р.И. РИСб-20-1" +
                Environment.NewLine +
                "Табулирование функции: F(x) = (2x+6)/(cos(x)+x) - 3" +
                Environment.NewLine +
                "Диапазон: [-5; 5] с шагом 1" +
                Environment.NewLine +
                "При делении на ноль возвращается 0",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}