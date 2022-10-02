namespace Oefening7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            try
            {
                int invoer = int.Parse(tb_invoer.Text) + 1;
                int result = 0;
                for (int i = 0; i < invoer; i++)
                {
                    result += i;
                }

                tb_result.Text = result.ToString();
                lb_errors.Text = "";
            }
            catch
            {
                lb_errors.Text = "Invoer is geen geheel getal of is leeg";
            }

        }
    }
}