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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BankDB;Integrated Security=True; Connect Timeout=30");
        private void DisplayAgents()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from AgentTbl", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AcGv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtAName.Text = "";
            txtAPass.Text = "";
            txtAPhone.Text = "";
            txtAAddress.Text = "";  
        }

        private void btnAcSubmit_Click(object sender, EventArgs e)
        {
            if (txtAName.Text == "" || txtAPass.Text == "" || txtAPhone.Text == "" || txtAAddress.Text == ""  )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Insert into AgentTbl(AName,APass,APhone,AAddress) values(@AN,@AP,@APH,@AA)", con);
                    cmd.Parameters.AddWithValue("@AN", txtAName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtAPass.Text);
                    cmd.Parameters.AddWithValue("@APH", txtAPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAAddress.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Successfully Added... :)");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;

        private void btnAcEdit_Click(object sender, EventArgs e)
        {
            if (txtAName.Text == "" || txtAPass.Text == "" || txtAPhone.Text == "" || txtAAddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update AgentTbl set AName=@AN,APass=@AP,APhone=@APH,AAddress=@AA where AId=@Ackey ", con);
                    cmd.Parameters.AddWithValue("@AN", txtAName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtAPass.Text);
                    cmd.Parameters.AddWithValue("@APH", txtAPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtAAddress.Text);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Successfully Updated... :)");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnAcCancel_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Account");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId=@Ackey", con);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Successfully Deleted... :)");
                    con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AcGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAName.Text = AcGv.SelectedRows[0].Cells[1].Value.ToString();
            txtAPass.Text = AcGv.SelectedRows[0].Cells[2].Value.ToString();
            txtAPhone.Text = AcGv.SelectedRows[0].Cells[3].Value.ToString();
            txtAAddress.Text = AcGv.SelectedRows[0].Cells[4].Value.ToString();
           
            if (txtAName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AcGv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
            
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            Login obj1 = new Login();
            obj1.Show();
            this.Close();
        }
    }
}
