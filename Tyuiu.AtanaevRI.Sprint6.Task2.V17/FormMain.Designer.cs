namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxStart_ARI = new TextBox();
            labelUslovie_ARI = new Label();
            labelStart = new Label();
            label1 = new Label();
            textBoxStop_ARI = new TextBox();
            buttonStart_ARI = new Button();
            labelSpravka_ARI = new Label();
            labelUslovie2_ARI = new Label();
            labelConclusion_ARI = new Label();
            labelResult_ARI = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            ColumnFx_ARI = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxStart_ARI
            // 
            textBoxStart_ARI.Location = new Point(49, 383);
            textBoxStart_ARI.Name = "textBoxStart_ARI";
            textBoxStart_ARI.Size = new Size(125, 27);
            textBoxStart_ARI.TabIndex = 0;
            // 
            // labelUslovie_ARI
            // 
            labelUslovie_ARI.AutoSize = true;
            labelUslovie_ARI.Location = new Point(12, 23);
            labelUslovie_ARI.Name = "labelUslovie_ARI";
            labelUslovie_ARI.Size = new Size(67, 20);
            labelUslovie_ARI.TabIndex = 1;
            labelUslovie_ARI.Text = "Условие";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(62, 350);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 350);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "Конец шага";
            // 
            // textBoxStop_ARI
            // 
            textBoxStop_ARI.Location = new Point(192, 383);
            textBoxStop_ARI.Name = "textBoxStop_ARI";
            textBoxStop_ARI.Size = new Size(125, 27);
            textBoxStop_ARI.TabIndex = 4;
            // 
            // buttonStart_ARI
            // 
            buttonStart_ARI.Location = new Point(510, 383);
            buttonStart_ARI.Name = "buttonStart_ARI";
            buttonStart_ARI.Size = new Size(110, 38);
            buttonStart_ARI.TabIndex = 5;
            buttonStart_ARI.Text = "Выполнить";
            buttonStart_ARI.UseVisualStyleBackColor = true;
            buttonStart_ARI.Click += buttonStart_ARI_Click;
            // 
            // labelSpravka_ARI
            // 
            labelSpravka_ARI.AutoSize = true;
            labelSpravka_ARI.Location = new Point(423, 390);
            labelSpravka_ARI.Name = "labelSpravka_ARI";
            labelSpravka_ARI.Size = new Size(67, 20);
            labelSpravka_ARI.TabIndex = 6;
            labelSpravka_ARI.Text = "Справка";
            // 
            // labelUslovie2_ARI
            // 
            labelUslovie2_ARI.AutoSize = true;
            labelUslovie2_ARI.Location = new Point(12, 55);
            labelUslovie2_ARI.Name = "labelUslovie2_ARI";
            labelUslovie2_ARI.Size = new Size(453, 40);
            labelUslovie2_ARI.TabIndex = 7;
            labelUslovie2_ARI.Text = "Протабулировать функцию sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            // 
            // labelConclusion_ARI
            // 
            labelConclusion_ARI.AutoSize = true;
            labelConclusion_ARI.Location = new Point(556, 23);
            labelConclusion_ARI.Name = "labelConclusion_ARI";
            labelConclusion_ARI.Size = new Size(110, 20);
            labelConclusion_ARI.TabIndex = 8;
            labelConclusion_ARI.Text = "Вывод данных";
            // 
            // labelResult_ARI
            // 
            labelResult_ARI.AutoSize = true;
            labelResult_ARI.Location = new Point(568, 55);
            labelResult_ARI.Name = "labelResult_ARI";
            labelResult_ARI.Size = new Size(78, 20);
            labelResult_ARI.TabIndex = 9;
            labelResult_ARI.Text = "Результат:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, ColumnFx_ARI });
            dataGridView1.Location = new Point(721, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 10;
            // 
            // X
            // 
            X.Frozen = true;
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 125;
            // 
            // ColumnFx_ARI
            // 
            ColumnFx_ARI.Frozen = true;
            ColumnFx_ARI.HeaderText = "F(x)";
            ColumnFx_ARI.MinimumWidth = 6;
            ColumnFx_ARI.Name = "ColumnFx_ARI";
            ColumnFx_ARI.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelResult_ARI);
            Controls.Add(labelConclusion_ARI);
            Controls.Add(labelUslovie2_ARI);
            Controls.Add(labelSpravka_ARI);
            Controls.Add(buttonStart_ARI);
            Controls.Add(textBoxStop_ARI);
            Controls.Add(label1);
            Controls.Add(labelStart);
            Controls.Add(labelUslovie_ARI);
            Controls.Add(textBoxStart_ARI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Атанаев Р.И  ";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart_ARI;
        private Label labelUslovie_ARI;
        private Label labelStart;
        private Label label1;
        private TextBox textBoxStop_ARI;
        private Button buttonStart_ARI;
        private Label labelSpravka_ARI;
        private Label labelUslovie2_ARI;
        private Label labelConclusion_ARI;
        private Label labelResult_ARI;
        private FileSystemWatcher fileSystemWatcher1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn ColumnFx_ARI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
