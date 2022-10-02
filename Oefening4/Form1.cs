namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // decimal.Parse(tv_pricee_+i.Text) om een for loop te maken gaat niet??????

            decimal priceEach1 = decimal.Parse(tb_pricee_1.Text) * nud_q_1.Value;
            tb_extp_1.Text = "€ " + priceEach1.ToString("#,##0.00");

            decimal priceEach2 = decimal.Parse(tb_pricee_2.Text) * nud_q_2.Value;
            tb_extp_2.Text = "€ " + priceEach2.ToString("#,##0.00");

            decimal priceEach3 = decimal.Parse(tb_pricee_3.Text) * nud_q_3.Value;
            tb_extp_3.Text = "€ " + priceEach3.ToString("#,##0.00");

            decimal priceEach4 = decimal.Parse(tb_pricee_4.Text) * nud_q_4.Value;
            tb_extp_4.Text = "€ " + priceEach4.ToString("#,##0.00");

            decimal subtotaal = priceEach1 + priceEach2 + priceEach3 + priceEach4;
            tb_subt.Text = "€ " + subtotaal.ToString("#,##0.00");

            decimal salesTax = subtotaal * decimal.Parse(tb_taxr.Text);
            tb_salest.Text = salesTax.ToString("#,##0.00");

            decimal grandTotal = subtotaal + salesTax + decimal.Parse(tb_ship.Text);
            tb_grandt.Text = "€ " + grandTotal.ToString("#,##0.00");
        }
    }

}