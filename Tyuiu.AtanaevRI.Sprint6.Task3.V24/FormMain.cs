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
            InitializeDataGridView(); 
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
             
                dataGridViewRes_ARI.Columns.Clear();
                dataGridViewRes_ARI.Rows.Clear();

             
                for (int i = 0; i < 5; i++)
                {
                    dataGridViewRes_ARI.Columns.Add($"Column{i}", $"Столбец {i + 1}");
                    dataGridViewRes_ARI.Columns[i].Width = 60;
                }

                dataGridViewRes_ARI.RowCount = 5;

                dataGridViewRes_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewRes_ARI.ReadOnly = true;
                dataGridViewRes_ARI.AllowUserToAddRows = false;
                dataGridViewRes_ARI.AllowUserToResizeRows = false;
                dataGridViewRes_ARI.AllowUserToResizeColumns = false;

              
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
              
                int[,] resultMatrix = ds.Calculate(matrix);

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
            
        }
    }
}