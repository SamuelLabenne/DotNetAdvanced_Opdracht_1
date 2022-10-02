using System;

namespace Oefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double priceEach1 = double.Parse(tb_pricee_1.Text) * double.Parse(tb_quantity_1.Text);
            tb_price_1.Text = "€ " + priceEach1.ToString("#.00");

            double priceEach2 = double.Parse(tb_pricee_2.Text) * double.Parse(tb_quantity_2.Text);
            tb_price_2.Text = "€ " + priceEach2.ToString("#.00");

            double priceEach3 = double.Parse(tb_pricee_3.Text) * double.Parse(tb_quantity_3.Text);
            tb_price_3.Text = "€ " + priceEach3.ToString("#.00");

            double priceEach4 = double.Parse(tb_pricee_4.Text) * double.Parse(tb_quantity_4.Text);
            tb_price_4.Text = "€ " + priceEach4.ToString("#.00");

            double subtotaal = priceEach1 + priceEach2 + priceEach3 + priceEach4;
            tb_subt.Text = "€ " + subtotaal.ToString("#.00");

            double salesTax = (subtotaal / 100) * 7;
            tb_salest.Text = "€ " + salesTax.ToString("#.00");

            double shipping = 0;

            //switch (tb_ship.Text)
            //{

            //    case (subtotaal > 20): 
            //        shipping = 5;
            //        tb_ship.Text = shipping.ToString();
            //        break;
            //    case "1":
            //        shipping = 7.5;
            //        tb_ship.Text = shipping.ToString();
            //        break;
            //    case "2":
            //        shipping = 10;
            //        tb_ship.Text = shipping.ToString();
            //        break;
            //    case "3":
            //        tb_ship.Text = "gratis";
            //        break;
            //} Ik wou dan hier op een if else doen waar je een case kreeg als uitkomst maar wist niet goed hoe, vond ook op internet gee antw

            if (subtotaal < 20)
            {
                shipping = 5;
                tb_ship.Text = "€ " + shipping.ToString("#.00");
            } else if (subtotaal < 50)
            {
                shipping = 7.5;
                tb_ship.Text = "€ " + shipping.ToString("#.00");
            }
            else if (subtotaal < 75)
            {
                shipping = 10;
                tb_ship.Text = "€ " + shipping.ToString("#.00");
            }
            else if (subtotaal >= 75){
                shipping = 0;
                tb_ship.Text = "gratis";
            }

            double grandTotal = subtotaal + salesTax +  shipping;
            tb_grandt.Text = "€ " + grandTotal.ToString("#.00");
        }
    }
}