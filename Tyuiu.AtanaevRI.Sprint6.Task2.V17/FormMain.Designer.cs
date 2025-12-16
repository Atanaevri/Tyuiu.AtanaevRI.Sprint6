namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInput_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxStop_ARI = new System.Windows.Forms.TextBox();
            this.labelStop_ARI = new System.Windows.Forms.Label();
            this.textBoxStart_ARI = new System.Windows.Forms.TextBox();
            this.labelStart_ARI = new System.Windows.Forms.Label();
            this.groupBoxOutput_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxGraph_ARI = new System.Windows.Forms.GroupBox();
            this.chartFunction_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.groupBoxInput_ARI.SuspendLayout();
            this.groupBoxOutput_ARI.SuspendLayout();
            this.groupBoxGraph_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).BeginInit();
            this.SuspendLayout();

            this.groupBoxInput_ARI.Controls.Add(this.textBoxStop_ARI);
            this.groupBoxInput_ARI.Controls.Add(this.labelStop_ARI);
            this.groupBoxInput_ARI.Controls.Add(this.textBoxStart_ARI);
            this.groupBoxInput_ARI.Controls.Add(this.labelStart_ARI);
            this.groupBoxInput_ARI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput_ARI.Name = "groupBoxInput_ARI";
            this.groupBoxInput_ARI.Size = new System.Drawing.Size(300, 80);
            this.groupBoxInput_ARI.TabIndex = 0;
            this.groupBoxInput_ARI.TabStop = false;
            this.groupBoxInput_ARI.Text = "Ввод данных";

            this.textBoxStop_ARI.Location = new System.Drawing.Point(200, 35);
            this.textBoxStop_ARI.Name = "textBoxStop_ARI";
            this.textBoxStop_ARI.Size = new System.Drawing.Size(80, 20);
            this.textBoxStop_ARI.TabIndex = 3;
            this.textBoxStop_ARI.Text = "5";

            this.labelStop_ARI.AutoSize = true;
            this.labelStop_ARI.Location = new System.Drawing.Point(150, 38);
            this.labelStop_ARI.Name = "labelStop_ARI";
            this.labelStop_ARI.Size = new System.Drawing.Size(44, 13);
            this.labelStop_ARI.TabIndex = 2;
            this.labelStop_ARI.Text = "Конец:";

            this.textBoxStart_ARI.Location = new System.Drawing.Point(50, 35);
            this.textBoxStart_ARI.Name = "textBoxStart_ARI";
            this.textBoxStart_ARI.Size = new System.Drawing.Size(80, 20);
            this.textBoxStart_ARI.TabIndex = 1;
            this.textBoxStart_ARI.Text = "-5";

            this.labelStart_ARI.AutoSize = true;
            this.labelStart_ARI.Location = new System.Drawing.Point(6, 38);
            this.labelStart_ARI.Name = "labelStart_ARI";
            this.labelStart_ARI.Size = new System.Drawing.Size(49, 13);
            this.labelStart_ARI.TabIndex = 0;
            this.labelStart_ARI.Text = "Старт:";

            this.groupBoxOutput_ARI.Controls.Add(this.textBoxResult_ARI);
            this.groupBoxOutput_ARI.Location = new System.Drawing.Point(12, 100);
            this.groupBoxOutput_ARI.Name = "groupBoxOutput_ARI";
            this.groupBoxOutput_ARI.Size = new System.Drawing.Size(300, 200);
            this.groupBoxOutput_ARI.TabIndex = 1;
            this.groupBoxOutput_ARI.TabStop = false;
            this.groupBoxOutput_ARI.Text = "Вывод данных";

            this.textBoxResult_ARI.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_ARI.Multiline = true;
            this.textBoxResult_ARI.Name = "textBoxResult_ARI";
            this.textBoxResult_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ARI.Size = new System.Drawing.Size(288, 175);
            this.textBoxResult_ARI.TabIndex = 0;

            this.groupBoxGraph_ARI.Controls.Add(this.chartFunction_ARI);
            this.groupBoxGraph_ARI.Location = new System.Drawing.Point(320, 12);
            this.groupBoxGraph_ARI.Name = "groupBoxGraph_ARI";
            this.groupBoxGraph_ARI.Size = new System.Drawing.Size(400, 350);
            this.groupBoxGraph_ARI.TabIndex = 2;
            this.groupBoxGraph_ARI.TabStop = false;
            this.groupBoxGraph_ARI.Text = "График";

            chartArea1.Name = "ChartArea1";
            this.chartFunction_ARI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_ARI.Legends.Add(legend1);
            this.chartFunction_ARI.Location = new System.Drawing.Point(6, 19);
            this.chartFunction_ARI.Name = "chartFunction_ARI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ARI.Series.Add(series1);
            this.chartFunction_ARI.Size = new System.Drawing.Size(388, 325);
            this.chartFunction_ARI.TabIndex = 0;
            this.chartFunction_ARI.Text = "chart1";

            this.buttonDone_ARI.Location = new System.Drawing.Point(12, 310);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(100, 30);
            this.buttonDone_ARI.TabIndex = 3;
            this.buttonDone_ARI.Text = "Выполнить";
            this.buttonDone_ARI.UseVisualStyleBackColor = true;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);

            this.buttonHelp_ARI.Location = new System.Drawing.Point(120, 310);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp_ARI.TabIndex = 4;
            this.buttonHelp_ARI.Text = "Справка";
            this.buttonHelp_ARI.UseVisualStyleBackColor = true;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 371);
            this.Controls.Add(this.buttonHelp_ARI);
            this.Controls.Add(this.buttonDone_ARI);
            this.Controls.Add(this.groupBoxGraph_ARI);
            this.Controls.Add(this.groupBoxOutput_ARI);
            this.Controls.Add(this.groupBoxInput_ARI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 17 | Атанаев Р.И. | РППБ-25-1";
            this.groupBoxInput_ARI.ResumeLayout(false);
            this.groupBoxInput_ARI.PerformLayout();
            this.groupBoxOutput_ARI.ResumeLayout(false);
            this.groupBoxOutput_ARI.PerformLayout();
            this.groupBoxGraph_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxInput_ARI;
        private System.Windows.Forms.GroupBox groupBoxOutput_ARI;
        private System.Windows.Forms.GroupBox groupBoxGraph_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.TextBox textBoxStart_ARI;
        private System.Windows.Forms.Label labelStart_ARI;
        private System.Windows.Forms.TextBox textBoxStop_ARI;
        private System.Windows.Forms.Label labelStop_ARI;
        private System.Windows.Forms.TextBox textBoxResult_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ARI;
    }
}