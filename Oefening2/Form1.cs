namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int lb_inv_1_res = 12345 * 54321;
            int lb_inv_2_res = 22222 * 33333;
            lb_inv_1.Text = "12345*54321 = " + lb_inv_1_res;
            lb_inv_2.Text = "22222 * 33333 = " + lb_inv_2_res;
            bool check = lb_inv_1_res.Equals(lb_inv_2_res);
            lb_res.Text = "12345*54321 > 22222 * 33333 = " + check.ToString();
        }
    }
}