using System;
using System.Windows.Forms;
using Tyuiu.AtanaevRI.Sprint6.Task3.V24.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitializeDataGridView(); // Инициализируем DataGridView
            LoadOriginalMatrix(); // Загружаем исходные данные
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            { -17, -6, 10, 5, 3 },      
            { -10, -14, 10, -7, -3 },
            { -19, 9, 8, -17, -9 },
            { -19, -5, -9, -18, 14 },
            { 17, 12, 11, 12, 2 }
        };

        private void InitializeDataGridView()
        {
            try
            {
                // Очищаем существующие столбцы
                dataGridViewRes_ARI.Columns.Clear();
                dataGridViewRes_ARI.Rows.Clear();

                // Создаем 5 столбцов
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewRes_ARI.Columns.Add($"Column{i}", $"Столбец {i + 1}");
                    dataGridViewRes_ARI.Columns[i].Width = 60;
                }

                // Создаем 5 строк
                dataGridViewRes_ARI.RowCount = 5;

                // Настраиваем внешний вид
                dataGridViewRes_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewRes_ARI.ReadOnly = true;
                dataGridViewRes_ARI.AllowUserToAddRows = false;
                dataGridViewRes_ARI.AllowUserToResizeRows = false;
                dataGridViewRes_ARI.AllowUserToResizeColumns = false;

                // Центрируем текст
                dataGridViewRes_ARI.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewRes_ARI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации DataGridView: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOriginalMatrix()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (dataGridViewRes_ARI.Rows.Count > i &&
                            dataGridViewRes_ARI.Columns.Count > j)
                        {
                            dataGridViewRes_ARI.Rows[i].Cells[j].Value = matrix[i, j];
                        }
                    }
                }

                // Снимаем выделение
                dataGridViewRes_ARI.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStart_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                // Вычисляем результат
                int[,] resultMatrix = ds.Calculate(matrix);

                // Отображаем результат в DataGridView
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (dataGridViewRes_ARI.Rows.Count > i &&
                            dataGridViewRes_ARI.Columns.Count > j)
                        {
                            dataGridViewRes_ARI.Rows[i].Cells[j].Value = resultMatrix[i, j];
                        }
                    }
                }

                // Подсвечиваем вторую строку (индекс 1) - только если она существует
                if (dataGridViewRes_ARI.Rows.Count > 1)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (dataGridViewRes_ARI.Columns.Count > j)
                        {
                            dataGridViewRes_ARI.Rows[1].Cells[j].Style.BackColor = System.Drawing.Color.LightYellow;
                        }
                    }
                }

                // Снимаем выделение
                dataGridViewRes_ARI.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППБ-25-1 Атанаев Роман Ильнурович",
                           "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewRes_ARI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Пустой обработчик события
        }
    }
}