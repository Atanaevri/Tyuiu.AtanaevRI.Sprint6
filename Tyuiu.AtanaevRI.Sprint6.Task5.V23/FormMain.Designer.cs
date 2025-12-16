namespace Tyuiu.AtanaevRI.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOpenFile_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.buttonSaveResult_ARI = new System.Windows.Forms.Button();
            this.buttonGenerateTestFile_ARI = new System.Windows.Forms.Button();
            this.dataGridViewNumbers_ARI = new System.Windows.Forms.DataGridView();
            this.textBoxFilePath_ARI = new System.Windows.Forms.TextBox();
            this.labelTitle_ARI = new System.Windows.Forms.Label();
            this.labelFilePath_ARI = new System.Windows.Forms.Label();
            this.labelTotalCount_ARI = new System.Windows.Forms.Label();
            this.labelNegativeCount_ARI = new System.Windows.Forms.Label();
            this.panelLeft_ARI = new System.Windows.Forms.Panel();
            this.panelCenter_ARI = new System.Windows.Forms.Panel();
            this.panelRight_ARI = new System.Windows.Forms.Panel();
            this.chartNegative_ARI = new global::System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers_ARI)).BeginInit();
            this.panelLeft_ARI.SuspendLayout();
            this.panelCenter_ARI.SuspendLayout();
            this.panelRight_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNegative_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile_ARI
            // 
            this.buttonOpenFile_ARI.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile_ARI.Location = new System.Drawing.Point(10, 10);
            this.buttonOpenFile_ARI.Name = "buttonOpenFile_ARI";
            this.buttonOpenFile_ARI.Size = new System.Drawing.Size(180, 40);
            this.buttonOpenFile_ARI.TabIndex = 0;
            this.buttonOpenFile_ARI.Text = "Открыть файл";
            this.buttonOpenFile_ARI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ARI.Click += new System.EventHandler(this.buttonOpenFile_ARI_Click);
            // 
            // buttonHelp_ARI
            // 
            this.buttonHelp_ARI.BackColor = System.Drawing.Color.LightGray;
            this.buttonHelp_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_ARI.Location = new System.Drawing.Point(10, 60);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(180, 30);
            this.buttonHelp_ARI.TabIndex = 1;
            this.buttonHelp_ARI.Text = "Справка";
            this.buttonHelp_ARI.UseVisualStyleBackColor = false;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);
            // 
            // buttonSaveResult_ARI
            // 
            this.buttonSaveResult_ARI.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonSaveResult_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveResult_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveResult_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonSaveResult_ARI.Location = new System.Drawing.Point(10, 100);
            this.buttonSaveResult_ARI.Name = "buttonSaveResult_ARI";
            this.buttonSaveResult_ARI.Size = new System.Drawing.Size(180, 40);
            this.buttonSaveResult_ARI.TabIndex = 2;
            this.buttonSaveResult_ARI.Text = "Сохранить результат";
            this.buttonSaveResult_ARI.UseVisualStyleBackColor = false;
            this.buttonSaveResult_ARI.Click += new System.EventHandler(this.buttonSaveResult_ARI_Click);
            // 
            // buttonGenerateTestFile_ARI
            // 
            this.buttonGenerateTestFile_ARI.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonGenerateTestFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateTestFile_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerateTestFile_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateTestFile_ARI.Location = new System.Drawing.Point(10, 150);
            this.buttonGenerateTestFile_ARI.Name = "buttonGenerateTestFile_ARI";
            this.buttonGenerateTestFile_ARI.Size = new System.Drawing.Size(180, 30);
            this.buttonGenerateTestFile_ARI.TabIndex = 3;
            this.buttonGenerateTestFile_ARI.Text = "Создать тестовый файл";
            this.buttonGenerateTestFile_ARI.UseVisualStyleBackColor = false;
            this.buttonGenerateTestFile_ARI.Click += new System.EventHandler(this.buttonGenerateTestFile_ARI_Click);
            // 
            // dataGridViewNumbers_ARI
            // 
            this.dataGridViewNumbers_ARI.AllowUserToAddRows = false;
            this.dataGridViewNumbers_ARI.AllowUserToDeleteRows = false;
            this.dataGridViewNumbers_ARI.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumbers_ARI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNumbers_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumbers_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumbers_ARI.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewNumbers_ARI.Name = "dataGridViewNumbers_ARI";
            this.dataGridViewNumbers_ARI.ReadOnly = true;
            this.dataGridViewNumbers_ARI.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewNumbers_ARI.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNumbers_ARI.RowTemplate.Height = 24;
            this.dataGridViewNumbers_ARI.Size = new System.Drawing.Size(300, 350);
            this.dataGridViewNumbers_ARI.TabIndex = 4;
            // 
            // textBoxFilePath_ARI
            // 
            this.textBoxFilePath_ARI.Location = new System.Drawing.Point(10, 240);
            this.textBoxFilePath_ARI.Multiline = true;
            this.textBoxFilePath_ARI.Name = "textBoxFilePath_ARI";
            this.textBoxFilePath_ARI.ReadOnly = true;
            this.textBoxFilePath_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFilePath_ARI.Size = new System.Drawing.Size(180, 100);
            this.textBoxFilePath_ARI.TabIndex = 5;
            // 
            // labelTitle_ARI
            // 
            this.labelTitle_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_ARI.Location = new System.Drawing.Point(0, 0);
            this.labelTitle_ARI.Name = "labelTitle_ARI";
            this.labelTitle_ARI.Size = new System.Drawing.Size(900, 40);
            this.labelTitle_ARI.TabIndex = 6;
            this.labelTitle_ARI.Text = "Анализ числовых данных из файла";
            this.labelTitle_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilePath_ARI
            // 
            this.labelFilePath_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath_ARI.Location = new System.Drawing.Point(10, 210);
            this.labelFilePath_ARI.Name = "labelFilePath_ARI";
            this.labelFilePath_ARI.Size = new System.Drawing.Size(180, 25);
            this.labelFilePath_ARI.TabIndex = 7;
            this.labelFilePath_ARI.Text = "Текущий файл:";
            this.labelFilePath_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalCount_ARI
            // 
            this.labelTotalCount_ARI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTotalCount_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalCount_ARI.Location = new System.Drawing.Point(0, 350);
            this.labelTotalCount_ARI.Name = "labelTotalCount_ARI";
            this.labelTotalCount_ARI.Size = new System.Drawing.Size(300, 25);
            this.labelTotalCount_ARI.TabIndex = 8;
            this.labelTotalCount_ARI.Text = "Всего чисел: 0";
            this.labelTotalCount_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNegativeCount_ARI
            // 
            this.labelNegativeCount_ARI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNegativeCount_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNegativeCount_ARI.Location = new System.Drawing.Point(0, 350);
            this.labelNegativeCount_ARI.Name = "labelNegativeCount_ARI";
            this.labelNegativeCount_ARI.Size = new System.Drawing.Size(300, 25);
            this.labelNegativeCount_ARI.TabIndex = 9;
            this.labelNegativeCount_ARI.Text = "Отрицательных чисел: 0";
            this.labelNegativeCount_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft_ARI
            // 
            this.panelLeft_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft_ARI.Controls.Add(this.buttonOpenFile_ARI);
            this.panelLeft_ARI.Controls.Add(this.buttonHelp_ARI);
            this.panelLeft_ARI.Controls.Add(this.buttonSaveResult_ARI);
            this.panelLeft_ARI.Controls.Add(this.buttonGenerateTestFile_ARI);
            this.panelLeft_ARI.Controls.Add(this.labelFilePath_ARI);
            this.panelLeft_ARI.Controls.Add(this.textBoxFilePath_ARI);
            this.panelLeft_ARI.Location = new System.Drawing.Point(12, 50);
            this.panelLeft_ARI.Name = "panelLeft_ARI";
            this.panelLeft_ARI.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_ARI.TabIndex = 10;
            // 
            // panelCenter_ARI
            // 
            this.panelCenter_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter_ARI.Controls.Add(this.dataGridViewNumbers_ARI);
            this.panelCenter_ARI.Controls.Add(this.labelTotalCount_ARI);
            this.panelCenter_ARI.Location = new System.Drawing.Point(218, 50);
            this.panelCenter_ARI.Name = "panelCenter_ARI";
            this.panelCenter_ARI.Size = new System.Drawing.Size(302, 377);
            this.panelCenter_ARI.TabIndex = 11;
            // 
            // panelRight_ARI
            // 
            this.panelRight_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight_ARI.Controls.Add(this.chartNegative_ARI);
            this.panelRight_ARI.Controls.Add(this.labelNegativeCount_ARI);
            this.panelRight_ARI.Location = new System.Drawing.Point(526, 50);
            this.panelRight_ARI.Name = "panelRight_ARI";
            this.panelRight_ARI.Size = new System.Drawing.Size(302, 377);
            this.panelRight_ARI.TabIndex = 12;
            // 
            // chartNegative_ARI
            // 
            this.chartNegative_ARI.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chartNegative_ARI.ChartAreas.Add(chartArea1);
            this.chartNegative_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartNegative_ARI.Legends.Add(legend1);
            this.chartNegative_ARI.Location = new System.Drawing.Point(0, 0);
            this.chartNegative_ARI.Name = "chartNegative_ARI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Отрицательные числа";
            this.chartNegative_ARI.Series.Add(series1);
            this.chartNegative_ARI.Size = new System.Drawing.Size(300, 350);
            this.chartNegative_ARI.TabIndex = 10;
            this.chartNegative_ARI.Text = "Диаграмма отрицательных чисел";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 439);
            this.Controls.Add(this.panelRight_ARI);
            this.Controls.Add(this.panelCenter_ARI);
            this.Controls.Add(this.panelLeft_ARI);
            this.Controls.Add(this.labelTitle_ARI);
            this.MinimumSize = new System.Drawing.Size(858, 486);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 23 | Атанаев Р.И. | РППБ-25-1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers_ARI)).EndInit();
            this.panelLeft_ARI.ResumeLayout(false);
            this.panelLeft_ARI.PerformLayout();
            this.panelCenter_ARI.ResumeLayout(false);
            this.panelRight_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNegative_ARI)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.Button buttonSaveResult_ARI;
        private System.Windows.Forms.Button buttonGenerateTestFile_ARI;
        private System.Windows.Forms.DataGridView dataGridViewNumbers_ARI;
        private System.Windows.Forms.TextBox textBoxFilePath_ARI;
        private System.Windows.Forms.Label labelTitle_ARI;
        private System.Windows.Forms.Label labelFilePath_ARI;
        private System.Windows.Forms.Label labelTotalCount_ARI;
        private System.Windows.Forms.Label labelNegativeCount_ARI;
        private System.Windows.Forms.Panel panelLeft_ARI;
        private System.Windows.Forms.Panel panelCenter_ARI;
        private System.Windows.Forms.Panel panelRight_ARI;
        private global::System.Windows.Forms.DataVisualization.Charting.Chart chartNegative_ARI;
    }
}