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
    public partial class ShoppingOrder : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public ShoppingOrder()
        {
            InitializeComponent();
        }

        private void ShoppingOrder_Load(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From  Shopping_Order";
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

        private void ShopingSubmitBtn_Click(object sender, EventArgs e)
        {
            string ID = prdIDtxtbox.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please fill in Required Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Shopping_Order (customer_ID) VALUES (@ customer_ID)", sqlConnection);
            cmd.Parameters.AddWithValue("@customer_ID", prdIDtxtbox.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            prdIDtxtbox.Text = "";

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
