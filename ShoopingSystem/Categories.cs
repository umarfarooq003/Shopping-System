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
    public partial class Categories : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-5BG8Q2I;Initial Catalog=ShoppingSystem;Integrated Security=True;Encrypt=False";
        public Categories()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CatSubmitBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(catNametxtBox.Text) || string.IsNullOrEmpty(cattypetxtbox.Text))
            {
                MessageBox.Show("Please fill in both Categories Name and Categories Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO  Categories (category_name,category_type) VALUES (@category_name, @category_type)", sqlConnection);
            cmd.Parameters.AddWithValue("@category_name", catNametxtBox.Text);
            cmd.Parameters.AddWithValue("@category_type", cattypetxtbox.Text);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Data Inserted Successfully");
            cattypetxtbox.Text = "";
            catNametxtBox.Text = "";
           
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(ConnectionString);
            sqlconnection.Open();
            string Query = "Select * From  Categories";
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
    }
}
