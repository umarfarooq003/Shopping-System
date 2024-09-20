using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoopingSystem
{
    public partial class TransactionReports : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public TransactionReports()
        {
            InitializeComponent();
        }

        private void TransactionReports_Load(object sender, EventArgs e)
        {

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From   TransactionReports";
            queryRunner(Query, sqlconnection);
        }


        private void queryRunner(string Query, SqlConnection connection)
        {
            using (SqlCommand cmd = new SqlCommand(Query, connection))
            {

                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransSubmitBtn_Click(object sender, EventArgs e)
        {
            string CustmerID = CustoIDtxtBox.Text;
            string OrderID = OrderIDtxtbox.Text;
            string ProductID=ProductIDtxtBox.Text;
            string PaymenetID=PaymentIDtxtBox.Text;
            if(string.IsNullOrEmpty(CustmerID) || string.IsNullOrEmpty(OrderID) || string.IsNullOrEmpty(ProductID) || string.IsNullOrEmpty(PaymenetID))
            {
                MessageBox.Show("Please fill in Required Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TransactionReports (customer_ID,order_ID,product_ID,payment_ID) VALUES (@customer_ID,@order_ID, @product_ID,@payment_ID)", sqlConnection);
            cmd.Parameters.AddWithValue("@customer_ID",int.Parse(CustmerID));
            cmd.Parameters.AddWithValue("@order_ID", int.Parse(OrderID));
            cmd.Parameters.AddWithValue("@product_ID", int.Parse(ProductID));
            cmd.Parameters.AddWithValue("@payment_ID", int.Parse(PaymenetID));
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            CustoIDtxtBox.Text = "";
            ProductIDtxtBox.Text = "";
            PaymentIDtxtBox.Text = "";
            OrderIDtxtbox.Text = "";
        }
    }
}
