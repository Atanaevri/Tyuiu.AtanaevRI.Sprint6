
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_BYV = new Button();
            buttonFile_BYV = new Button();
            buttonFileExpress_BYV = new Button();
            panel2 = new Panel();
            groupBoxTask_BYV = new GroupBox();
            textBoxUslovie_BYV = new TextBox();
            panel3 = new Panel();
            groupBoxInput_BYV = new GroupBox();
            textBoxInputData_BYV = new TextBox();
            panel4 = new Panel();
            groupBoxOutput_BYV = new GroupBox();
            textBoxOutputData_BYV = new TextBox();
            openFileDialogTask_BYV = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_BYV.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInput_BYV.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxOutput_BYV.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_BYV);
            panel1.Controls.Add(buttonFile_BYV);
            panel1.Controls.Add(buttonFileExpress_BYV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 69);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.Dock = DockStyle.Right;
           
            buttonHelp_BYV.Location = new Point(712, 0);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(75, 69);
            buttonHelp_BYV.TabIndex = 2;
            toolTip1.SetToolTip(buttonHelp_BYV, "Информация о программе ");
            buttonHelp_BYV.UseVisualStyleBackColor = true;
            //buttonHelp_BYV.Click += buttonHelp_BYV_Click;
            // 
            // buttonFile_BYV
            // 
           
            buttonFile_BYV.Location = new Point(102, 3);
            buttonFile_BYV.Name = "buttonFile_BYV";
            buttonFile_BYV.Size = new Size(75, 63);
            buttonFile_BYV.TabIndex = 1;
            toolTip1.SetToolTip(buttonFile_BYV, "Производит поиск в фале вхождений сиволов \"z\"");
            buttonFile_BYV.UseVisualStyleBackColor = true;
            //buttonFile_BYV.Click += buttonFile_BYV_Click;
            // 
            // buttonFileExpress_BYV
            // 
           
            buttonFileExpress_BYV.Location = new Point(12, 3);
            buttonFileExpress_BYV.Name = "buttonFileExpress_BYV";
            buttonFileExpress_BYV.Size = new Size(75, 63);
            buttonFileExpress_BYV.TabIndex = 0;
            toolTip1.SetToolTip(buttonFileExpress_BYV, "Открыть файл");
            buttonFileExpress_BYV.UseVisualStyleBackColor = true;
            //buttonFileExpress_BYV.Click += buttonFileExpress_BYV_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_BYV);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 75);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.Controls.Add(textBoxUslovie_BYV);
            groupBoxTask_BYV.Dock = DockStyle.Fill;
            groupBoxTask_BYV.Location = new Point(0, 0);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(787, 75);
            groupBoxTask_BYV.TabIndex = 0;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие";
            // 
            // textBoxUslovie_BYV
            // 
            textBoxUslovie_BYV.BackColor = SystemColors.Control;
            textBoxUslovie_BYV.BorderStyle = BorderStyle.None;
            textBoxUslovie_BYV.Dock = DockStyle.Fill;
            textBoxUslovie_BYV.Location = new Point(3, 19);
            textBoxUslovie_BYV.Multiline = true;
            textBoxUslovie_BYV.Name = "textBoxUslovie_BYV";
            textBoxUslovie_BYV.Size = new Size(781, 53);
            textBoxUslovie_BYV.TabIndex = 0;
            textBoxUslovie_BYV.Text = resources.GetString("textBoxUslovie_BYV.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInput_BYV);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 365);
            panel3.TabIndex = 2;
            // 
            // groupBoxInput_BYV
            // 
            groupBoxInput_BYV.Controls.Add(textBoxInputData_BYV);
            groupBoxInput_BYV.Dock = DockStyle.Fill;
            groupBoxInput_BYV.Location = new Point(0, 0);
            groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            groupBoxInput_BYV.Size = new Size(363, 365);
            groupBoxInput_BYV.TabIndex = 0;
            groupBoxInput_BYV.TabStop = false;
            groupBoxInput_BYV.Text = "Ввод:";
            // 
            // textBoxInputData_BYV
            // 
            textBoxInputData_BYV.Dock = DockStyle.Fill;
            textBoxInputData_BYV.Location = new Point(3, 19);
            textBoxInputData_BYV.Multiline = true;
            textBoxInputData_BYV.Name = "textBoxInputData_BYV";
            textBoxInputData_BYV.Size = new Size(357, 343);
            textBoxInputData_BYV.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOutput_BYV);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(363, 144);
            panel4.Name = "panel4";
            panel4.Size = new Size(424, 365);
            panel4.TabIndex = 3;
            // 
            // groupBoxOutput_BYV
            // 
            groupBoxOutput_BYV.Controls.Add(textBoxOutputData_BYV);
            groupBoxOutput_BYV.Dock = DockStyle.Fill;
            groupBoxOutput_BYV.Location = new Point(0, 0);
            groupBoxOutput_BYV.Name = "groupBoxOutput_BYV";
            groupBoxOutput_BYV.Size = new Size(424, 365);
            groupBoxOutput_BYV.TabIndex = 0;
            groupBoxOutput_BYV.TabStop = false;
            groupBoxOutput_BYV.Text = "Вывод:";
            // 
            // textBoxOutputData_BYV
            // 
            textBoxOutputData_BYV.Dock = DockStyle.Fill;
            textBoxOutputData_BYV.Location = new Point(3, 19);
            textBoxOutputData_BYV.Multiline = true;
            textBoxOutputData_BYV.Name = "textBoxOutputData_BYV";
            textBoxOutputData_BYV.Size = new Size(418, 343);
            textBoxOutputData_BYV.TabIndex = 0;
            // 
            // openFileDialogTask_BYV
            // 
            openFileDialogTask_BYV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 509);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(803, 548);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Бушля Я. В.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxInput_BYV.ResumeLayout(false);
            groupBoxInput_BYV.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxOutput_BYV.ResumeLayout(false);
            groupBoxOutput_BYV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_BYV;
        private Button buttonFile_BYV;
        private Button buttonFileExpress_BYV;
        private Panel panel2;
        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxUslovie_BYV;
        private Panel panel3;
        private GroupBox groupBoxInput_BYV;
        private TextBox textBoxInputData_BYV;
        private Panel panel4;
        private GroupBox groupBoxOutput_BYV;
        private TextBox textBoxOutputData_BYV;
        private OpenFileDialog openFileDialogTask_BYV;
        private ToolTip toolTip1;
    }
}
