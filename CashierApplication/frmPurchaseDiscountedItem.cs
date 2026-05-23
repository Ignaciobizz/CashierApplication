using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string itemName = txtItem.Text;

            double price = Convert.ToDouble(txtPrice.Text);

            int quantity = Convert.ToInt32(txtQuantity.Text);

            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(
                itemName,
                price,
                quantity,
                discount
            );

            lblTotal.Text = item.getTotalPrice().ToString("0.00");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName = txtItem.Text;

            double price = Convert.ToDouble(txtPrice.Text);

            int quantity = Convert.ToInt32(txtQuantity.Text);

            double discount = Convert.ToDouble(txtDiscount.Text);

            double payment = Convert.ToDouble(txtPayment.Text);

            DiscountedItem item = new DiscountedItem(
                itemName,
                price,
                quantity,
                discount
            );

            item.getTotalPrice();

            item.setPayment(payment);

            lblChange.Text = item.getChange().ToString("0.00");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            frmLoginAccount login =
                new frmLoginAccount();

            login.Show();

            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            Application.Exit();
        }
    }
}
