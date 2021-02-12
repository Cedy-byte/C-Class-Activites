using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    //18002477
    public partial class fvTipCalculator : Form
    {
        
        public fvTipCalculator()
        {
            InitializeComponent();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clearing all Fields for a new calculation
            txtAmount.Text = String.Empty;
            txtTip.Text = String.Empty;
            cmbServive.Text = "";
            radSplitYes.Checked = false;
            radSplitNo.Checked = false;
            txtPeople.Clear();
            tbarNum.Value = tbarNum.Minimum;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            


            try
            {
                //Creating an Object
                Billing customer1 = new Billing(Convert.ToDouble(txtAmount.Text), Convert.ToInt32(txtTip.Text), Convert.ToInt32(txtPeople.Text));
                // Bill Decision
                if (radSplitYes.Checked)
                {

                    string display = "The tip Amount is : R" + customer1.calculateTip().ToString("F") + "\n"
                   + "The total Amount due is : R" + customer1.calculateTotal().ToString("F") + "\n"
                   + "Numer of people Served :  " + customer1.NoOfPeople + "\n"
                   + "Payment for each person : R" + customer1.splitBill().ToString("F") + "\n"
                   + "Service Rating : " + cmbServive.SelectedItem;
                    string heading = "Tip Calculator";
                    MessageBox.Show(display, heading);


                }
                else
                {
                    // Outputting the results Via the message Box
                    string message = "The tip Amount is : R" + customer1.calculateTip().ToString("F") + "\n"
                        + "The total Amount due is : R" + customer1.calculateTotal().ToString("F") + "\n"
                        + "Numer of people Served :  " + customer1.NoOfPeople + "\n"
                        + "Service Rating : " + cmbServive.SelectedItem;
                    string title = "Tip Calculator";
                    MessageBox.Show(message, title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, something Went Wrong !" + "\n"+ "\n"
                    + "Enter A number for the Bill Amount" +"\n"
                    +"\n" + "Enter A number for the Tip Percentage");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtPeople.Text = tbarNum.Value.ToString();
        }
    }
}
