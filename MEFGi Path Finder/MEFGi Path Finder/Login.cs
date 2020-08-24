using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MEFGi_Path_Finder
{
    public partial class Login : Form
    {
        internal static string username="***",password="***";
        internal static Boolean closef = false;
        public Login()
        {
            InitializeComponent();
            LoginP.BringToFront();
            UserID.Focus();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginP.SendToBack();
        }

        private void sign_Up1_Load(object sender, EventArgs e)
        {

        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            if((UserID.Text=="Admin"&&Password.Text=="Admin@23")|| (UserID.Text == "User1" && Password.Text == "User1@23")|| (UserID.Text == "User2" && Password.Text == "User2@23") || (UserID.Text == username && Password.Text == password))
            {
                MessageBox.Show("Successfully Logged In");
                Form1 form = new Form1(UserID.Text,this);
                this.Hide();
                form.Show();
                UserID.Text = "";
                Password.Text="";
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                UserID.Text = "";
                Password.Text = "";
                UserID.Focus();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult can = MessageBox.Show("Sure You Want to close", "Clsoe", MessageBoxButtons.YesNo);
            if (can == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ResestB_Click(object sender, EventArgs e)
        {
            UserID.Text = "";
            Password.Text = "";
            UserID.Focus();
        }
    }
}

