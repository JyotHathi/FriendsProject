using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;

namespace MEFGi_Path_Finder
{
    
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Disc, int Resval);
        internal Login n1;
        public Form1()
        {
            InitializeComponent();

        }
        public Form1(string uname,Login Back)
        {
            InitializeComponent();
            User.Text = uname;
            Indicator.Width = Sop1.Width;
            Indicator.Top = Sop1.Bottom;
            aLocation1.BringToFront();
            n1 =Back;
            Check();  
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Check()
        {
            int disc;
            bool check = InternetGetConnectedState(out disc, 0);
            if (!check) { MessageBox.Show("Please Turn on Internet , few feature require internet"); }
        }
        private void Sop1_Click(object sender, EventArgs e){

            Check();
            Indicator.Top = Sop1.Bottom;
            aLocation1.BringToFront();
        }

        private void Sop2_Click(object sender, EventArgs e)
        {   
            Indicator.Top = Sop2.Bottom;
            mView1.BringToFront();
        }

        private void Sop3_Click(object sender, EventArgs e)
        {
            Check();
            Indicator.Top = Sop3.Bottom;
            lmarker1.BringToFront();
        }

        private void Sop4_Click(object sender, EventArgs e)
        {   
            Indicator.Top = Sop4.Bottom;
            rplaces1.BringToFront();
        }

        private void Sop5_Click(object sender, EventArgs e)
        {
            bookmarks1.BringToFront();
            Indicator.Top = Sop5.Bottom;
        }

        private void Sop6_Click(object sender, EventArgs e)
        {
            Indicator.Top = Sop6.Bottom;
            notification1.BringToFront();
        }

        private void Sop7_Click(object sender, EventArgs e)
        { 
            Indicator.Top = Sop7.Bottom;
            changePass1.BringToFront();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            n1.Show();
        }

        private void login_Page1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult can = MessageBox.Show("Sure You Want to close", "Clsoe", MessageBoxButtons.YesNo);
            if(can==DialogResult.Yes)
            {
                n1.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
            
        }
    }
}
