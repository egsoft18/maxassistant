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
    public partial class postoperation : Form
    {
        DBManager c = new DBManager();
        string query;
        string valid;
        public postoperation()
        {
            InitializeComponent();
        }

        private void data_dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void code_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void code_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string code = code_txt.Text + "0000";
                if (position_cb.Text == "")
                {
                    MessageBox.Show("Debe de elegir una posicion/Estacion de lectura.", "Error");

                }
                else if (position_cb.Text == "Planning")
                {
                    //lectura PLAN

                    query =  "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {



                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                        c.command3(query);
                        query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text + "' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                        c.command3(query);
                        query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                        c.command3(query);
                        //--;
                        query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                        c.command3(query);
                        query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                        c.command3(query);
                        query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                        c.command3(query);
                        query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                        

                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }
                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv(dataGridView1, query);
                    //code_txt.SelectionLength = code_txt.Text.Length;
                    query = "";
                }
                else if (position_cb.Text == "Cut Out")
                {
                    //Lectura de Corte
                    query = "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {

                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '"+ code + "' and WRKCTR_14 = 'PLAN'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text +  "' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    //
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);
                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }
                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv(dataGridView1, query);
                    query = "";
                }
                else if (position_cb.Text == "Pre-Fitting Out")
                {
                    //Lectura de Pre-FItting

                    query = "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {

                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text + "' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    //--
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);
                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }


                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv( dataGridView1, query);
                    query = "";
                }
                else if(position_cb.Text == "Preparation Out")
                {
                    //--Lectura de Preparation out before Casing Booties / Leather

                    query = "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {

                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text +  "' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    //                 --
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);
                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }

                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv(dataGridView1, query);
                    query = "";
                }
                else if (position_cb.Text == "Casing Booties/Leather Out")
                {
                    //   --Lectura de Cassing Booties/ leather before Linea

                    query = "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {

                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text + "' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);
                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }

                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv(dataGridView1, query);
                    query = "";
                }
                else if(position_cb.Text == "Final Inspection")
                {
                    //--Lectura de Final

                    query = "select QTYREM_14 as 'QTY Due' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1' and QTYREM_14 > 0";
                    c.validation(query);

                    if (c.valor == "si")
                    {

                        query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PLAN'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'BCDP'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'CG2'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = '1CTB'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'INPS'";
                    c.command3(query);
                    query = "update Job_Progress set QTYCOM_14 = '6', QTYREM_14 = '0' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);
                    query = "update Job_Progress set MOVDTE_14 = '" + data_dtp.Text + "' where ordnum_14 = '" + code + "' and WRKCTR_14 = 'PACK1'";
                    c.command3(query);

                    }
                    else
                    {
                        MessageBox.Show("No Puede leer en este departamento, debido a que esta orden no esta pendiente");
                        c.valor = "";
                    }
                    query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
                    c.load_dgv(dataGridView1, query);
                    query = "";

                }
                if (!String.IsNullOrEmpty(code_txt.Text))
                {
                    code_txt.SelectionStart = 0;
                    code_txt.SelectionLength = code_txt.Text.Length;
                }
            }
        }

        private void postoperation_Load(object sender, EventArgs e)
        {
            gbpost.Show();
            gb0.Hide();
        }

        private void postoperation_Activated(object sender, EventArgs e)
        {
            //dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            data_dtp.CustomFormat = "MM-dd-yyyy";
            data_dtp.Format = DateTimePickerFormat.Custom;
            data_dtp.Value = DateTime.Now;
        }

        private void position_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            code_txt.SelectionStart = 0;
            code_txt.SelectionLength = code_txt.Text.Length;
        }

        private void position_cb_SelectedValueChanged(object sender, EventArgs e)
        {
            code_txt.Focus();
            code_txt.SelectionStart = 0;
        }

        private void postOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbpost.Show();
            gb0.Hide();
        }

        private void lecturaCeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbpost.Hide();
            gb0.Show();
        }

        private void txtcodezero_KeyDown(object sender, KeyEventArgs e)
        {
            string code = code_txt.Text + "0000";
            string query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '6', MOVDTE_14 = '' where WRKCTR_14 = 'PLAN' and ORDNUM_14 = '" + code + "'";
            c.command3(query);
            query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0', MOVDTE_14 = '' where WRKCTR_14 = 'BCDP' and ORDNUM_14 = '" + code + "'";
            c.command3(query);
            query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0', MOVDTE_14 = '' where WRKCTR_14 = 'CG2' and ORDNUM_14 = '" + code + "'";
            c.command3(query);
            query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0', MOVDTE_14 = '' where WRKCTR_14 = '1CTB' and ORDNUM_14 = '" + code + "'";
            c.command3(query);
            query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0', MOVDTE_14 = '' where WRKCTR_14 = 'INPS' and ORDNUM_14 = '" + code + "'";
            c.command3(query);
            query = "update Job_Progress set QTYCOM_14 = '0', QTYREM_14 = '0', MOVDTE_14 = '' where WRKCTR_14 = 'PACK1' and ORDNUM_14 = '" + code + "'";
            query = "select ORDNUM_14 as 'Codigo',OPRDES_14 as 'Posicion' ,PRTNUM_14 as 'PartID',QTYCOM_14 as 'QTY Com' ,QTYREM_14 as 'QTY Due', MOVDTE_14 as 'Fecha Lectura' from GENSHOES.dbo.Job_Progress where ordnum_14 = '" + code + "'";
            c.load_dgv(dataGridView2, query);
            query = "";
        }
    }
}
