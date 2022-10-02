namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i * 7 >= 546)
                {
                    lb_res.Text = i.ToString();
                    break;
                }
                else
                {
                    i++;
                }

            }
        }
    }
}