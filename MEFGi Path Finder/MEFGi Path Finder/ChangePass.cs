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
    public partial class ChangePass : UserControl
    {
        public ChangePass()
        {
            InitializeComponent();
            Do();
        }

        public void Do()
        {
            otp.Enabled = false;
            Npass.Enabled = false;
            Rpass.Enabled = false;
            SeSu.Text = "Send";
            Invalid.Text = "";
            otp.Text = "";
            Npass.Text = "";
            Rpass.Text = "";
            Mno.Text = "";
            Cpass.Text = "";
            resend.Hide();
            Mno.Enabled = true;
            Cpass.Enabled = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeSu_Click(object sender, EventArgs e)
        {
            otp.Enabled = false;
            Npass.Enabled = false;
            Rpass.Enabled = false;
            Mno.Enabled = false;
            Cpass.Enabled = false;

            if (SeSu.Text=="Send" && Mno.TextLength==10 && Cpass.Text!="")
            {
                SeSu.Text = "Submit";
                timer1.Start();
                otp.Enabled = true;
                Npass.Enabled = true;
                Rpass.Enabled = true;
                Mno.Enabled = false;
                Cpass.Enabled = false;
                Invalid.Text = "";
                timer1.Interval = 30000;
            }
            else if(Npass.Text!="" && Rpass.Text!="" && Npass.Text==Rpass.Text && SeSu.Text=="Submit"&& otp.TextLength == 6)
            {
                Invalid.Text = "Password Change Successfully";
                resend.Hide();
                timer1.Stop();
                timer1.Start();
                timer1.Interval = 30000;
            }
            else
            {
                if(SeSu.Text=="Send")
                {
                    Invalid.Text = "Data Eneter Properly";
                    Mno.Text = "";
                    Cpass.Text = "";
                    Mno.Enabled = true;
                    Cpass.Enabled = true;

                }
                else if(otp.TextLength!=6 && SeSu.Text == "Submit")
                {
                    Invalid.Text = "Wrong OTP";
                    otp.Text = "";
                    Npass.Text = "";
                    Rpass.Text = "";
                    otp.Enabled = true;
                    Npass.Enabled = true;
                    Rpass.Enabled = true;
                }
                else
                {
                    Invalid.Text = "Password Not match";
                    Npass.Enabled = true;
                    Rpass.Enabled = true;

                }
               

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Invalid.Text!= "Password Change Successfully")
            {
                resend.Show();
            }
            else
            {
                Do();
            }
            timer1.Stop();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
