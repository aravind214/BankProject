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

namespace BankManagement
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj2 = new Login();
            obj2.Show();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtAdmnNewPass.Text = "";
            DdTheme.SelectedIndex = -1;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (DdTheme.SelectedIndex == -1)
            {
                MessageBox.Show("Select A Theme");
            }
            else if (DdTheme.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Orange;

            }
            else if (DdTheme.SelectedIndex == 1)
            {
                panel1.BackColor = Color.LightBlue;
            }
            else if (DdTheme.SelectedIndex == 2)
            {
                panel1.BackColor = Color.Red;
            }
            else if (DdTheme.SelectedIndex == 3)
            {
                panel1.BackColor = Color.LightGreen ;
            }

        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BankDB;Integrated Security=True; Connect Timeout=30");
        int key = 1;
        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            if (txtAdmnNewPass.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update AdminTable set ADMPass=@AP where ADMId=@Ackey", con);
                    cmd.Parameters.AddWithValue("@AP", txtAdmnNewPass.Text);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Successfully Updated... :)");
                    con.Close();
                    txtAdmnNewPass.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            MainMenu obj1 = new MainMenu();
            obj1.Show();
            this.Close();
        }
    }
}
