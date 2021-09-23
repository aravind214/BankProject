using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PicAccounts_Click(object sender, EventArgs e)
        {
            AddAccounts obj = new AddAccounts();
            obj.Show();
            this.Hide();
        }

        private void PicSettings_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            obj.Show();
           this.Hide();
        }

        private void PicTransactions_Click(object sender, EventArgs e)
        {
            Transaction obj = new Transaction();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
