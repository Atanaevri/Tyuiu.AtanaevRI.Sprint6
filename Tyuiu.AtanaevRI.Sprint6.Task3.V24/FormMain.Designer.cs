namespace Tyuiu.AtanaevRI.Sprint6.Task3.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelUslovie_ARI = new Label();
            labelUslovie2_ARI = new Label();
            buttonStart_ARI = new Button();
            buttonHelp_ARI = new Button();
            textBoxRes_ARI = new TextBox();
            labelRes_ARI = new Label();
            labelConclusion_ARI = new Label();
            dataGridViewRes_ARI = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_ARI).BeginInit();
            SuspendLayout();
            // 
            // labelUslovie_ARI
            // 
            labelUslovie_ARI.AutoSize = true;
            labelUslovie_ARI.Location = new Point(0, 0);
            labelUslovie_ARI.Name = "labelUslovie_ARI";
            labelUslovie_ARI.Size = new Size(67, 20);
            labelUslovie_ARI.TabIndex = 0;
            labelUslovie_ARI.Text = "Условие";
            // 
            // labelUslovie2_ARI
            // 
            labelUslovie2_ARI.AutoSize = true;
            labelUslovie2_ARI.Location = new Point(17, 30);
            labelUslovie2_ARI.Name = "labelUslovie2_ARI";
            labelUslovie2_ARI.Size = new Size(361, 280);
            labelUslovie2_ARI.TabIndex = 1;
            labelUslovie2_ARI.Text = resources.GetString("labelUslovie2_ARI.Text");
            // 
            // buttonStart_ARI
            // 
            buttonStart_ARI.Location = new Point(770, 397);
            buttonStart_ARI.Name = "buttonStart_ARI";
            buttonStart_ARI.Size = new Size(119, 41);
            buttonStart_ARI.TabIndex = 2;
            buttonStart_ARI.Text = "Выполнить";
            buttonStart_ARI.UseVisualStyleBackColor = true;
            buttonStart_ARI.Click += buttonStart_ARI_Click;
            // 
            // buttonHelp_ARI
            // 
            buttonHelp_ARI.Location = new Point(707, 397);
            buttonHelp_ARI.Name = "buttonHelp_ARI";
            buttonHelp_ARI.Size = new Size(45, 38);
            buttonHelp_ARI.TabIndex = 3;
            buttonHelp_ARI.Text = "?";
            buttonHelp_ARI.UseVisualStyleBackColor = true;
            // 
            // textBoxRes_ARI
            // 
            textBoxRes_ARI.Location = new Point(770, 100);
            textBoxRes_ARI.Name = "textBoxRes_ARI";
            textBoxRes_ARI.Size = new Size(125, 27);
            textBoxRes_ARI.TabIndex = 4;
            // 
            // labelRes_ARI
            // 
            labelRes_ARI.AutoSize = true;
            labelRes_ARI.Location = new Point(785, 62);
            labelRes_ARI.Name = "labelRes_ARI";
            labelRes_ARI.Size = new Size(75, 20);
            labelRes_ARI.TabIndex = 5;
            labelRes_ARI.Text = "Результат";
            // 
            // labelConclusion_ARI
            // 
            labelConclusion_ARI.AutoSize = true;
            labelConclusion_ARI.Location = new Point(785, 30);
            labelConclusion_ARI.Name = "labelConclusion_ARI";
            labelConclusion_ARI.Size = new Size(110, 20);
            labelConclusion_ARI.TabIndex = 6;
            labelConclusion_ARI.Text = "Вывод данных";
            // 
            // dataGridViewRes_ARI
            // 
            dataGridViewRes_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_ARI.Location = new Point(404, 30);
            dataGridViewRes_ARI.Name = "dataGridViewRes_ARI";
            dataGridViewRes_ARI.RowHeadersWidth = 51;
            dataGridViewRes_ARI.Size = new Size(315, 335);
            dataGridViewRes_ARI.TabIndex = 7;
            
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 450);
            Controls.Add(dataGridViewRes_ARI);
            Controls.Add(labelConclusion_ARI);
            Controls.Add(labelRes_ARI);
            Controls.Add(textBoxRes_ARI);
            Controls.Add(buttonHelp_ARI);
            Controls.Add(buttonStart_ARI);
            Controls.Add(labelUslovie2_ARI);
            Controls.Add(labelUslovie_ARI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 24 | Атанаев Р.И";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_ARI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUslovie_ARI;
        private Label labelUslovie2_ARI;
        private Button buttonStart_ARI;
        private Button buttonHelp_ARI;
        private TextBox textBoxRes_ARI;
        private Label labelRes_ARI;
        private Label labelConclusion_ARI;
        private DataGridView dataGridViewRes_ARI;
    }
}
