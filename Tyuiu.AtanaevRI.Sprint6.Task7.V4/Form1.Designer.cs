namespace Tyuiu.AtanaevRI.Sprint6.Task7.V4
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panel2 = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            groupBoxInPut = new GroupBox();
            dataGridViewIn = new DataGridView();
            panel4 = new Panel();
            groupBoxOutPut = new GroupBox();
            dataGridViewOut = new DataGridView();
            splitter2 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel4.SuspendLayout();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 128);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(920, 18);
            buttonHelp.Margin = new Padding(4, 5, 4, 5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(109, 100);
            buttonHelp.TabIndex = 0;
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(252, 18);
            buttonSave.Margin = new Padding(4, 5, 4, 5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(109, 100);
            buttonSave.TabIndex = 0;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_ARI_Click;
            buttonSave.MouseEnter += buttonSave_ARI_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(135, 18);
            buttonDone.Margin = new Padding(4, 5, 4, 5);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(109, 100);
            buttonDone.TabIndex = 0;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonStart_ARI_Click;
            buttonDone.MouseEnter += buttonStart_ARI_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(17, 18);
            buttonOpenFile.Margin = new Padding(4, 5, 4, 5);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(109, 100);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpen_ARI_Click;
            buttonOpenFile.MouseEnter += buttonOpen_ARI_MouseEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 128);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 135);
            panel2.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Margin = new Padding(4, 5, 4, 5);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(4, 5, 4, 5);
            groupBoxTask.Size = new Size(1045, 135);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(4, 25);
            textBoxTask.Margin = new Padding(4, 5, 4, 5);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1037, 105);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 263);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 369);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInPut);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(4, 263);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 369);
            panel3.TabIndex = 2;
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(dataGridViewIn);
            groupBoxInPut.Dock = DockStyle.Fill;
            groupBoxInPut.Location = new Point(0, 0);
            groupBoxInPut.Margin = new Padding(4, 5, 4, 5);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Padding = new Padding(4, 5, 4, 5);
            groupBoxInPut.Size = new Size(511, 369);
            groupBoxInPut.TabIndex = 0;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(4, 25);
            dataGridViewIn.Margin = new Padding(4, 5, 4, 5);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.ReadOnly = true;
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(503, 339);
            dataGridViewIn.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOutPut);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(515, 263);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 369);
            panel4.TabIndex = 3;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(dataGridViewOut);
            groupBoxOutPut.Dock = DockStyle.Fill;
            groupBoxOutPut.Location = new Point(0, 0);
            groupBoxOutPut.Margin = new Padding(4, 5, 4, 5);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Padding = new Padding(4, 5, 4, 5);
            groupBoxOutPut.Size = new Size(530, 369);
            groupBoxOutPut.TabIndex = 0;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(4, 25);
            dataGridViewOut.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.ReadOnly = true;
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(522, 339);
            dataGridViewOut.TabIndex = 0;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(515, 263);
            splitter2.Margin = new Padding(4, 5, 4, 5);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 369);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 632);
            Controls.Add(splitter2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1061, 667);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 4 | Атанаев Р.И.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxInPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel4.ResumeLayout(false);
            groupBoxOutPut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}