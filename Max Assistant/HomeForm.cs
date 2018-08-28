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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subirRellenoABaseDeDatosPruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarYAbrirOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opencloseorder frm = new opencloseorder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarOrdenCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closefullorder frm = new closefullorder();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ponerReferenciaAOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderreference frm = new orderreference();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarOrdenesControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            string querry = "UPDATE Order_Master SET [STATUS_10] = '4' where ORDREF_10 like '%control%'";
            c.command3(querry);
            MessageBox.Show("Todas las ordenes control ahora estan en estatus 4 (Completadas)", "Hecho");

        }

        private void visorDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seeorders frm = new seeorders(); frm.MdiParent = this; frm.Show();
        }

        private void digitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postoperation frm = new postoperation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertarDataDeBootiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inserdatabooties frm = new inserdatabooties();
            frm.MdiParent = this;
            frm.Show();

         }

        private void entradaDeOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryorder frm = new entryorder();
            frm.MdiParent = this;
            frm.Show();
        }

        public void entradaAAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //entryhw frm = new entryhw();
            //frm.MdiParent = this;
            //frm.Show();
            wh();
        }
        public void wh()
        {
            entryhw frm = new entryhw();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
