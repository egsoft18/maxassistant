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
    public partial class inserdatabooties : Form
    {
        public inserdatabooties()
        {
            InitializeComponent();
        }

        private void insertbooties_btn_Click(object sender, EventArgs e)
        {
            // Se crea  y se instancia la clase de ficheros.
            OpenFileDialog open = new OpenFileDialog();
            //le agregamos un filtro para los tipos de archivos a leer en este caso XML.
            open.Filter = "xlxs files (*.xlsx)|*.xlsx";
            //open.Filter = "xls files (*.xls)|*.xls";
            //cuando presionamos sobre el botón validamos que el resultado esperado sea la selección de un archivo.
            if (open.ShowDialog() == DialogResult.OK && open.ToString() != " ")
            {
                //Movemos la ruta del archivo a nuestro Textbox creado para su posterior uso.
                bootiestt_txt.Text = open.FileName;
            }



            //DBManager_EG C = new DBManager_EG();
            //string excel = bootiestt_txt.Text;
            //C.insertdata(excel);
        }

        private void insert_booties_btn_Click(object sender, EventArgs e)
        {
            DBManager_EG C = new DBManager_EG();
            string excel = bootiestt_txt.Text;
            C.insertdata(excel);
        }
    }
}
