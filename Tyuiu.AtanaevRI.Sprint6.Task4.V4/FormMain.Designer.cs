namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonCalculateFunction_ARI = new Button();
            buttonHelpInfo_ARI = new Button();
            textBoxResult_ARI = new TextBox();
            labelTitle_ARI = new Label();
            labelFunction_ARI = new Label();
            chartFunction_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartFunction_ARI).BeginInit();
            SuspendLayout();
            // 
            // buttonCalculateFunction_ARI
            // 
            buttonCalculateFunction_ARI.BackColor = Color.SteelBlue;
            buttonCalculateFunction_ARI.FlatStyle = FlatStyle.Flat;
            buttonCalculateFunction_ARI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCalculateFunction_ARI.ForeColor = Color.White;
            buttonCalculateFunction_ARI.Location = new Point(16, 185);
            buttonCalculateFunction_ARI.Margin = new Padding(4, 5, 4, 5);
            buttonCalculateFunction_ARI.Name = "buttonCalculateFunction_ARI";
            buttonCalculateFunction_ARI.Size = new Size(267, 62);
            buttonCalculateFunction_ARI.TabIndex = 0;
            buttonCalculateFunction_ARI.Text = "Вычислить и сохранить";
            buttonCalculateFunction_ARI.UseVisualStyleBackColor = false;
            buttonCalculateFunction_ARI.Click += buttonCalculateFunction_ARI_Click;
            // 
            // buttonHelpInfo_ARI
            // 
            buttonHelpInfo_ARI.BackColor = Color.LightGray;
            buttonHelpInfo_ARI.FlatStyle = FlatStyle.Flat;
            buttonHelpInfo_ARI.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelpInfo_ARI.Location = new Point(16, 255);
            buttonHelpInfo_ARI.Margin = new Padding(4, 5, 4, 5);
            buttonHelpInfo_ARI.Name = "buttonHelpInfo_ARI";
            buttonHelpInfo_ARI.Size = new Size(267, 46);
            buttonHelpInfo_ARI.TabIndex = 1;
            buttonHelpInfo_ARI.Text = "Справка";
            buttonHelpInfo_ARI.UseVisualStyleBackColor = false;
            buttonHelpInfo_ARI.Click += buttonHelpInfo_ARI_Click;
            // 
            // textBoxResult_ARI
            // 
            textBoxResult_ARI.BackColor = Color.White;
            textBoxResult_ARI.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ARI.Location = new Point(291, 185);
            textBoxResult_ARI.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_ARI.Multiline = true;
            textBoxResult_ARI.Name = "textBoxResult_ARI";
            textBoxResult_ARI.ReadOnly = true;
            textBoxResult_ARI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ARI.Size = new Size(465, 536);
            textBoxResult_ARI.TabIndex = 2;
            // 
            // labelTitle_ARI
            // 
            labelTitle_ARI.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_ARI.Location = new Point(16, 14);
            labelTitle_ARI.Margin = new Padding(4, 0, 4, 0);
            labelTitle_ARI.Name = "labelTitle_ARI";
            labelTitle_ARI.Size = new Size(1035, 46);
            labelTitle_ARI.TabIndex = 3;
            labelTitle_ARI.Text = "Табулирование функции F(x) = (2x+6)/(cos(x)+x) - 3";
            labelTitle_ARI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFunction_ARI
            // 
            labelFunction_ARI.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFunction_ARI.Location = new Point(16, 69);
            labelFunction_ARI.Margin = new Padding(4, 0, 4, 0);
            labelFunction_ARI.Name = "labelFunction_ARI";
            labelFunction_ARI.Size = new Size(1035, 62);
            labelFunction_ARI.TabIndex = 4;
            labelFunction_ARI.Text = "Диапазон: [-5; 5], шаг: 1\r\nПроверка деления на ноль (при делении на ноль функция возвращает 0)";
            labelFunction_ARI.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartFunction_ARI
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_ARI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_ARI.Legends.Add(legend1);
            chartFunction_ARI.Location = new Point(765, 185);
            chartFunction_ARI.Margin = new Padding(4, 5, 4, 5);
            chartFunction_ARI.Name = "chartFunction_ARI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            chartFunction_ARI.Series.Add(series1);
            chartFunction_ARI.Size = new Size(531, 538);
            chartFunction_ARI.TabIndex = 5;
            chartFunction_ARI.Text = "График функции";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 786);
            Controls.Add(chartFunction_ARI);
            Controls.Add(labelFunction_ARI);
            Controls.Add(labelTitle_ARI);
            Controls.Add(textBoxResult_ARI);
            Controls.Add(buttonHelpInfo_ARI);
            Controls.Add(buttonCalculateFunction_ARI);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1327, 821);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 4 | Атанаев Р.И. | РППБ-25-1";
            ((System.ComponentModel.ISupportInitialize)chartFunction_ARI).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculateFunction_ARI;
        private System.Windows.Forms.Button buttonHelpInfo_ARI;
        private System.Windows.Forms.TextBox textBoxResult_ARI;
        private System.Windows.Forms.Label labelTitle_ARI;
        private System.Windows.Forms.Label labelFunction_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ARI;
    }
}