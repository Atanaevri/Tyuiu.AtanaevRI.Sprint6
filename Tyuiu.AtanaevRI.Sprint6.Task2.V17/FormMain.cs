using Tyuiu.AtanaevRI.Sprint6.Task2.V17.Lib;
namespace Tyuiu.AtanaevRI.Sprint6.Task2.V17
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
                int startstep = Convert.ToInt32(textBoxStart_ARI.Text);
                int stopstep = Convert.ToInt32(textBoxStop_ARI.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                double[] valuearray;
                valuearray = new double[len];
                valuearray = ds.GetMassFunction(startstep, stopstep);
                //this.chartFunction.Titles.Add("График Функции sin(X)");
                ///this.hartFunction.Titles.Add();
                //this.hartFunction.Titles.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
