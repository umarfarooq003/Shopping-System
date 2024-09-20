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
    public partial class Payment : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Payment()
        {
            InitializeComponent();
        }

        private void PaySubmitBtn_Click(object sender, EventArgs e)
        {
            string ID = catIDtxtbox.Text;

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please fill in Required Filed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payment (customer_ID) VALUES (@ customer_ID)", sqlConnection);
            cmd.Parameters.AddWithValue("@customer_ID", catIDtxtbox.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            catIDtxtbox.Text = "";

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From  Payment";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
