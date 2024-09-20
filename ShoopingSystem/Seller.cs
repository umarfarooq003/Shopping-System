using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoopingSystem
{
    public partial class Seller : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Seller()
        {
            InitializeComponent();
        }

        private void Seller_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From  Seller";
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

        private void SellerSubmitBtn_Click(object sender, EventArgs e)
        {
            string name=SellerNametxtBox.Text;
            string ID = prdIDtxtbox.Text;

            if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(name) )
            {
                MessageBox.Show("Please fill in Required Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Seller (name, product_ID) VALUES (@name, @product_ID)", sqlConnection);
            cmd.Parameters.AddWithValue("@name", SellerNametxtBox.Text);
            cmd.Parameters.AddWithValue("@product_ID", int.Parse(prdIDtxtbox.Text));
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            SellerNametxtBox.Text = "";
            prdIDtxtbox.Text = "";
           
        }
    }
}
