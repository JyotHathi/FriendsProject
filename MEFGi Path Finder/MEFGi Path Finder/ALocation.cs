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
    public partial class ALocation : UserControl
    {
        public ALocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = comboBox1.SelectedIndex+1;
            switch(select)
            {
                case 1:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+College+Main+Building/@22.3674788,70.7948648,17z/data=!3m1!4b1!4m5!3m4!1s0x3959c83c5816984d:0xf35f79b391c45001!8m2!3d22.3674788!4d70.7970535");
                break;
                case 2:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University+PG+Building/@22.36831,70.7957244,17z/data=!3m1!4b1!4m5!3m4!1s0x3959c83ce2b05da5:0x4ba12236b11f6018!8m2!3d22.36831!4d70.7979131");
                break;
                case 3:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University+Lake/@22.3667316,70.7939253,17z/data=!3m1!4b1!4m5!3m4!1s0x3959c83c252c7b7d:0x5c0712e8ee104636!8m2!3d22.3667316!4d70.796114");
                break;
                case 4:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University+Hostel+Mess/@22.3666467,70.793054,17z/data=!3m1!4b1!4m5!3m4!1s0x3959c83c16058d83:0xf72b77e5cdb871f9!8m2!3d22.3666467!4d70.7952427");
                break;
                case 5:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University+Back+Canteen/@22.3666068,70.7944982,19z/data=!4m8!1m2!2m1!1smarwadi+university+back+canteen!3m4!1s0x3959c9360cc699c5:0xbb53ae3faa5675a!8m2!3d22.3665669!4d70.794848");
                break;
                case 6:webBrowser1.Navigate("https://www.google.com/maps/place/A-wing+Hostel/@22.3666068,70.7944982,19z/data=!4m8!1m2!2m1!1smarwadi+university+back+canteen!3m4!1s0x3959c83c466ecfc5:0xdb36647c225a56ac!8m2!3d22.3672878!4d70.7959474");
                break;
                case 7:webBrowser1.Navigate("https://www.google.com/maps/place/B+WING+GIRLS+HOSTEL/@22.3666068,70.7944982,19z/data=!4m8!1m2!2m1!1smarwadi+university+back+canteen!3m4!1s0x3959c94e0fb9acff:0x347a118b4907390!8m2!3d22.3673467!4d70.7956061");
                break;
                case 8:webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University+Boy's+Hostel+C+Wing/@22.3666068,70.7944982,19z/data=!4m8!1m2!2m1!1smarwadi+university+back+canteen!3m4!1s0x3959c978bb11f105:0xb3a873c5de6275f0!8m2!3d22.3674292!4d70.794906");
                break;    
            }
            
        }
    }
}
