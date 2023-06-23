using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Form1
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        bool statu;
        private void errorcat()
        {
            statu = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoryinfo", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (cat.Text == read["kategori"].ToString() || cat.Text == "")
                {
                    statu = false;
                }
            }
            con.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {


        }

        private void catAdd_Click(object sender, EventArgs e)
        {
            errorcat();
            if (statu == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Categoryinfo(kategori) VALUES('" + cat.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("The category has been added successfully!");

            }
           else if (string.IsNullOrEmpty(cat.Text))
            {
                cat.Clear();
                MessageBox.Show("Category name is required!", "Error");
            }
            else
            {
                MessageBox.Show("This category has already  been added!", "Error");
            }
            cat.Text = "";
        }
    }
}
