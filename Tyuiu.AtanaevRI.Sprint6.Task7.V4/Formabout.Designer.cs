namespace Tyuiu.AtanaevRI.Sprint6.Task7.V4
{
    partial class Formabout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formabout));
            labelAbout_ARI = new Label();
            buttonOk_ARI = new Button();
            SuspendLayout();
            // 
            // labelAbout_ARI
            // 
            labelAbout_ARI.AutoSize = true;
            labelAbout_ARI.Location = new Point(216, 39);
            labelAbout_ARI.Name = "labelAbout_ARI";
            labelAbout_ARI.Size = new Size(359, 180);
            labelAbout_ARI.TabIndex = 0;
            labelAbout_ARI.Text = resources.GetString("labelAbout_ARI.Text");
            labelAbout_ARI.Click += label1_Click;
            // 
            // buttonOk_ARI
            // 
            buttonOk_ARI.Location = new Point(481, 246);
            buttonOk_ARI.Name = "buttonOk_ARI";
            buttonOk_ARI.Size = new Size(94, 29);
            buttonOk_ARI.TabIndex = 1;
            buttonOk_ARI.Text = "Ок";
            buttonOk_ARI.UseVisualStyleBackColor = true;
            buttonOk_ARI.Click += buttonOk_ARI_Click;
            // 
            // Formabout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 276);
            Controls.Add(buttonOk_ARI);
            Controls.Add(labelAbout_ARI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Formabout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout_ARI;
        private Button buttonOk_ARI;
    }
}