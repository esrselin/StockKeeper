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
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        bool statu;
        private void errorbra()
        {
            statu = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Brandinfo", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (bracat.Text==read["kategori"].ToString() && bra.Text == read["marka"].ToString() || bracat.Text=="" || bra.Text == "")
                {
                    statu = false;
                }
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            errorbra();
            if (statu == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Brandinfo(kategori,marka) VALUES('" + bracat.Text + "','" + bra.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                bra.Text = "";
                bracat.Text = "";
                MessageBox.Show("The Brand has been added successfully!");
            }
      
           else if (string.IsNullOrEmpty(bra.Text))
            {
                bra.Clear();
                MessageBox.Show("Brand name is required!","Error");
            }
            else
            {
                MessageBox.Show("This brand has already been added!", "Error");
            }
            bra.Text = "";

        }
        private void CatBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoryinfo", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                bracat.Items.Add(read["kategori"].ToString());
            }
            con.Close();
        }
        private void Brand_Load(object sender, EventArgs e)
        {
            CatBox();
        }
    }
}
