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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        DataSet dset = new DataSet();

        private void CartList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Cart", con);
            sda.Fill(dset, "Cart");
            dataGridView1.DataSource = dset.Tables["Cart"];
            // dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            // dataGridView1.Columns[2].Visible = false;
            con.Close();
        }

        private void listCustomer_Click(object sender, EventArgs e)
        {
            ListCustomer list = new ListCustomer();
            list.ShowDialog();
        }

 
        private void category_Click(object sender, EventArgs e)
        {
            Category add = new Category();
            add.ShowDialog();
        }

        private void brand_Click(object sender, EventArgs e)
        {
            Brand add = new Brand();
            add.ShowDialog();
        }

        private void listProduct_Click(object sender, EventArgs e)
        {
            ListProduct list = new ListProduct();
            list.ShowDialog();
        }

        private void GTotal()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT sum(toplamfiyati) from Cart", con);
                grandt.Text = cmd.ExecuteScalar() + "TL";
                con.Close();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            CartList();
            GTotal();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                name.Text = "";
                phone.Text = "";
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE tc like'" + id.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                name.Text = read["adsoyad"].ToString();
                phone.Text = read["telefon"].ToString();
            }
            con.Close();
        }
        private void CleanBox()
        {
            if (barcode.Text == "")
            {
                foreach (Control item in productg.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != quan)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        private void MainPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                quan.Text = barcode.Text.Replace("*", "");
                barcode.Text = "";
            }
        }
        private void barcode_TextChanged(object sender, EventArgs e)
        {
            CleanBox();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE barkod like'" + barcode.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                pname.Text = read["urunadi"].ToString();
                sprice.Text = read["satisfiyati"].ToString();
            }
            con.Close();
        }
        bool statu;
        private void barcodecheck()
        {
            statu = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cart", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (barcode.Text == read["barkod"].ToString())
                {
                    statu = false;
                }
            }
            con.Close();

        }
        int secim;
        private void urunmiktarikontrol()
        {

            secim = 1;
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Product", con);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (barcode.Text == read["barkod"].ToString())
                {
                    int miktar = int.Parse(read["miktari"].ToString());
                    if (miktar <= 0 || miktar < int.Parse(quan.Text))
                    {
                        secim = 0;
                    }

                }
            }
            con.Close();
        }

        private void mpAdd_Click(object sender, EventArgs e)
        {
            urunmiktarikontrol();
            if (secim == 1)
            {
                barcodecheck();


                if (statu == true)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Cart(tc,adsoyad,telefon,barkod,urunadi,miktari,satisfiyati,toplamfiyati,tarih)
                    VALUES (@tc,@adsoyad,@telefon,@barkod,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", con);
                    cmd.Parameters.AddWithValue("@tc", id.Text);
                    cmd.Parameters.AddWithValue("@barkod", barcode.Text);
                    cmd.Parameters.AddWithValue("@adsoyad", name.Text);
                    cmd.Parameters.AddWithValue("@telefon", phone.Text);
                    cmd.Parameters.AddWithValue("@urunadi", pname.Text);
                    cmd.Parameters.AddWithValue("@miktari", int.Parse(quan.Text));
                    cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(tprice.Text));
                    cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(sprice.Text));
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE Cart SET miktari=miktari+'" + int.Parse(quan.Text) + "' WHERE barkod='" + barcode.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("UPDATE Cart SET toplamfiyati=miktari*satisfiyati WHERE barkod='" + barcode.Text + "'", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
            }
            else if (secim == 0)
            {
                MessageBox.Show("Product Quantity is not enough!");
            }
            dset.Tables["Cart"].Clear();
            CartList();
            GTotal();

            foreach (Control item in productg.Controls)
            {
                if (item is TextBox)
                {
                      item.Text = "";
                }
                
            }
        }

        private void quan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tprice.Text = (int.Parse(quan.Text) * double.Parse(sprice.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void sprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tprice.Text = (int.Parse(quan.Text) * double.Parse(sprice.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void mpDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Cart WHERE barkod='" + dataGridView1.CurrentRow.Cells["Column3"].Value.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The product has been removed from the cart.");
            dset.Tables["Cart"].Clear();
            CartList();
            GTotal();
        }

        private void mpCancel_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Cart", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The order has been cancelled.");
            dset.Tables["Cart"].Clear();
            CartList();
            GTotal();
        }

  
        private void mpSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The order has been approved.");
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sell(tc,adsoyad,telefon,barkod,urunadi,miktari,satisfiyati,toplamfiyati,tarih) VALUES (@tc,@adsoyad,@telefon,@barkod,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", con);
                cmd.Parameters.AddWithValue("@tc", id.Text);
                cmd.Parameters.AddWithValue("@adsoyad", name.Text);
                cmd.Parameters.AddWithValue("@telefon", phone.Text);
                cmd.Parameters.AddWithValue("@barkod", dataGridView1.Rows[i].Cells["Column3"].Value.ToString());
                cmd.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["Column4"].Value.ToString());
                cmd.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["Column5"].Value.ToString()));
                cmd.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["Column7"].Value.ToString()));
                cmd.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["Column6"].Value.ToString()));
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("UPDATE Product SET miktari=miktari- '" + int.Parse(dataGridView1.Rows[i].Cells["Column5"].Value.ToString()) + "' WHERE barkod='" + dataGridView1.Rows[i].Cells["Column3"].Value.ToString() + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();


            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Cart", con);
            cmd2.ExecuteNonQuery();
            con.Close();
            dset.Tables["Cart"].Clear();
            CartList();
            GTotal();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barcode.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            quan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            sprice.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tprice.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
         
        }
    }
}



