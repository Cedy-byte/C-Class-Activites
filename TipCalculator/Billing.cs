using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    //18002477
    public class Billing
    {
        // Declaring variables and Converting them to the required data type
        private double billAmount;
        private double percentage;
        private int noOfPeople;


        // Constructor 
        public Billing(double billAmount, double percentage, int noOfPeople)
        {
            this.BillAmount = billAmount;
            this.Percentage = percentage;
            this.NoOfPeople = noOfPeople;
        }
        // Get and Set Methods
        public double BillAmount { get => billAmount; set => billAmount = value; }
        public double Percentage { get => percentage; set => percentage = value; }
        public int NoOfPeople { get => noOfPeople; set => noOfPeople = value; }

        // Tip Calculation Method 
        public double calculateTip()
        {
            return BillAmount * Percentage / 100;
        }
        // Total bill calculation
        public double calculateTotal()
        {
            return BillAmount + calculateTip();
        }

        // Bill Split method 
        public double splitBill()
        {
            return calculateTotal() / NoOfPeople;
        }
    }
}
