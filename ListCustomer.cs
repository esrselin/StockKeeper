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
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        DataSet dset = new DataSet();

        private void ListCustomer_Load(object sender, EventArgs e)
        {

            List_C();
        }
        private void List_C()
        {
             con.Open();
             SqlDataAdapter sda = new SqlDataAdapter("SELECT * From [Stock].[dbo].[Customer]", con);
             sda.Fill(dset, "Customer");
             dataGridView1.DataSource = dset.Tables["Customer"];
             con.Close();
            }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            adress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void UPGRADE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email WHERE tc=@tc",con);
            cmd.Parameters.AddWithValue("@tc", id.Text);
            cmd.Parameters.AddWithValue("@adsoyad", nameSurname.Text);
            cmd.Parameters.AddWithValue("@telefon", phone.Text);
            cmd.Parameters.AddWithValue("@adres", adress.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            dset.Tables["Customer"].Clear();
            List_C();
            MessageBox.Show("The customer has been updated successfully!");
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox)
                {
                    texts.Text = "";
                }
            }
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            id.Clear();
            nameSurname.Clear();
            phone.Clear();
            adress.Clear();
            email.Clear();
            id.Focus();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE tc= '" + dataGridView1.CurrentRow.Cells["Column1"].Value.ToString() + "'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            dset.Tables["Customer"].Clear();
            List_C();
            MessageBox.Show("The customer has been deleted successfully!");
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer WHERE tc like '%"+search.Text+"%'", con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
            con.Open();
            var sqlQuery = "";
            sqlQuery = @"INSERT INTO [Stock].[dbo].[customer] ([tc],[adsoyad],[telefon],[adres],[email])
                        VALUES
                      ('" + id.Text + "','" + nameSurname.Text + "','" + phone.Text + "','" + adress.Text + "','" + email.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The customer has been added successfully!");
            foreach (Control texts in this.Controls)
            {
                if (texts is TextBox)
                {
                    texts.Text = "";
                }
            }
        }
    }
}