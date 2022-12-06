using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ISOF_InventaLey
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Loguear();
        }
        private void txtbContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                Loguear();
        }
        private Boolean EstaAbierta(string formulario)
        {
            Boolean sino = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formulario)
                {
                    form.Activate();
                    sino = true;
                    break;
                }
            }
            return sino;
        }
        public void Loguear()
        {
            Clases.Loguear l1 = new Clases.Loguear();

            l1.Usuario = txtbUsuario.Text.ToString();
            l1.Contraseña = txtbContraseña.Text.ToString();
            if (Clases.Loguear.Login(l1))
            {
                pLogin.Visible = false;
                if (CheckB_Recordar.Checked)
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "Usuario.txt");
                    sw.WriteLine(txtbUsuario.Text);
                    sw.Close();
                }
                else
                {
                    File.Delete(Application.StartupPath + "Usuario.txt");
                }
                Cargar();
            }
            else
            {
                txtbContraseña.Text = "";
                MessageBox.Show("Datos incorrectos");
            }

        }

       
        public void Cargar()
        {
            btn_Depas.Enabled = true;
            btn_SubDepas.Enabled = true;
            btn_Articulos.Enabled = true;
            btn_Movimientos.Enabled = true;
            btn_Clientes.Enabled = true;
            btn_Proveedores.Enabled = true;
            btn_Entradas.Enabled = true;
            btn_Salidas.Enabled = true;
            btn_Reportes.Enabled = true;
            btn_Empresa.Enabled = true;
            btn_Configuracion.Enabled = true;
            btn_Salir.Enabled = true;
        }
        public void Descargar()
        {
            btn_Depas.Enabled = false;
            btn_SubDepas.Enabled = false;
            btn_Articulos.Enabled = false;
            btn_Movimientos.Enabled = false;
            btn_Clientes.Enabled = false;
            btn_Proveedores.Enabled = false;
            btn_Entradas.Enabled = false;
            btn_Salidas.Enabled = false;
            btn_Reportes.Enabled = false;
            btn_Empresa.Enabled = false;
            btn_Configuracion.Enabled = false;
            btn_Salir.Enabled = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            pLogin.Visible = true;
            Descargar();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_Depas_Click(object sender, EventArgs e)
        {
            if (!EstaAbierta("Fdepas"))
            {
                Fdepas depa = new Fdepas();
                depa.MdiParent = this;
                depa.Show();
            }
        }

        private void CheckB_Recordar_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Screen pantalla = Screen.PrimaryScreen;
            Rectangle area = pantalla.WorkingArea;
            pLogin.Location = new Point(((area.Width - pLogin.Width) / 2),((area.Height - pLogin.Height) / 2));

            if (File.Exists(Application.StartupPath + "Usuario.txt"))
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "Usuario.txt");
                txtbUsuario.Text = sr.ReadLine();
                sr.Close();
                CheckB_Recordar.Checked = true;
            }
            if (txtbUsuario.Text.Length == 0)
                txtbUsuario.Focus();
            else
                txtbContraseña.Focus();

            
        }

       
        private void btn_Depas_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Depas.ForeColor = System.Drawing.Color.Red;
        }

        private void btn_Depas_MouseEnter(object sender, EventArgs e)
        {
            Button btnActual = (Button)sender;
            btnActual.ForeColor = System.Drawing.Color.Red;
        }

        private void btn_Depas_MouseLeave(object sender, EventArgs e)
        {
            Button btnActual = (Button)sender;
            btnActual.ForeColor = System.Drawing.Color.Black;
        }

        








        //desabilitar boton

    }
}
