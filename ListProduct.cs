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

namespace Form1
{
    public partial class ListProduct : Form
    {
        public ListProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        DataSet dset = new DataSet();

        bool statu;
        private void barcodecheck()
        {
            statu = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (nbar.Text == read["barkod"].ToString() || nbar.Text == "")
                {
                    statu = false;
                }
            }
            con.Close();
        }
   
  
        private void ListProduct_Load(object sender, EventArgs e)
        {
            List_P();
            showcategory();
        }
        private void List_P()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * From [Stock].[dbo].[Product]", con);
            sda.Fill(dset, "Product");
            dataGridView1.DataSource = dset.Tables["Product"];
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nbar.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            comcat.Text = dataGridView1.CurrentRow.Cells["Column3"].Value.ToString();
            combra.Text = dataGridView1.CurrentRow.Cells["Column7"].Value.ToString();
            npro.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            nsale.Text = dataGridView1.CurrentRow.Cells["Column6"].Value.ToString();
            npurc.Text = dataGridView1.CurrentRow.Cells["Column5"].Value.ToString();
            nqui.Text = dataGridView1.CurrentRow.Cells["Column4"].Value.ToString();

        }
        private void showcategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoryinfo", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comcat.Items.Add(read["kategori"].ToString());
            }
            con.Close();
        }
        private void comcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            combra.Items.Clear();
            combra.Text = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Brandinfo WHERE kategori='" + comcat.SelectedItem + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combra.Items.Add(read["marka"].ToString());
            }
            con.Close();
        }
        private void ADD_Click(object sender, EventArgs e)
        {
            barcodecheck();
            if (statu == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Product (barkod,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) 
                VALUES (@barkod, @kategori, @marka, @urunadi, @miktari, @alisfiyati, @satisfiyati,@tarih)", con);
                cmd.Parameters.AddWithValue("@barkod", nbar.Text);
                cmd.Parameters.AddWithValue("@kategori", comcat.Text);
                cmd.Parameters.AddWithValue("@marka", combra.Text);
                cmd.Parameters.AddWithValue("@urunadi", npro.Text);
                cmd.Parameters.AddWithValue("@miktari", int.Parse(nqui.Text));
                cmd.Parameters.AddWithValue("@alisfiyati", double.Parse(npurc.Text));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(nsale.Text));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                con.Close();
             
                MessageBox.Show("The product has been added successfully!");
            }
            else if (string.IsNullOrEmpty(nbar.Text))
            {
                nbar.Clear();
                MessageBox.Show("Barcode is required!", "Error");
            }

            foreach (Control texts in newgroup.Controls)
            {
                if (texts is TextBox)
                {
                    texts.Text = "";
                }
                if (texts is ComboBox)
                {
                    texts.Text = "";
                }
            }
            nqui.Text = "";
        }
        private void luptade_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Product SET urunadi=@urunadi, miktari=@miktari, kategori=@kategori, marka=@marka, alisfiyati=@alisfiyati, satisfiyati=@satisfiyati WHERE barkod=@barkod", con);
            cmd.Parameters.AddWithValue("@barkod", nbar.Text);
            cmd.Parameters.AddWithValue("@kategori", comcat.Text);
            cmd.Parameters.AddWithValue("@marka", combra.Text);
            cmd.Parameters.AddWithValue("@urunadi", npro.Text);
            cmd.Parameters.AddWithValue("@miktari", int.Parse(nqui.Text));
            cmd.Parameters.AddWithValue("@alisfiyati", double.Parse(npurc.Text));
            cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(nsale.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            dset.Tables["Product"].Clear();
            List_P();
            MessageBox.Show("The selected product has been updated successfully!");
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox)
                {
                    texts.Text = "";
                }
            }
        }

      
       

        private void ldelete_Click(object sender, EventArgs e)
        
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Product WHERE barkod= '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                dset.Tables["Product"].Clear();
                List_P();
                MessageBox.Show("The product has been deleted successfully!");
            }

        private void searchb_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Product WHERE barkod like '%" + searchb.Text + "%'", con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();
        }

     
    }
    }
