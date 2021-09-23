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

namespace BankManagement
{
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BankDB;Integrated Security=True; Connect Timeout=30");
        private void DisplayAccounts()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from AccountTable", con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AcGv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            txtACName.Text = "";
            txtACPhone.Text = "";
            txtACAddress.Text = ""; 
            DdACGender.SelectedIndex = -1;
            txtACOccupation.Text = ""; 
            DdACEducation.SelectedIndex = -1; 
            txtACIncome.Text = "";
        }

        //private void AddAccounts_Load(object sender, EventArgs e)
        //{

        //}

        private void btnAcSubmit_Click(object sender, EventArgs e)
        {
            if(txtACName.Text=="" || txtACPhone.Text=="" || txtACAddress.Text=="" || DdACGender.SelectedIndex==-1 ||
                txtACOccupation.Text == "" || DdACEducation.SelectedIndex==-1 ||  txtACIncome.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Insert into AccountTable(ACName,ACPhone,ACAddress,ACGender,ACOccupation,ACEducation,ACIncen,ACBalance) values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)",con);
                    cmd.Parameters.AddWithValue("@AN", txtACName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtACPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtACAddress.Text);
                    cmd.Parameters.AddWithValue("@AG", DdACGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", txtACOccupation.Text);
                    cmd.Parameters.AddWithValue("@AE", DdACEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", txtACIncome.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Created... :)");
                    con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcEdit_Click(object sender, EventArgs e)
        {
            if (txtACName.Text == "" || txtACPhone.Text == "" || txtACAddress.Text == "" || DdACGender.SelectedIndex == -1 ||
                txtACOccupation.Text == "" || DdACEducation.SelectedIndex == -1 || txtACIncome.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update AccountTable set ACName=@AN,ACPhone=@AP,ACAddress=@AA,ACGender=@AG,ACOccupation=@AO,ACEducation=@AE,ACIncen=@AI where ACNum=@Ackey ", con);
                    cmd.Parameters.AddWithValue("@AN", txtACName.Text);
                    cmd.Parameters.AddWithValue("@AP", txtACPhone.Text);
                    cmd.Parameters.AddWithValue("@AA", txtACAddress.Text);
                    cmd.Parameters.AddWithValue("@AG", DdACGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", txtACOccupation.Text);
                    cmd.Parameters.AddWithValue("@AE", DdACEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", txtACIncome.Text);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Updated... :)");
                    con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnAcCancel_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Select Account");
            }
            else
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("delete from AccountTable where ACNum=@Ackey", con);
                    cmd.Parameters.AddWithValue("@Ackey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Deleted... :)");
                    con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void AcGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtACName.Text = AcGv.SelectedRows[0].Cells[1].Value.ToString();
            txtACPhone.Text = AcGv.SelectedRows[0].Cells[2].Value.ToString();
            txtACAddress.Text = AcGv.SelectedRows[0].Cells[3].Value.ToString();
            DdACGender.SelectedItem = AcGv.SelectedRows[0].Cells[4].Value.ToString();
            txtACOccupation.Text = AcGv.SelectedRows[0].Cells[5].Value.ToString();
            DdACEducation.SelectedItem = AcGv.SelectedRows[0].Cells[6].Value.ToString();
            txtACIncome.Text = AcGv.SelectedRows[0].Cells[7].Value.ToString();
            if (txtACName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AcGv.SelectedRows[0].Cells[0].Value.ToString());
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
