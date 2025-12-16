using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
// УДАЛИТЬ эту строку, если она есть:
// using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AtanaevRI.Sprint6.Task5.V23.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        private DataService ds;
        private string filePath;

        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
            SetupDataGridView();
            SetupChart();
        }

        private void SetupDataGridView()
        {
            dataGridViewNumbers_ARI.AutoGenerateColumns = false;
            dataGridViewNumbers_ARI.Columns.Clear();

            dataGridViewNumbers_ARI.Columns.Add("Index", "№");
            dataGridViewNumbers_ARI.Columns.Add("Value", "Значение");
            dataGridViewNumbers_ARI.Columns.Add("IsNegative", "< 0?");

            dataGridViewNumbers_ARI.Columns[0].Width = 50;
            dataGridViewNumbers_ARI.Columns[1].Width = 120;
            dataGridViewNumbers_ARI.Columns[2].Width = 60;

            dataGridViewNumbers_ARI.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewNumbers_ARI.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewNumbers_ARI.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetupChart()
        {
            // Настройка диаграммы
            chartNegative_ARI.Titles.Clear();
            chartNegative_ARI.Titles.Add("Отрицательные числа из файла");

            chartNegative_ARI.ChartAreas[0].AxisX.Title = "Порядковый номер";
            chartNegative_ARI.ChartAreas[0].AxisY.Title = "Значение";
            chartNegative_ARI.ChartAreas[0].AxisX.Interval = 1;
            chartNegative_ARI.ChartAreas[0].AxisY.LabelStyle.Format = "F3";

            chartNegative_ARI.Series.Clear();
            chartNegative_ARI.Series.Add("Отрицательные числа");

            // ИСПРАВЛЕНИЕ: используем полное имя с global::
            chartNegative_ARI.Series[0].ChartType = global::System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chartNegative_ARI.Series[0].Color = Color.Red;
            chartNegative_ARI.Series[0].IsValueShownAsLabel = true;
            chartNegative_ARI.Series[0].LabelFormat = "F3";
        }

        private void buttonOpenFile_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                string defaultPath = Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask5V23.txt");

                if (!File.Exists(defaultPath))
                {
                    CreateTestFile(defaultPath);
                }

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                    openFileDialog.FileName = "InPutFileTask5V23.txt";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        textBoxFilePath_ARI.Text = filePath;

                        double[] numbers = ds.LoadFromDataFile(filePath);
                        DisplayDataInGrid(numbers);
                        DisplayNegativeNumbersInChart(numbers);

                        MessageBox.Show($"Файл загружен успешно!\nПрочитано чисел: {numbers.Length}",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTestFile(string path)
        {
            string[] testData = {
                "3.14159",
                "-2.71828",
                "0",
                "-1.5",
                "2.0",
                "-0.75",
                "15.3",
                "-8.9",
                "100",
                "-0.001",
                "42.0",
                "-999.999",
                "0.123456",
                "-3.14"
            };

            File.WriteAllLines(path, testData);
        }

        private void DisplayDataInGrid(double[] numbers)
        {
            dataGridViewNumbers_ARI.Rows.Clear();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isNegative = numbers[i] < 0;
                int rowIndex = dataGridViewNumbers_ARI.Rows.Add(
                    i + 1,
                    numbers[i].ToString("F3"),
                    isNegative ? "Да" : "Нет"
                );

                if (isNegative)
                {
                    dataGridViewNumbers_ARI.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                }
            }

            labelTotalCount_ARI.Text = $"Всего чисел: {numbers.Length}";
        }

        private void DisplayNegativeNumbersInChart(double[] numbers)
        {
            chartNegative_ARI.Series[0].Points.Clear();

            int negativeCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeCount++;
                    chartNegative_ARI.Series[0].Points.AddXY(negativeCount, numbers[i]);
                }
            }

            labelNegativeCount_ARI.Text = $"Отрицательных чисел: {negativeCount}";
        }

        private void buttonHelp_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 5 | Вариант 23 | Атанаев Р.И. | РППБ-25-1\n\n" +
                "Задание:\n" +
                "1. Прочитать данные из файла InPutFileTask5V23.txt\n" +
                "2. Вывести все числа в таблицу (dataGridView)\n" +
                "3. Выделить числа меньше 0\n" +
                "4. Построить диаграмму по отрицательным значениям\n" +
                "5. Округлить вещественные значения до трёх знаков после запятой",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSaveResult_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                {
                    MessageBox.Show("Сначала загрузите файл!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string outputPath = Path.Combine(
                    Path.GetDirectoryName(filePath),
                    "OutPutFileTask5V23.txt");

                double[] numbers = ds.LoadFromDataFile(filePath);

                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    writer.WriteLine("ОТЧЕТ - Анализ чисел из файла");
                    writer.WriteLine($"Файл: {Path.GetFileName(filePath)}");
                    writer.WriteLine($"Дата анализа: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                    writer.WriteLine("==========================================");

                    int negativeCount = 0;
                    writer.WriteLine($"Всего чисел: {numbers.Length}");

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] < 0) negativeCount++;
                    }

                    writer.WriteLine($"Отрицательных чисел: {negativeCount}");
                    writer.WriteLine("==========================================");
                    writer.WriteLine("Список отрицательных чисел:");

                    int negativeIndex = 1;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] < 0)
                        {
                            writer.WriteLine($"{negativeIndex}. {numbers[i]:F3}");
                            negativeIndex++;
                        }
                    }
                }

                MessageBox.Show($"Результат сохранен в файл:\n{outputPath}",
                    "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerateTestFile_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "InPutFileTask5V23.txt");
                CreateTestFile(path);
                MessageBox.Show($"Тестовый файл создан:\n{path}",
                    "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании файла:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}