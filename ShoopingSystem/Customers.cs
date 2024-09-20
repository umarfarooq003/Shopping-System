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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShoopingSystem
{
    public partial class Customers : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void CustoSubmitBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(CustoContactTxtBox.Text) || string.IsNullOrEmpty(CustAddresstxtbox.Text) || string.IsNullOrEmpty(CustoNametxtBox.Text))
            {
                MessageBox.Show("Please fill in  Required Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers (name, contact_add, address) VALUES (@name, @contact_add, @address)", sqlConnection);
            cmd.Parameters.AddWithValue("@name", CustoNametxtBox.Text);
            cmd.Parameters.AddWithValue("@contact_add", CustoContactTxtBox.Text);
            cmd.Parameters.AddWithValue("@address", CustAddresstxtbox.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            CustAddresstxtbox.Text = "";
            CustoContactTxtBox.Text = "";
            CustoNametxtBox.Text = "";
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From   Customers";
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

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
