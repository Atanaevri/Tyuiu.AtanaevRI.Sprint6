using Tyuiu.AtanaevRI.Sprint6.Task1.V30.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        private void buttonStart_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                int Startstep = Convert.ToInt32(textBoxStart_ARI.Text);
                int Stopstep = Convert.ToInt32(textBoxStop_ARI.Text);

                int len = ds.GetMassFunction(Startstep, Stopstep).Length;
                double[] valuearray;
                valuearray = new double[len];
                valuearray = ds.GetMassFunction(Startstep, Stopstep);
                string result = "Таблица значений функции:\r\n";
                result += "----------------------\r\n";
                result += "|     X     |   F(x)  |\r\n";
                result += "----------------------\r\n";

                for (int i = 0, x = Startstep; x <= Stopstep; x++, i++)
                {
                    result += $"| {x,5}     | {valuearray[i],7:0.00} |\r\n";
                }

                result += "----------------------";
                textBoxResultat_ARI.Text = result;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППБ-25-1 Атанаев Роман Ильнурович",
                           "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
    }
}

            