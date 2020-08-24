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
    public partial class Lmarker : UserControl
    {
        public Lmarker()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.google.com/maps/place/Marwadi+University/@22.3675142,70.7958709,18z/data=!4m8!1m2!2m1!1sMarwadi+University!3m4!1s0x0:0xe6c1048589fe4e62!8m2!3d22.3674295!4d70.7972161");
        }
    }
}
