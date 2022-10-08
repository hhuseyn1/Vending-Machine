using System.Security.Cryptography;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double CashInPrice = default;
        void CalcTotPrice()
        {
            Totalprice_txtbox.Text=(int.Parse(Colacount_lbl.Text)+ int.Parse(Iceteacount_lbl.Text)+ int.Parse(Pepsicount_lbl.Text)
                + int.Parse(Fantacount_lbl.Text)+ int.Parse(Tutkucount_lbl.Text)+ int.Parse(Snickerscount_lbl.Text)
                + int.Parse(Layscount_lbl.Text)+ int.Parse(Fantacount_lbl.Text)+ int.Parse(Watercount_lbl.Text)
                +int.Parse(Doritoscount_lbl.Text)+ int.Parse(Albenicount_lbl.Text)+ int.Parse(Marscount_lbl.Text)).ToString();
        }
        private void cola_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Colacount_lbl.Text = (int.Parse(Colacount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Colacount_lbl.Text) > 0)
                    Colacount_lbl.Text = (int.Parse(Colacount_lbl.Text) - 1).ToString();
                else
                    Colacount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Pepsi_btn_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
                Pepsicount_lbl.Text = (int.Parse(Pepsicount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Pepsicount_lbl.Text) > 0)
                    Pepsicount_lbl.Text = (int.Parse(Pepsicount_lbl.Text) - 1).ToString();
                else
                    Pepsicount_lbl.Text = "0";
            }
            CalcTotPrice();
        }
       

        private void Fanta_btn_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
                Fantacount_lbl.Text = (int.Parse(Fantacount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Fantacount_lbl.Text) > 0)
                    Fantacount_lbl.Text = (int.Parse(Fantacount_lbl.Text) - 1).ToString();
                else
                    Fantacount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Icetea_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Iceteacount_lbl.Text = (int.Parse(Iceteacount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Iceteacount_lbl.Text) > 0)
                    Iceteacount_lbl.Text = (int.Parse(Iceteacount_lbl.Text) - 1).ToString();
                else
                    Iceteacount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Snickers_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Snickerscount_lbl.Text = (int.Parse(Snickerscount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Snickerscount_lbl.Text) > 0)
                    Snickerscount_lbl.Text = (int.Parse(Snickerscount_lbl.Text) - 1).ToString();
                else
                    Snickerscount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Albeni_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Albenicount_lbl.Text = (int.Parse(Albenicount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Albenicount_lbl.Text) > 0)
                    Albenicount_lbl.Text = (int.Parse(Albenicount_lbl.Text) - 1).ToString();
                else
                    Albenicount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Tutku_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Tutkucount_lbl.Text = (int.Parse(Tutkucount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Tutkucount_lbl.Text) > 0)
                    Tutkucount_lbl.Text = (int.Parse(Tutkucount_lbl.Text) - 1).ToString();
                else
                    Tutkucount_lbl.Text = "0";
            }
        }

        private void Mars_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Marscount_lbl.Text = (int.Parse(Marscount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Marscount_lbl.Text) > 0)
                    Marscount_lbl.Text = (int.Parse(Marscount_lbl.Text) - 1).ToString();
                else
                    Marscount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Bounty_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Bountycount_lbl.Text = (int.Parse(Bountycount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Bountycount_lbl.Text) > 0)
                    Bountycount_lbl.Text = (int.Parse(Bountycount_lbl.Text) - 1).ToString();
                else
                    Bountycount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Water_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Watercount_lbl.Text = (int.Parse(Watercount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Watercount_lbl.Text) > 0)
                    Watercount_lbl.Text = (int.Parse(Watercount_lbl.Text) - 1).ToString();
                else
                    Watercount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Lays_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Layscount_lbl.Text = (int.Parse(Layscount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Layscount_lbl.Text) > 0)
                    Layscount_lbl.Text = (int.Parse(Layscount_lbl.Text) - 1).ToString();
                else
                    Layscount_lbl.Text = "0";
            }
            CalcTotPrice();
        }

        private void Doritos_btn_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Doritoscount_lbl.Text = (int.Parse(Doritoscount_lbl.Text) + 1).ToString();
            else
            {
                if (int.Parse(Doritoscount_lbl.Text) > 0)
                    Doritoscount_lbl.Text = (int.Parse(Doritoscount_lbl.Text) - 1).ToString();
                else
                    Doritoscount_lbl.Text = "0";
            }
            CalcTotPrice();
        }


        private void C10_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 0.1;
            Cashin_txtbox.Text = Math.Round(CashInPrice, 2).ToString();
            Remainder();

        }

        private void C20_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 0.2;
            Cashin_txtbox.Text = Math.Round(CashInPrice,2).ToString();
            Remainder();

        }
        private void C50_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 0.5;
            Cashin_txtbox.Text = Math.Round(CashInPrice, 2).ToString();
            Remainder();

        }

        private void D1_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 1.0;
            Cashin_txtbox.Text = Math.Round(CashInPrice, 2).ToString();
            Remainder();

        }

        private void D5_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 5.0;
            Cashin_txtbox.Text = Math.Round(CashInPrice, 2).ToString();
            Remainder();

        }

        private void D10_btn_Click(object sender, EventArgs e)
        {
            CashInPrice += 10.0;
            Cashin_txtbox.Text = Math.Round(CashInPrice, 2).ToString();
            Remainder();
        }
        public void Remainder(){
            if (CashInPrice > double.Parse(Totalprice_txtbox.Text))
                Remainder_txtbox.Text =     Math.Round((double.Parse(Cashin_txtbox.Text) - double.Parse(Totalprice_txtbox.Text)),2).ToString();
        }
    }
}