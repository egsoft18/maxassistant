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
    public partial class seeorders : Form
    {
        public seeorders()
        {
            InitializeComponent();
        }

        private void seeorders_Load(object sender, EventArgs e)
        {
            maxorder_rbtn.PerformClick();

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (maxorder_rbtn.Checked == true)
            {

            }
            else if (poref_rbtn.Checked == true)
            {

            }
        }
    }
}
