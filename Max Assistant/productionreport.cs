using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max_Assistant
{
    public partial class productionreport : Form
    {
        public productionreport()
        {
            InitializeComponent();
        }

        private void productionreport_Load(object sender, EventArgs e)
        {
            onedate_dtp.PerformClick();
        }
    }
}
