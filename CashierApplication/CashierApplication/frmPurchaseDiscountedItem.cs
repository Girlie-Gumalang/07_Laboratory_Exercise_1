using ItemNamespace;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        // Field to store the DiscountedItem object
        private DiscountedItem? discountedItem;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        // Event handler for the Compute button click
        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Get inputs from text boxes
            string itemName = txtItem.Text; 
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            // Create a new DiscountedItem object
            discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            // Compute the total price and display it in lblTotalAmount
            double totalAmount = discountedItem.getTotalPrice();
            lblTotalAmount.Text = $"Total amount:   {totalAmount:F2}";
        }

        // Event handler for the Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Prompt the user if they click submit before they calculate the total value
            if (discountedItem == null)
            {
                MessageBox.Show("Please compute the total price first.");
                return;
            }

            try
            {
                // Get payment amount from text box
                double paymentReceived = Convert.ToDouble(txtPaymentReceived.Text);

                // Set payment and calculate the change
                discountedItem.setPayment(paymentReceived);
                double change = discountedItem.getChange();

                // Display the change in lblChange
                lblChange.Text = $"Change:   {change:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid payment amount.");
            }
        }
    }
}
