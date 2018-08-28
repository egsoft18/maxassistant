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
    public partial class entryhw : Form
    {
        DBManager c = new DBManager();
        public entryhw()
        {
            InitializeComponent();
        }

        private void entryhw_Load(object sender, EventArgs e)
        {

        }

        private void entryhw_Activated(object sender, EventArgs e)
        {

        }

        private void txtpartid_TextChanged(object sender, EventArgs e)
        {
            string query = "select ORDER_10 as Orden, PRTNUM_10 as PartId, UDFREF_10 as PO, PM.PMDES1_01 as 'Desc' from Order_Master om, Part_Master PM where om.PRTNUM_10 = pm.PRTNUM_01 and PRTNUM_10 like '" + txtpartid.Text + "%' and STATUS_10 = '3' and DUEQTY_10 > 1 and UDFKEY_10 = '' and ORDNUM_10 like '5%'";
            c.load_dgv(dataGridView1, query);
        }

        private void txtupc_TextChanged(object sender, EventArgs e)
        {
            string query = "select PRTNUM_01 from Part_Master where UDFKEY_01 = '" + txtupc.Text+"'";
            c.fill_txt(txtpartid, query, "PRTNUM_01");
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            string order = act.Cells["Orden"].Value.ToString();
            string query = "update Order_Master set UDFKEY_10 = '" + dataentry.Text + "' where ORDER_10 = '" + order + "'";
            c.command3(query);
            if (c.valor == "si")
            {

                string query2 = "select UDFREF_10 from Order_Master where ORDER_10 = '" + order + "'";
                c.fill_txt(txtpo, query2, "UDFREF_10");

                MessageBox.Show("El PO de la caja es el siguiente" +txtpo.Text+ ". Por favor coloquelo en el lugar adecuado.", "Caja aceptada");
                
                c.valor = "";
                txtupc.Clear();
                txtpartid.Clear();
                entryhw frm = new entryhw();
                frm.MdiParent = this.MdiParent;
                frm.Show();

                this.Close();
                //DataTable dt = (DataTable)dataGridView1.DataSource;
                //dt.Clear();
                //entryhw_Load("",e);
            }


        }
    }
}
