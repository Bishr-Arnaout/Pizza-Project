using System;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frm_Order : Form
    {
        private float _Price = default;
        public frm_Order()
        {
            InitializeComponent();
        }
        void UpdateOrderSummary()
        {
            gb_Size.Enabled = true;
            gb_Crust_Type.Enabled = true;
            gb_Where_To_Eat.Enabled = true;
            gb_Toppings.Enabled = true;
            btn_To_Purchase_frm.Enabled = true;

            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEat_In.Checked = true;
            lblToppings.Text = "Nothing";

            chkCheese.Checked = false;
            chkBeef.Checked = false;
            chkTometo.Checked = false;
            chkTurkey.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
        }
        int CrustPrice()
        {
            if (rbThick.Checked) return 5;

            return 0;
        }
        int ToppingsPrice()
        {
            int Price = default;

            if (chkBeef.Checked) Price += 5;
            if (chkCheese.Checked) Price += 5;
            if (chkMushrooms.Checked) Price += 5;
            if (chkOnion.Checked) Price += 5;
            if (chkTurkey.Checked) Price += 5;
            if (chkTometo.Checked) Price += 5;

            return Price;
        }
        int SizePrice()
        {
            if (rbSmall.Checked) return 10;

            if (rbMedium.Checked) return 20;

            return 30;
        }
        void UpdatePrice()
        {
            lblPrice.Text = (SizePrice() + ToppingsPrice() + CrustPrice()).ToString() + "$";
        }
        void UpdateSize()
        {
            UpdatePrice();

            if (rbSmall.Checked) lblSize.Text = "Small";
            else if (rbMedium.Checked) lblSize.Text = "Medium";
            else lblSize.Text = "Large";
        }
        void UpdateToppings()
        {
            UpdatePrice();

            string stToppings = "";

            if (chkCheese.Checked) stToppings += "Cheese";
            if (chkBeef.Checked) stToppings += ", Beef";
            if (chkTometo.Checked) stToppings += ", Tometo";
            if (chkTurkey.Checked) stToppings += ", Turkey";
            if (chkOnion.Checked) stToppings += ", Onion";
            if (chkMushrooms.Checked) stToppings += ", Mushrooms";

            if (stToppings == "") stToppings = "Nothing";
            else if (stToppings.StartsWith(",")) stToppings = stToppings.Substring(1, stToppings.Length - 1).Trim();

            lblToppings.Text = stToppings;
        }
        void UpdateCrust()
        {
            UpdatePrice();

            if (rbThin.Checked) lblCrust.Text = "Thin";
            else lblCrust.Text = "Thick";
        }
        void UpdatePlace()
        {
            if (rbEat_In.Checked) lblPlace.Text = "Eat In";
            else lblPlace.Text = "Take Out";
        }
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbEat_In_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlace();
        }
        private void rbTake_Out_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlace();
        }
        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkBeef_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTurkey_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTometo_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void frm_Order_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
        private void btn_To_Main_frm_Click(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }
        void PerformOrder()
        {
            gb_Size.Enabled = false;
            gb_Crust_Type.Enabled = false;
            gb_Where_To_Eat.Enabled = false;
            gb_Toppings.Enabled = false;
            btn_To_Purchase_frm.Enabled = false;
        }
        private void btn_To_Purchase_frm_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to perform this order?", "Perform Order", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (DialogResult.OK == Result) PerformOrder();
        }
    }
}