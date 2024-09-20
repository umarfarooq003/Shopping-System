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
    public partial class Deliveries : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Deliveries()
        {
            InitializeComponent();
        }

        private void Deliveries_Load(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From  Deliveries";
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

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DelSubmitBtn_Click(object sender, EventArgs e)
        {
            string ID = CustoIDtxtbox.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Please fill in Customer ID Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO  Deliveries (category_name,category_type) VALUES (@category_name, @category_type)", sqlConnection);
            cmd.Parameters.AddWithValue("@category_name", CustoIDtxtbox.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            CustoIDtxtbox.Text = "";
        }
    }
}
