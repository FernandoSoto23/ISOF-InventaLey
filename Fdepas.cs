using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISOF_InventaLey.Clases;

namespace ISOF_InventaLey
{
    public partial class Fdepas : Form
    {
        public Fdepas()
        {
            InitializeComponent();
        }

        private void txtbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Departamento depa = new Departamento();
                depa = Departamento.BuscaDepa(int.Parse(txtbID.Text));
               
                txtbNombre.Text = depa.Nombre.ToString();
                txtbGerente.Text = depa.Gerente.ToString();
                txtbID.Text = depa.Id.ToString();
                Opciones(false,true);
            
            }
        }
        public void Opciones(bool valor1,bool valor2)
        {
            //para la busqueda
            txtbID.Enabled = valor1;
            pbBuscar.Enabled = valor1;
            pbReporte.Enabled = valor1;
            //cuando ya se hizo la busqueda
            txtbNombre.Enabled = valor2;
            txtbGerente.Enabled = valor2;
            btnGuardar.Enabled = valor2;
            btnEliminar.Enabled = valor2;
            BtnCancelar.Enabled = valor2;
            
        }
   

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Opciones(true,false);
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            fBuscar buscar = new fBuscar();
            buscar.ShowDialog();
        }

        private void pbReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
