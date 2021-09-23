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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=BankDB;Integrated Security=True; Connect Timeout=30");
        int Balance;
        private void CheckBalance()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountTable where ACNum=" + txtCheckBalance.Text + "",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblBalance.Text = "Rs "+ dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }
            con.Close();
        }
        private void CheckAvailableBalance()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountTable where ACNum=" + txtFromTrnst.Text + "", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblTnsfrBlnce.Text = "Rs " + dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }
            //con.Close();
        }
        private void GetNewBalance(string text)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from AccountTable where ACNum=" + txtCheckBalance.Text + "", con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //lblBalance.Text = "Rs " + dr["ACBalance"].ToString();
                Balance = Convert.ToInt32(dr["ACBalance"].ToString());
            }
            con.Close();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtCheckBalance.Text == "")
            {
                MessageBox.Show("Please Enter Account Number");
            }
            else
            {
                CheckBalance(); 
                if(lblBalance.Text == "Your Balance")
                {
                    MessageBox.Show("Account not found..");
                    txtCheckBalance.Text = "";
                }
            }
        }
        private void Deposit()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into TransactionTable(TName,TDate,TAmount,TACNum) values(@TN,@TD,@TA,@TACN)", con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", txtAmountDep.Text);
                cmd.Parameters.AddWithValue("@TACN", txtAmountDep.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }
        private void Withdraw()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into TransactionTable(TName,TDate,TAmount,TACNum) values(@TN,@TD,@TA,@TACN)", con);
                cmd.Parameters.AddWithValue("@TN", "Withdraw");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", txtAmountDep.Text);
                cmd.Parameters.AddWithValue("@TACN", txtAmountDep.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }
        private void AddBalance()
        {
            GetNewBalance(txtToTrnst.Text);
            int newBal = Balance + Convert.ToInt32(txtAmountTrnst.Text);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Update AccountTable set ACBalance=@ACB where ACNum=@Ackey ", con);
                cmd.Parameters.AddWithValue("@ACB", newBal);

                cmd.Parameters.AddWithValue("@Ackey", txtToTrnst.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void SubstractBalance()
        {
            GetNewBalance(txtFromTrnst.Text);
            int newBal = Balance - Convert.ToInt32(txtAmountTrnst.Text);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Update AccountTable set ACBalance=@ACB where ACNum=@Ackey ", con);
                cmd.Parameters.AddWithValue("@ACB", newBal);

                cmd.Parameters.AddWithValue("@Ackey", txtFromTrnst.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtAcNumDep.Text=="" || txtAmountDep.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance(txtAcNumDep.Text);
                int newBal = Balance + Convert.ToInt32(txtAmountDep.Text);
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update AccountTable set ACBalance=@ACB where ACNum=@Ackey ", con);
                    cmd.Parameters.AddWithValue("@ACB", newBal);
                    
                    cmd.Parameters.AddWithValue("@Ackey", txtAcNumDep.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money Successfully Deposited... :)");
                    con.Close();
                    //Reset();
                    //DisplayAccounts();
                    txtAmountDep.Text = "";
                    txtAcNumDep.Text = "";
                    lblBalance.Text = "Your Balance";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //WithDraw Region
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtAcNumWD.Text == "" || txtAmountWD.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                
                GetNewBalance(txtAcNumWD.Text);
                Withdraw();
                if (Balance< Convert.ToInt32(txtAmountWD.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBal = Balance - Convert.ToInt32(txtAmountWD.Text);
                    try
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("Update AccountTable set ACBalance=@ACB where ACNum=@Ackey ", con);
                        cmd.Parameters.AddWithValue("@ACB", newBal);

                        cmd.Parameters.AddWithValue("@Ackey", txtAcNumWD.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money Successfully Withdrawn... :)");
                        con.Close();
                        //Reset();
                        //DisplayAccounts();
                        txtAmountWD.Text = "";
                        txtAcNumWD.Text = "";
                        lblBalance.Text = "Your Balance";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                
            }
        }
        //Transfer Region
        private void FromSearch_Click(object sender, EventArgs e)
        {
            if (txtFromTrnst.Text == "")
            {
                MessageBox.Show("Enter Source Account");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTable where ACNum='" + txtFromTrnst.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Account Doesn't Exist");
                    txtFromTrnst.Text = "";
                    //DdLGNRole.SelectedIndex = -1;
                }
                con.Close();
            }
        }

        private void ToSearch_Click(object sender, EventArgs e)
        {
            if (txtToTrnst.Text == "")
            {
                MessageBox.Show("Enter Destination Account");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTable where ACNum='" + txtToTrnst.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //CheckAvailableBalance();
                    MessageBox.Show("Account Found");
                    con.Close();
                    if (txtToTrnst.Text == txtFromTrnst.Text)
                    {
                        MessageBox.Show("Source and Destination Accounts are Same");
                        txtToTrnst.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account Doesn't Exist");
                    txtToTrnst.Text = "";
                    //DdLGNRole.SelectedIndex = -1;
                }
                con.Close();
            }
        }

        private void Transfer()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into TransferTable(TrSrc,TrDest,TrAmnt,TrDate) values(@TS,@TDE,@TA,@TD)", con);
                cmd.Parameters.AddWithValue("@TS", txtFromTrnst.Text);
                cmd.Parameters.AddWithValue("@TDE", txtToTrnst.Text);
                cmd.Parameters.AddWithValue("@TA", txtAmountTrnst.Text);
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Money Successfully Transfered..!!");
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(txtToTrnst.Text=="" || txtFromTrnst.Text == "" || txtAmountTrnst.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Convert.ToInt16(txtAmountTrnst.Text)>Balance)
            {
                MessageBox.Show("Insufficient Balance");
            }
            else
            {
                Transfer();
                SubstractBalance();
                AddBalance();
                txtFromTrnst.Text = "";
                txtToTrnst.Text = "";
                txtAmountTrnst.Text = "";
                lblTnsfrBlnce.Hide();
            }
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            MainMenu obj1 = new MainMenu();
            obj1.Show();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCheckBalance.Text = "Your Balance";
        }
    }
}
