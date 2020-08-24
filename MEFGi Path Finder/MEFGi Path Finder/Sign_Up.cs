using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEFGi_Path_Finder
{
    public partial class Sign_Up : UserControl
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            Do();
        }
        private void Do()
        {
            Mno.Focus();
            Invalid.Text = "";
            Resend.Hide();
            SendB.Text = "Send";
            Mno.Text = "";
            otp.Text = "";
            otp.Enabled = false;
            UserID.Enabled = true;
            Password.Enabled = true;
            Mno.Enabled = true;
        }

        private void SendB_Click(object sender, EventArgs e)
        {
            
            if(SendB.Text=="Send" && Mno.TextLength == 10 && UserID.Text!="" && Password.Text!="")
            {
                SendB.Text = "Submit";
                timer1.Start();
                timer1.Interval = 10000;
                otp.Enabled = true;
                Invalid.Text = "";
                UserID.Enabled = false;
                Password.Enabled = false;
                Mno.Enabled = false;

            }
            else if(otp.TextLength==6 && SendB.Text == "Submit")
            {
                Login.username = UserID.Text;
                Login.password = Password.Text;
                this.SendToBack();
                Do();
                timer1.Stop();
                
            }
            else
            {
                Invalid.Text = "Enter Data Properly...";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              Resend.Show();
        }
    }
}
