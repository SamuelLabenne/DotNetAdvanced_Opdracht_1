using System.Windows.Forms;

namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ctof_Click(object sender, EventArgs e)
        {
            try
            {
                // gebruik gemaakt van double en geen int, omdat de conversie slecht werkte
            double celsius = double.Parse(tb_celsius.Text);
            {
                tb_fahrenheit.Text = (celsius * 9 / 5 + 32).ToString("#,##0.0");
            }
            }
            catch
            {
                if (String.IsNullOrEmpty(tb_celsius.Text))
                {
                    lb_errors.Text = "Geen leeg waarde";
                    lb_errors.ForeColor = Color.Red;
                }
                else
                {
                    lb_errors.Text = "Fout waarde";
                    lb_errors.ForeColor = Color.Red;
                }
            }
        }

        private void btn_ftoc_Click(object sender, EventArgs e)
        {
            try
            {
                
                double fahrenheit = double.Parse(tb_fahrenheit.Text);
                {
                    tb_celsius.Text = ((fahrenheit - 32) * 5 / 9).ToString("#,##0.0");
                }
            }
            catch
            {
                if (String.IsNullOrEmpty(tb_celsius.Text))
                {
                    lb_errors.Text = "Geen leeg waarde";
                    lb_errors.ForeColor = Color.Red;
                }
                else
                {
                    lb_errors.Text = "Fout waarde";
                    lb_errors.ForeColor = Color.Red;
                }
            }
        }
    }
}