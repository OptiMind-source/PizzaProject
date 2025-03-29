using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        private float _Price = 0;
        private string _Topping = "";
        public Form1()
        {
            InitializeComponent();
        }

        float GetToppingPrice()
        {
            float TotalPrice = 0;
            if (chkExtraChees.Checked)
            {
               TotalPrice+= Convert.ToSingle(chkExtraChees.Tag);
               
            }
            if (chkMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            }
            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkGeenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chkGeenPeppers.Tag);
            }
            return TotalPrice;
        }
        float GetSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
            else
            {
                return 0;
            }
        }
        float GetCrustPrice()
        {
            if (rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }

            if (rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }
            else
            {
                return 0;
            }
        }
        float CalCulatTotalPrice()
        {
            return GetSizePrice()+ GetCrustPrice()+ GetToppingPrice();
        }
        void UpdateTotalPrice()
        {
            lSPrice.Text = "$"+CalCulatTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lSSize.Text = "Small";
            }
            if (rbMedium.Checked)
            {
                lSSize.Text = "Medium";
            }
            if (rbLarge.Checked)
            {
                lSSize.Text = "Large";
            }

        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThick.Checked)
            {
                lSCrustType.Text = "Thick";
            }
            if (rbThin.Checked)
            {
                lSCrustType.Text = "Thin";
            }

        }
        void UpdateOrderType()
        {
            UpdateTotalPrice();
            if (rbEatIn.Checked)
            {
                lSWhereToEat.Text = "Eat In";
            }
            if (rbTakeOut.Checked)
            {
                lSWhereToEat.Text = "Take Out";
            }

        }
        void UpdateToping()
        {
            UpdateTotalPrice();

            string Topping = "";
            if (chkExtraChees.Checked)
            {
                Topping += " Extra Cheese,";
            }
            if (chkMushrooms.Checked)
            {
                Topping += " Mushrooms,";
            }
            if (chkTomatoes.Checked)
            {
                Topping += " Tomatoes,";
            }
            if (chkOnion.Checked)
            {
                Topping += " Onion,";
            }
            if (chkOlives.Checked)
            {
                Topping += " Olives,";
            }
            if (chkGeenPeppers.Checked)
            {
                Topping += " Geen Peppers,";
            }
            if (Topping == "")
            {
                Topping = "NoToppings";
            }
            
            lSToppings.Text = Topping;
        }
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
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

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderType();
            
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrderType();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToping();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateCrust();
            UpdateToping();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void chkGeenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully","Success");
            }
            gbSize.Enabled = false;
            gbCrust.Enabled = false;
            gbWhereToEat.Enabled = false;
            gbToppings.Enabled = false;

        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;
            gbSize.Enabled = true;
        }

        
    }
}
