using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier(
                "Allen Ignacio",
                "BSIT",
                "IgnacioAllen",
                "Ghost09"
            );

            if (cashier.validateLogin(
                txtUsername.Text,
                txtPassword.Text))
            {
                MessageBox.Show(
                    "Welcome " +
                    cashier.getFullName() +
                    " of " +
                    cashier.getDepartment());

                Form1 frm = new Form1();

                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password");
            }
        }
    }

}
