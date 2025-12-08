using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AtanaevRI.Sprint6.Task0.V30.Lib;

namespace Tyuiu.AtanaevRI.Sprint6.Task0.V30
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_ARI_Click(object sender, EventArgs e)
        {
            DataService ds= new DataService();
            try
            {
                textBoxResultat_ARI.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxPositionWinX_ARI.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные ","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
       
        private void buttonSpravka_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППБ-25-1 Атанаев Роман Ильнурович",
                           "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
