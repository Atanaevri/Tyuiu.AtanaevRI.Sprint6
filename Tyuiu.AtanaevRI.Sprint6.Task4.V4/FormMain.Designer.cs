namespace Tyuiu.AtanaevRI.Sprint6.Task4.V4
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
            labelUslovie_ARI = new Label();
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
            labelUslovie_ARI.Click += this.label1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUslovie_ARI);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUslovie_ARI;
    }
}
