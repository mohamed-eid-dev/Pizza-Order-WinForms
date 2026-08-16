using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _sizePrice = 50;
        private int _crustPrice = 10;
        private int _toppingsPrice = 0;

        private string AddingToppingToLabel()
        {
            string TotalTopping = "";
            TotalTopping += checkBox1.Checked == true ? "Extra Chees, " : "";
            TotalTopping += checkBox2.Checked == true ? "Myshrooms," : "";
            TotalTopping += checkBox4.Checked == true ? "Onion," : "";
            TotalTopping += checkBox3.Checked == true ? "\nTomatoes," : "";
            TotalTopping += checkBox5.Checked == true ? "Olives," : "";
            TotalTopping += checkBox6.Checked == true ? "Green Peppers" : "";
            TotalTopping += TotalTopping == ""? "Not Topping" : "";


            return TotalTopping;
        }
        private int CalculateTotalTopping()
        {
            int TotalTopping = 0;
            TotalTopping += checkBox1.Checked == true ? 5 : 0;
            TotalTopping += checkBox2.Checked == true ? 5 : 0;
            TotalTopping += checkBox3.Checked == true ? 5 :0;
            TotalTopping += checkBox4.Checked == true ? 5 : 0;
            TotalTopping += checkBox5.Checked == true ? 5 : 0;
            TotalTopping += checkBox6.Checked == true ? 5 : 0;
          
            return TotalTopping;
        }

        private void ResetForm()
        {
            // Default selections
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            // Uncheck toppings
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            // Reset prices
            _sizePrice = 40;
            _crustPrice = 10;
            _toppingsPrice = 0;

            _toppingsPrice = CalculateTotalTopping();
            label5.Text = AddingToppingToLabel();
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }




        /// ///////////////////////////////////////////////////////////////////


        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = "Small";
            _sizePrice = 40;
            lbPrice.Text = "$" + (_sizePrice+ _crustPrice+ _toppingsPrice);
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = "Meduim";
            _sizePrice = 50;
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);


        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = "Large";
            _sizePrice = 60;
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = "Thin Crust";
            _crustPrice = 10;
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);

        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = "Think Crust";
            _crustPrice = 20;
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);


        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbToEat.Text = "Eat In";
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbToEat.Text = "Take Out";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _toppingsPrice= CalculateTotalTopping();
            label5.Text = AddingToppingToLabel();
            lbPrice.Text = "$" + (_sizePrice + _crustPrice + _toppingsPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
            MessageBox.Show("Order Placed Successfully", "Success");
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToEat.Enabled = false;
                gbToppings.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToEat.Enabled = true;
            gbToppings.Enabled = true;
            button1.Enabled = true;

            ResetForm();
        }
    }
}
