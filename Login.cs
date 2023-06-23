using Form1;
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

namespace StockKeeper
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4BT0MEC;Initial Catalog=Stock;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void SUMBIT_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = userName.Text;
            user_password = password.Text;

            try
            {
                String querry = "SELECT * FROM Login Where UserName = '" + userName.Text + "' AND Password = '" + password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = userName.Text;
                    user_password = password.Text;

                    this.Hide();
                    MainPage form1 = new MainPage();
                    form1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username & Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userName.Clear();
                    password.Clear();

                }
            }
            catch
            {

                MessageBox.Show("Error");

            }
            finally
            {
                con.Close();
            }

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            userName.Clear();
            password.Clear();
            userName.Focus();

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void jGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
