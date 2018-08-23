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
    
    public partial class entryorder : Form
    {
        DBManager_EG c = new DBManager_EG();
        public entryorder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string popi = po_txt.Text+partid_txt.Text;
            string query = "insert into orders (po, custumer, partid, orderqty, hwqty, popartid) values('" + po_txt.Text + "', '" + custumer_txt.Text + "', '" + partid_txt.Text + "', '" + qty_txt.Text + "', '0','" + popi + "') ";
            c.command(query);
            loaddgv();
        }
        private void loaddgv()
        {
            string query = "select po as PO, partid as PartId, orderqty as QTY, hwqty as HW from  orders where po = '" + po_txt.Text + "'";
            c.load_dgv(dataGridView1, query);
            totalsum();
        }
        private void totalsum()
        {
            string query = "select sum(orderqty) as suma from orders where po = '" + po_txt.Text + "'";
            c.fill_txt(ordertotal_txt, query, "suma");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
