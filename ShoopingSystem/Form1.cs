using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoopingSystem
{
    public partial class Form1 : Form
    {

        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void categoriesbtn_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.ShowDialog();
        }

        private void shoppingOrderbtn_Click(object sender, EventArgs e)
        {
            ShoppingOrder shoppingOrder = new ShoppingOrder();
            shoppingOrder.ShowDialog();
        }

        private void Sellerbtn_Click(object sender, EventArgs e)
        {
            Seller seller = new Seller();
            seller.ShowDialog();
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void Deliveriesbtn_Click(object sender, EventArgs e)
        {
            Deliveries deliveries= new Deliveries();
            deliveries.ShowDialog();
        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Payment payment= new Payment();
            payment.ShowDialog();
        }

        private void Transactionbtn_Click(object sender, EventArgs e)
        {
            TransactionReports transactionReports = new TransactionReports();
            transactionReports.ShowDialog();
        }

        private void Productbtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
