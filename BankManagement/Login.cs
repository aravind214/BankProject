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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BankDB;Integrated Security=True; Connect Timeout=30");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DdLGNRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select Role");
            }
            else if (DdLGNRole.SelectedIndex == 0)
            {
                if (txtUsername.Text == "" || textPass.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTable where ADMName='" + txtUsername.Text + "' and ADMPass='" + textPass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents obj = new Agents();
                        obj.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password");
                        txtUsername.Text = "";
                        textPass.Text = "";
                        //DdLGNRole.SelectedIndex = -1;
                    }
                    con.Close();
                }
            }
            else
            {
                if (txtUsername.Text == "" || textPass.Text == "")
                {
                    MessageBox.Show("Enter Both User Name and Password");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl where AName='" + txtUsername.Text + "' and APass='" + textPass.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name or Password");
                        txtUsername.Text = "";
                        textPass.Text = "";
                        //DdLGNRole.SelectedIndex = -1;
                    }
                    con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            textPass.Text = "";
            DdLGNRole.SelectedIndex = -1;
            DdLGNRole.Text = "Role";
        }
    }
}
