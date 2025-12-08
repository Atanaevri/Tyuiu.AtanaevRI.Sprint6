namespace Tyuiu.AtanaevRI.Sprint6.Task1.V30
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
            buttonStart_ARI = new Button();
            labelUslovie_ARI = new Label();
            pictureBox1 = new PictureBox();
            labelСonclusion_ARI = new Label();
            labelStart_ARI = new Label();
            labelResultat_ARI = new Label();
            labelVvod_ARI = new Label();
            labelStop_ARI = new Label();
            textBoxStart_ARI = new TextBox();
            textBoxStop_ARI = new TextBox();
            textBoxResultat_ARI = new TextBox();
            buttonSpravka_ARI = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStart_ARI
            // 
            buttonStart_ARI.BackColor = Color.Green;
            buttonStart_ARI.Location = new Point(697, 446);
            buttonStart_ARI.Name = "buttonStart_ARI";
            buttonStart_ARI.Size = new Size(153, 48);
            buttonStart_ARI.TabIndex = 0;
            buttonStart_ARI.Text = "Выполнить";
            buttonStart_ARI.UseVisualStyleBackColor = false;
            buttonStart_ARI.Click += buttonStart_ARI_Click;
            // 
            // labelUslovie_ARI
            // 
            labelUslovie_ARI.AutoSize = true;
            labelUslovie_ARI.Location = new Point(22, 9);
            labelUslovie_ARI.Name = "labelUslovie_ARI";
            labelUslovie_ARI.Size = new Size(67, 20);
            labelUslovie_ARI.TabIndex = 1;
            labelUslovie_ARI.Text = "Условие";
           
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(874, 177);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelСonclusion_ARI
            // 
            labelСonclusion_ARI.AutoSize = true;
            labelСonclusion_ARI.Location = new Point(1086, 26);
            labelСonclusion_ARI.Name = "labelСonclusion_ARI";
            labelСonclusion_ARI.Size = new Size(110, 20);
            labelСonclusion_ARI.TabIndex = 3;
            labelСonclusion_ARI.Text = "Вывод данных";
            
            // 
            // labelStart_ARI
            // 
            labelStart_ARI.AutoSize = true;
            labelStart_ARI.Location = new Point(61, 353);
            labelStart_ARI.Name = "labelStart_ARI";
            labelStart_ARI.Size = new Size(85, 20);
            labelStart_ARI.TabIndex = 4;
            labelStart_ARI.Text = "Старт шага";
  
            // 
            // labelResultat_ARI
            // 
            labelResultat_ARI.AutoSize = true;
            labelResultat_ARI.Location = new Point(1109, 64);
            labelResultat_ARI.Name = "labelResultat_ARI";
            labelResultat_ARI.Size = new Size(75, 20);
            labelResultat_ARI.TabIndex = 5;
            labelResultat_ARI.Text = "Результат";
            // 
            // labelVvod_ARI
            // 
            labelVvod_ARI.AutoSize = true;
            labelVvod_ARI.Location = new Point(61, 322);
            labelVvod_ARI.Name = "labelVvod_ARI";
            labelVvod_ARI.Size = new Size(99, 20);
            labelVvod_ARI.TabIndex = 6;
            labelVvod_ARI.Text = "Ввод данных";
            // 
            // labelStop_ARI
            // 
            labelStop_ARI.AutoSize = true;
            labelStop_ARI.Location = new Point(218, 353);
            labelStop_ARI.Name = "labelStop_ARI";
            labelStop_ARI.Size = new Size(91, 20);
            labelStop_ARI.TabIndex = 7;
            labelStop_ARI.Text = "Конец шага";
            // 
            // textBoxStart_ARI
            // 
            textBoxStart_ARI.Location = new Point(47, 387);
            textBoxStart_ARI.Name = "textBoxStart_ARI";
            textBoxStart_ARI.Size = new Size(125, 27);
            textBoxStart_ARI.TabIndex = 8;
            // 
            // textBoxStop_ARI
            // 
            textBoxStop_ARI.Location = new Point(203, 391);
            textBoxStop_ARI.Name = "textBoxStop_ARI";
            textBoxStop_ARI.Size = new Size(125, 27);
            textBoxStop_ARI.TabIndex = 9;
            // 
            // textBoxResultat_ARI
            // 
            textBoxResultat_ARI.Location = new Point(939, 112);
            textBoxResultat_ARI.Multiline = true;
            textBoxResultat_ARI.Name = "textBoxResultat_ARI";
            textBoxResultat_ARI.Size = new Size(291, 343);
            textBoxResultat_ARI.TabIndex = 10;
            // 
            // buttonSpravka_ARI
            // 
            buttonSpravka_ARI.BackColor = SystemColors.HotTrack;
            buttonSpravka_ARI.Location = new Point(609, 453);
            buttonSpravka_ARI.Name = "buttonSpravka_ARI";
            buttonSpravka_ARI.Size = new Size(82, 35);
            buttonSpravka_ARI.TabIndex = 11;
            buttonSpravka_ARI.Text = "Справка";
            buttonSpravka_ARI.UseVisualStyleBackColor = false;
            buttonSpravka_ARI.Click += buttonSpravka_ARI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 525);
            Controls.Add(buttonSpravka_ARI);
            Controls.Add(textBoxResultat_ARI);
            Controls.Add(textBoxStop_ARI);
            Controls.Add(textBoxStart_ARI);
            Controls.Add(labelStop_ARI);
            Controls.Add(labelVvod_ARI);
            Controls.Add(labelResultat_ARI);
            Controls.Add(labelStart_ARI);
            Controls.Add(labelСonclusion_ARI);
            Controls.Add(pictureBox1);
            Controls.Add(labelUslovie_ARI);
            Controls.Add(buttonStart_ARI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1| Вариант 30 | Атанаев Р.И.";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart_ARI;
        private Label labelUslovie_ARI;
        private PictureBox pictureBox1;
        private Label labelСonclusion_ARI;
        private Label labelStart_ARI;
        private Label labelResultat_ARI;
        private Label labelVvod_ARI;
        private Label labelStop_ARI;
        private TextBox textBoxStart_ARI;
        private TextBox textBoxStop_ARI;
        private TextBox textBoxResultat_ARI;
        private Button buttonSpravka_ARI;
    }
}
