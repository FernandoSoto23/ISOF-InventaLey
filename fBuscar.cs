using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISOF_InventaLey
{
    public partial class fBuscar : Form
    {
        string miTabla;
        string miFiltro;
        string miOrdenar;
        string miRegresar;
        string resultado = "";
        public fBuscar()
        {
            InitializeComponent();
        }

        public string Buscar(string tabla,string ordenar,string regresar,string filtrar = null)
        {
            this.Text = "Buscando " + tabla;
            miFiltro = filtrar;
            miTabla = tabla;
            miOrdenar = ordenar;
            miRegresar = regresar;
            this.ShowDialog();
            return resultado;
        }


        private void txtbFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                string cadena;
            }
        }
    }
}
