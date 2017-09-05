using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakOtomasyonu
{
    public partial class frmKiralikIsyeri : Form
    {
        public frmKiralikIsyeri()
        {
            InitializeComponent();  
            new UXIFramework.UXImplementer().Implement(this,"Muhasebex");
        }
    }
}
