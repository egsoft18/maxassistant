using Max_Assistant;
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
    public partial class opencloseorder : Form
    {

        DBManager c = new DBManager();
        public opencloseorder()
        {
            InitializeComponent();
        }

        private void opencloseorder_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            if (string.IsNullOrEmpty(action_cb.Text) == false)
            {

                if (startorder_txt.Text.Length < 8 && endorder_txt.Text.Length < 8)
                {

                }
                else if (startorder_txt.Text.Length >= 8 && endorder_txt.Text.Length < 1)
                {
                    if (action_cb.Text == "Cerrar")
                    {
                        string query = "UPDATE Order_Master SET [STATUS_10] = '4' where ORDNUM_10='" + startorder_txt.Text + "'";
                        c.command(query);
                        query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10='" + startorder_txt.Text + "'";
                        c.load_dgv(dataGridView1, query);
                    }
                    else if (action_cb.Text == "Abrir")
                    {
                        string query = "UPDATE Order_Master SET [STATUS_10] = '3' where ORDNUM_10='" + startorder_txt.Text + "'";
                        c.command(query);
                        query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10='" + startorder_txt.Text + "'";
                        c.load_dgv(dataGridView1, query);
                    }
                }
                else if (startorder_txt.Text.Length >= 8 && endorder_txt.Text.Length >= 8)
                {
                    if (Convert.ToInt32(startorder_txt.Text) > Convert.ToInt32(endorder_txt.Text))
                    {
                        MessageBox.Show("No se puede realizar la accion, debido a que el primer numero es mas grande que el segundo.", "Error");
                    }
                    else
                    {
                        if ((Convert.ToInt32(endorder_txt.Text) - Convert.ToInt32(startorder_txt.Text)) > 30)
                        {
                            DialogResult result = MessageBox.Show("Esta intentanco borrar mas de 30 ordenes al mismo tiempo, Esta segur@ de esta accion?", "Error de cantidad", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                if (action_cb.Text == "Cerrar")
                                {
                                    string query = "UPDATE Order_Master SET [STATUS_10] = '4' where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                    c.command(query);
                                    query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                    c.load_dgv(dataGridView1, query);
                                }
                                else if (action_cb.Text == "Abrir")
                                {
                                    string query = "UPDATE Order_Master SET [STATUS_10] = '3' where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                    c.command(query);
                                    query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                    c.load_dgv(dataGridView1, query);
                                }
                            }


                        }
                        else
                        {
                            if (action_cb.Text == "Cerrar")
                            {
                                string query = "UPDATE Order_Master SET [STATUS_10] = '4' where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                c.command(query);
                                query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                c.load_dgv(dataGridView1, query);
                            }
                            else if (action_cb.Text == "Abrir")
                            {
                                string query = "UPDATE Order_Master SET [STATUS_10] = '3' where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                c.command(query);
                                query = "select ORDNUM_10 as 'Numero de Orden', [STATUS_10] as Status, PRTNUM_10 as 'Stylo', ORDREF_10 as 'Order Max'  from Order_Master where ORDNUM_10>='" + startorder_txt.Text + "' and ORDNUM_10<='" + endorder_txt.Text + "'";
                                c.load_dgv(dataGridView1, query);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de elegir una accion primero.", "Error");
            }
        }
    }
}
