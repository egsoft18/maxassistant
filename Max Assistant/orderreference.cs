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
    public partial class orderreference : Form
    {
        DBManager c = new DBManager();
        public orderreference()
        {
            InitializeComponent();
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].Order_Master SET [UDFREF_10] = '" + ref_txt.Text + "' WHERE ORDREF_10 like '" + order_txt.Text + "%' and ORDNUM_10 like '5%'";
            c.command(query);
            query = "select ORDREF_10 as 'Order', UDFREF_10 as Ref from Order_Master where ORDREF_10 like '" + order_txt.Text + "%' and UDFREF_10 = '" + ref_txt.Text + "'";
            c.load_dgv(dataGridView1, query);
        }
    }
}
