namespace Tyuiu.AtanaevRI.Sprint6.Task6.V8
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonOpenFile_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.Button buttonClear_ARI;
        private System.Windows.Forms.Button buttonCreateTestFile_ARI;
        private System.Windows.Forms.TextBox textBoxIn_ARI;
        private System.Windows.Forms.TextBox textBoxOut_ARI;
        private System.Windows.Forms.Label labelTitle_ARI;
        private System.Windows.Forms.Label labelFilePath_ARI;
        private System.Windows.Forms.Label labelInput_ARI;
        private System.Windows.Forms.Label labelOutput_ARI;
        private System.Windows.Forms.Label labelInputCount_ARI;
        private System.Windows.Forms.Label labelOutputCount_ARI;
        private System.Windows.Forms.Panel panelButtons_ARI;
        private System.Windows.Forms.Panel panelInput_ARI;
        private System.Windows.Forms.Panel panelOutput_ARI;

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
            this.buttonOpenFile_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.buttonClear_ARI = new System.Windows.Forms.Button();
            this.buttonCreateTestFile_ARI = new System.Windows.Forms.Button();
            this.textBoxIn_ARI = new System.Windows.Forms.TextBox();
            this.textBoxOut_ARI = new System.Windows.Forms.TextBox();
            this.labelTitle_ARI = new System.Windows.Forms.Label();
            this.labelFilePath_ARI = new System.Windows.Forms.Label();
            this.labelInput_ARI = new System.Windows.Forms.Label();
            this.labelOutput_ARI = new System.Windows.Forms.Label();
            this.labelInputCount_ARI = new System.Windows.Forms.Label();
            this.labelOutputCount_ARI = new System.Windows.Forms.Label();
            this.panelButtons_ARI = new System.Windows.Forms.Panel();
            this.panelInput_ARI = new System.Windows.Forms.Panel();
            this.panelOutput_ARI = new System.Windows.Forms.Panel();
            this.panelButtons_ARI.SuspendLayout();
            this.panelInput_ARI.SuspendLayout();
            this.panelOutput_ARI.SuspendLayout();
            this.SuspendLayout();

            // buttonOpenFile_ARI
            this.buttonOpenFile_ARI.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFile_ARI.Location = new System.Drawing.Point(10, 10);
            this.buttonOpenFile_ARI.Name = "buttonOpenFile_ARI";
            this.buttonOpenFile_ARI.Size = new System.Drawing.Size(180, 40);
            this.buttonOpenFile_ARI.TabIndex = 0;
            this.buttonOpenFile_ARI.Text = "Открыть файл";
            this.buttonOpenFile_ARI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ARI.Click += new System.EventHandler(this.buttonOpenFile_ARI_Click);

            // buttonHelp_ARI
            this.buttonHelp_ARI.BackColor = System.Drawing.Color.LightGray;
            this.buttonHelp_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHelp_ARI.Location = new System.Drawing.Point(10, 60);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(180, 30);
            this.buttonHelp_ARI.TabIndex = 1;
            this.buttonHelp_ARI.Text = "Справка";
            this.buttonHelp_ARI.UseVisualStyleBackColor = false;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);

            // buttonClear_ARI
            this.buttonClear_ARI.BackColor = System.Drawing.Color.Orange;
            this.buttonClear_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.buttonClear_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonClear_ARI.Location = new System.Drawing.Point(10, 100);
            this.buttonClear_ARI.Name = "buttonClear_ARI";
            this.buttonClear_ARI.Size = new System.Drawing.Size(180, 30);
            this.buttonClear_ARI.TabIndex = 2;
            this.buttonClear_ARI.Text = "Очистить все";
            this.buttonClear_ARI.UseVisualStyleBackColor = false;
            this.buttonClear_ARI.Click += new System.EventHandler(this.buttonClear_ARI_Click);

            // buttonCreateTestFile_ARI
            this.buttonCreateTestFile_ARI.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCreateTestFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTestFile_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCreateTestFile_ARI.ForeColor = System.Drawing.Color.White;
            this.buttonCreateTestFile_ARI.Location = new System.Drawing.Point(10, 140);
            this.buttonCreateTestFile_ARI.Name = "buttonCreateTestFile_ARI";
            this.buttonCreateTestFile_ARI.Size = new System.Drawing.Size(180, 30);
            this.buttonCreateTestFile_ARI.TabIndex = 3;
            this.buttonCreateTestFile_ARI.Text = "Создать тестовый файл";
            this.buttonCreateTestFile_ARI.UseVisualStyleBackColor = false;
            this.buttonCreateTestFile_ARI.Click += new System.EventHandler(this.buttonCreateTestFile_ARI_Click);

            // textBoxIn_ARI
            this.textBoxIn_ARI.BackColor = System.Drawing.Color.White;
            this.textBoxIn_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_ARI.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxIn_ARI.Location = new System.Drawing.Point(0, 20);
            this.textBoxIn_ARI.Multiline = true;
            this.textBoxIn_ARI.Name = "textBoxIn_ARI";
            this.textBoxIn_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIn_ARI.Size = new System.Drawing.Size(300, 380);
            this.textBoxIn_ARI.TabIndex = 4;
            this.textBoxIn_ARI.WordWrap = true;
            this.textBoxIn_ARI.TextChanged += new System.EventHandler(this.textBoxIn_ARI_TextChanged);

            // textBoxOut_ARI
            this.textBoxOut_ARI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_ARI.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxOut_ARI.Location = new System.Drawing.Point(0, 20);
            this.textBoxOut_ARI.Multiline = true;
            this.textBoxOut_ARI.Name = "textBoxOut_ARI";
            this.textBoxOut_ARI.ReadOnly = true;
            this.textBoxOut_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOut_ARI.Size = new System.Drawing.Size(300, 380);
            this.textBoxOut_ARI.TabIndex = 5;
            this.textBoxOut_ARI.WordWrap = true;

            // labelTitle_ARI
            this.labelTitle_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle_ARI.Location = new System.Drawing.Point(0, 0);
            this.labelTitle_ARI.Name = "labelTitle_ARI";
            this.labelTitle_ARI.Size = new System.Drawing.Size(884, 40);
            this.labelTitle_ARI.TabIndex = 6;
            this.labelTitle_ARI.Text = "Поиск слов, содержащих букву 'z'";
            this.labelTitle_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelFilePath_ARI
            this.labelFilePath_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelFilePath_ARI.Location = new System.Drawing.Point(10, 180);
            this.labelFilePath_ARI.Name = "labelFilePath_ARI";
            this.labelFilePath_ARI.Size = new System.Drawing.Size(180, 50);
            this.labelFilePath_ARI.TabIndex = 7;
            this.labelFilePath_ARI.Text = "Файл: не выбран";
            this.labelFilePath_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // labelInput_ARI
            this.labelInput_ARI.BackColor = System.Drawing.Color.SteelBlue;
            this.labelInput_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInput_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelInput_ARI.ForeColor = System.Drawing.Color.White;
            this.labelInput_ARI.Location = new System.Drawing.Point(0, 0);
            this.labelInput_ARI.Name = "labelInput_ARI";
            this.labelInput_ARI.Size = new System.Drawing.Size(300, 20);
            this.labelInput_ARI.TabIndex = 8;
            this.labelInput_ARI.Text = "Исходный текст из файла";
            this.labelInput_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelOutput_ARI
            this.labelOutput_ARI.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelOutput_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOutput_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelOutput_ARI.ForeColor = System.Drawing.Color.White;
            this.labelOutput_ARI.Location = new System.Drawing.Point(0, 0);
            this.labelOutput_ARI.Name = "labelOutput_ARI";
            this.labelOutput_ARI.Size = new System.Drawing.Size(300, 20);
            this.labelOutput_ARI.TabIndex = 9;
            this.labelOutput_ARI.Text = "Слова содержащие 'z'";
            this.labelOutput_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelInputCount_ARI
            this.labelInputCount_ARI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelInputCount_ARI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInputCount_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelInputCount_ARI.Location = new System.Drawing.Point(0, 400);
            this.labelInputCount_ARI.Name = "labelInputCount_ARI";
            this.labelInputCount_ARI.Size = new System.Drawing.Size(300, 20);
            this.labelInputCount_ARI.TabIndex = 10;
            this.labelInputCount_ARI.Text = "Всего слов: 0";
            this.labelInputCount_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // labelOutputCount_ARI
            this.labelOutputCount_ARI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelOutputCount_ARI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOutputCount_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelOutputCount_ARI.Location = new System.Drawing.Point(0, 400);
            this.labelOutputCount_ARI.Name = "labelOutputCount_ARI";
            this.labelOutputCount_ARI.Size = new System.Drawing.Size(300, 20);
            this.labelOutputCount_ARI.TabIndex = 11;
            this.labelOutputCount_ARI.Text = "Слов с 'z': 0";
            this.labelOutputCount_ARI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelButtons_ARI
            this.panelButtons_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_ARI.Controls.Add(this.buttonOpenFile_ARI);
            this.panelButtons_ARI.Controls.Add(this.buttonHelp_ARI);
            this.panelButtons_ARI.Controls.Add(this.buttonClear_ARI);
            this.panelButtons_ARI.Controls.Add(this.buttonCreateTestFile_ARI);
            this.panelButtons_ARI.Controls.Add(this.labelFilePath_ARI);
            this.panelButtons_ARI.Location = new System.Drawing.Point(12, 50);
            this.panelButtons_ARI.Name = "panelButtons_ARI";
            this.panelButtons_ARI.Size = new System.Drawing.Size(200, 400);
            this.panelButtons_ARI.TabIndex = 12;

            // panelInput_ARI
            this.panelInput_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput_ARI.Controls.Add(this.textBoxIn_ARI);
            this.panelInput_ARI.Controls.Add(this.labelInput_ARI);
            this.panelInput_ARI.Controls.Add(this.labelInputCount_ARI);
            this.panelInput_ARI.Location = new System.Drawing.Point(218, 50);
            this.panelInput_ARI.Name = "panelInput_ARI";
            this.panelInput_ARI.Size = new System.Drawing.Size(302, 422);
            this.panelInput_ARI.TabIndex = 13;

            // panelOutput_ARI
            this.panelOutput_ARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOutput_ARI.Controls.Add(this.textBoxOut_ARI);
            this.panelOutput_ARI.Controls.Add(this.labelOutput_ARI);
            this.panelOutput_ARI.Controls.Add(this.labelOutputCount_ARI);
            this.panelOutput_ARI.Location = new System.Drawing.Point(526, 50);
            this.panelOutput_ARI.Name = "panelOutput_ARI";
            this.panelOutput_ARI.Size = new System.Drawing.Size(302, 422);
            this.panelOutput_ARI.TabIndex = 14;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 484);
            this.Controls.Add(this.panelOutput_ARI);
            this.Controls.Add(this.panelInput_ARI);
            this.Controls.Add(this.panelButtons_ARI);
            this.Controls.Add(this.labelTitle_ARI);
            this.MinimumSize = new System.Drawing.Size(858, 531);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 8 | Атанаев Р.И. | РППБ-25-1";
            this.panelButtons_ARI.ResumeLayout(false);
            this.panelInput_ARI.ResumeLayout(false);
            this.panelInput_ARI.PerformLayout();
            this.panelOutput_ARI.ResumeLayout(false);
            this.panelOutput_ARI.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}