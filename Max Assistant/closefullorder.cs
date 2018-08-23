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
    
    public partial class closefullorder : Form
    {
        DBManager c = new DBManager();
            
        public closefullorder()
        {
            InitializeComponent();
        }

        private void orderref_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(action_cb.Text) == true)
            {
                MessageBox.Show("Debe de elegir una opcion a realizar.", "Error");
            }
            else
            {
                if (orderref_txt.Text.Length < 8)
                {
                    MessageBox.Show("Debe de digitar al menos 8 digitos.", "Error");
                }
                else if (orderref_txt.Text.Length >= 8)
                {
                    if (action_cb.Text == "Cerrar")
                    {
                        string query = "UPDATE Order_Master SET [STATUS_10] = '4' where ORDREF_10 like '" + orderref_txt.Text + "%'";
                        c.command(query);
                        query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDREF_10 like '" + orderref_txt.Text + "%'";
                        c.load_dgv(dataGridView1, query);
                    }
                    else if (action_cb.Text == "Abrir")
                    {
                        string query = "UPDATE Order_Master SET [STATUS_10] = '3' where ORDREF_10 like '" + orderref_txt.Text + "%'";
                        c.command(query);
                        query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDREF_10 like'" + orderref_txt.Text + "%'";
                        c.load_dgv(dataGridView1, query);
                    }
                }
            }
        }
    }
}
