
namespace ISOF_InventaLey
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Configuracion = new System.Windows.Forms.Button();
            this.btn_Empresa = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Salidas = new System.Windows.Forms.Button();
            this.btn_Entradas = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Movimientos = new System.Windows.Forms.Button();
            this.btn_Articulos = new System.Windows.Forms.Button();
            this.btn_SubDepas = new System.Windows.Forms.Button();
            this.txtb_Departamento = new System.Windows.Forms.Button();
            this.btn_Depas = new System.Windows.Forms.Button();
            this.pLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckB_Recordar = new System.Windows.Forms.CheckBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Controls.Add(this.btn_Configuracion);
            this.panel1.Controls.Add(this.btn_Empresa);
            this.panel1.Controls.Add(this.btn_Reportes);
            this.panel1.Controls.Add(this.btn_Salidas);
            this.panel1.Controls.Add(this.btn_Entradas);
            this.panel1.Controls.Add(this.btn_Proveedores);
            this.panel1.Controls.Add(this.btn_Clientes);
            this.panel1.Controls.Add(this.btn_Movimientos);
            this.panel1.Controls.Add(this.btn_Articulos);
            this.panel1.Controls.Add(this.btn_SubDepas);
            this.panel1.Controls.Add(this.txtb_Departamento);
            this.panel1.Controls.Add(this.btn_Depas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 681);
            this.panel1.TabIndex = 0;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.Enabled = false;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.ImageIndex = 12;
            this.btn_Salir.ImageList = this.imageList1;
            this.btn_Salir.Location = new System.Drawing.Point(3, 542);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(155, 35);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Cerrar Sesion";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            this.btn_Salir.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Salir.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Tag = "";
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpeta.png");
            this.imageList1.Images.SetKeyName(1, "inventario(2).png");
            this.imageList1.Images.SetKeyName(2, "carrito-de-supermercado.png");
            this.imageList1.Images.SetKeyName(3, "papel.png");
            this.imageList1.Images.SetKeyName(4, "objetivo(1).png");
            this.imageList1.Images.SetKeyName(5, "proveedor.png");
            this.imageList1.Images.SetKeyName(6, "carro-de-la-carretilla(1).png");
            this.imageList1.Images.SetKeyName(7, "carro.png");
            this.imageList1.Images.SetKeyName(8, "reporte(1).png");
            this.imageList1.Images.SetKeyName(9, "cajero-automatico.png");
            this.imageList1.Images.SetKeyName(10, "configuraciones.png");
            this.imageList1.Images.SetKeyName(11, "configuraciones.png");
            this.imageList1.Images.SetKeyName(12, "apagar.png");
            this.imageList1.Images.SetKeyName(13, "aceptar.png");
            // 
            // btn_Configuracion
            // 
            this.btn_Configuracion.BackColor = System.Drawing.Color.White;
            this.btn_Configuracion.Enabled = false;
            this.btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Configuracion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Configuracion.ImageIndex = 10;
            this.btn_Configuracion.ImageList = this.imageList1;
            this.btn_Configuracion.Location = new System.Drawing.Point(3, 501);
            this.btn_Configuracion.Name = "btn_Configuracion";
            this.btn_Configuracion.Size = new System.Drawing.Size(155, 35);
            this.btn_Configuracion.TabIndex = 11;
            this.btn_Configuracion.Text = "Configuracion";
            this.btn_Configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Configuracion.UseVisualStyleBackColor = false;
            this.btn_Configuracion.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Configuracion.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Empresa
            // 
            this.btn_Empresa.BackColor = System.Drawing.Color.White;
            this.btn_Empresa.Enabled = false;
            this.btn_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Empresa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empresa.ImageIndex = 9;
            this.btn_Empresa.ImageList = this.imageList1;
            this.btn_Empresa.Location = new System.Drawing.Point(3, 460);
            this.btn_Empresa.Name = "btn_Empresa";
            this.btn_Empresa.Size = new System.Drawing.Size(155, 35);
            this.btn_Empresa.TabIndex = 10;
            this.btn_Empresa.Text = "Empresa";
            this.btn_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Empresa.UseVisualStyleBackColor = false;
            this.btn_Empresa.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Empresa.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.White;
            this.btn_Reportes.Enabled = false;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Reportes.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.ImageIndex = 8;
            this.btn_Reportes.ImageList = this.imageList1;
            this.btn_Reportes.Location = new System.Drawing.Point(3, 419);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(155, 35);
            this.btn_Reportes.TabIndex = 9;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reportes.UseVisualStyleBackColor = false;
            this.btn_Reportes.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Reportes.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Salidas
            // 
            this.btn_Salidas.BackColor = System.Drawing.Color.White;
            this.btn_Salidas.Enabled = false;
            this.btn_Salidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Salidas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salidas.ImageIndex = 7;
            this.btn_Salidas.ImageList = this.imageList1;
            this.btn_Salidas.Location = new System.Drawing.Point(3, 378);
            this.btn_Salidas.Name = "btn_Salidas";
            this.btn_Salidas.Size = new System.Drawing.Size(155, 35);
            this.btn_Salidas.TabIndex = 8;
            this.btn_Salidas.Text = "Salidas";
            this.btn_Salidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salidas.UseVisualStyleBackColor = false;
            this.btn_Salidas.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Salidas.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Entradas
            // 
            this.btn_Entradas.BackColor = System.Drawing.Color.White;
            this.btn_Entradas.Enabled = false;
            this.btn_Entradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Entradas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Entradas.ImageIndex = 6;
            this.btn_Entradas.ImageList = this.imageList1;
            this.btn_Entradas.Location = new System.Drawing.Point(3, 337);
            this.btn_Entradas.Name = "btn_Entradas";
            this.btn_Entradas.Size = new System.Drawing.Size(155, 35);
            this.btn_Entradas.TabIndex = 7;
            this.btn_Entradas.Text = "Entradas";
            this.btn_Entradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Entradas.UseVisualStyleBackColor = false;
            this.btn_Entradas.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Entradas.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.Color.White;
            this.btn_Proveedores.Enabled = false;
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Proveedores.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedores.ImageIndex = 5;
            this.btn_Proveedores.ImageList = this.imageList1;
            this.btn_Proveedores.Location = new System.Drawing.Point(3, 296);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(155, 35);
            this.btn_Proveedores.TabIndex = 6;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Proveedores.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.BackColor = System.Drawing.Color.White;
            this.btn_Clientes.Enabled = false;
            this.btn_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clientes.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clientes.ImageIndex = 4;
            this.btn_Clientes.ImageList = this.imageList1;
            this.btn_Clientes.Location = new System.Drawing.Point(3, 255);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(155, 35);
            this.btn_Clientes.TabIndex = 5;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clientes.UseVisualStyleBackColor = false;
            this.btn_Clientes.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Clientes.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.BackColor = System.Drawing.Color.White;
            this.btn_Movimientos.Enabled = false;
            this.btn_Movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Movimientos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Movimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Movimientos.ImageIndex = 3;
            this.btn_Movimientos.ImageList = this.imageList1;
            this.btn_Movimientos.Location = new System.Drawing.Point(3, 214);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.Size = new System.Drawing.Size(155, 35);
            this.btn_Movimientos.TabIndex = 4;
            this.btn_Movimientos.Text = "Tipos Movimientos";
            this.btn_Movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Movimientos.UseVisualStyleBackColor = false;
            this.btn_Movimientos.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Movimientos.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_Articulos
            // 
            this.btn_Articulos.BackColor = System.Drawing.Color.White;
            this.btn_Articulos.Enabled = false;
            this.btn_Articulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Articulos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Articulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Articulos.ImageIndex = 2;
            this.btn_Articulos.ImageList = this.imageList1;
            this.btn_Articulos.Location = new System.Drawing.Point(3, 173);
            this.btn_Articulos.Name = "btn_Articulos";
            this.btn_Articulos.Size = new System.Drawing.Size(155, 35);
            this.btn_Articulos.TabIndex = 3;
            this.btn_Articulos.Text = "Articulos";
            this.btn_Articulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Articulos.UseVisualStyleBackColor = false;
            this.btn_Articulos.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Articulos.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // btn_SubDepas
            // 
            this.btn_SubDepas.BackColor = System.Drawing.Color.White;
            this.btn_SubDepas.Enabled = false;
            this.btn_SubDepas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SubDepas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubDepas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SubDepas.ImageIndex = 1;
            this.btn_SubDepas.ImageList = this.imageList1;
            this.btn_SubDepas.Location = new System.Drawing.Point(3, 132);
            this.btn_SubDepas.Name = "btn_SubDepas";
            this.btn_SubDepas.Size = new System.Drawing.Size(155, 35);
            this.btn_SubDepas.TabIndex = 2;
            this.btn_SubDepas.Text = "SubDepartamentos";
            this.btn_SubDepas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SubDepas.UseVisualStyleBackColor = false;
            this.btn_SubDepas.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_SubDepas.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // txtb_Departamento
            // 
            this.txtb_Departamento.Enabled = false;
            this.txtb_Departamento.Location = new System.Drawing.Point(0, 46);
            this.txtb_Departamento.Name = "txtb_Departamento";
            this.txtb_Departamento.Size = new System.Drawing.Size(0, 0);
            this.txtb_Departamento.TabIndex = 1;
            this.txtb_Departamento.Text = "Departamento";
            this.txtb_Departamento.UseVisualStyleBackColor = true;
            // 
            // btn_Depas
            // 
            this.btn_Depas.BackColor = System.Drawing.Color.White;
            this.btn_Depas.Enabled = false;
            this.btn_Depas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Depas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Depas.ImageIndex = 0;
            this.btn_Depas.ImageList = this.imageList1;
            this.btn_Depas.Location = new System.Drawing.Point(3, 91);
            this.btn_Depas.Name = "btn_Depas";
            this.btn_Depas.Size = new System.Drawing.Size(155, 35);
            this.btn_Depas.TabIndex = 0;
            this.btn_Depas.Text = "Departamentos";
            this.btn_Depas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Depas.UseVisualStyleBackColor = false;
            this.btn_Depas.Click += new System.EventHandler(this.btn_Depas_Click);
            this.btn_Depas.MouseEnter += new System.EventHandler(this.btn_Depas_MouseEnter);
            this.btn_Depas.MouseLeave += new System.EventHandler(this.btn_Depas_MouseLeave);
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.White;
            this.pLogin.Controls.Add(this.label3);
            this.pLogin.Controls.Add(this.CheckB_Recordar);
            this.pLogin.Controls.Add(this.BtnCerrar);
            this.pLogin.Controls.Add(this.btnAceptar);
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.txtbContraseña);
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.Controls.Add(this.txtbUsuario);
            this.pLogin.Location = new System.Drawing.Point(437, 90);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(378, 200);
            this.pLogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(125, 0, 120, 0);
            this.label3.Size = new System.Drawing.Size(396, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Iniciar Sesion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckB_Recordar
            // 
            this.CheckB_Recordar.AutoSize = true;
            this.CheckB_Recordar.Location = new System.Drawing.Point(56, 152);
            this.CheckB_Recordar.Name = "CheckB_Recordar";
            this.CheckB_Recordar.Size = new System.Drawing.Size(115, 17);
            this.CheckB_Recordar.TabIndex = 10;
            this.CheckB_Recordar.Text = "Recordar Usuario?";
            this.CheckB_Recordar.UseVisualStyleBackColor = true;
            this.CheckB_Recordar.CheckedChanged += new System.EventHandler(this.CheckB_Recordar_CheckedChanged);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.ImageIndex = 12;
            this.BtnCerrar.ImageList = this.imageList1;
            this.BtnCerrar.Location = new System.Drawing.Point(273, 152);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(88, 40);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Salir";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.ImageIndex = 13;
            this.btnAceptar.ImageList = this.imageList1;
            this.btnAceptar.Location = new System.Drawing.Point(178, 152);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 40);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbContraseña.Location = new System.Drawing.Point(164, 94);
            this.txtbContraseña.Multiline = true;
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(197, 33);
            this.txtbContraseña.TabIndex = 2;
            this.txtbContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbContraseña_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.Location = new System.Drawing.Point(164, 36);
            this.txtbUsuario.Multiline = true;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(197, 33);
            this.txtbUsuario.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.panelBienvenida);
            this.panel2.Location = new System.Drawing.Point(27, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 814);
            this.panel2.TabIndex = 3;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Controls.Add(this.label4);
            this.panelBienvenida.Location = new System.Drawing.Point(200, 67);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(561, 322);
            this.panelBienvenida.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 322);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bienvenido a Sistema de Inventario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Sistema de inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Depas;
        private System.Windows.Forms.Button txtb_Departamento;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.CheckBox CheckB_Recordar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Configuracion;
        private System.Windows.Forms.Button btn_Empresa;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Salidas;
        private System.Windows.Forms.Button btn_Entradas;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Movimientos;
        private System.Windows.Forms.Button btn_Articulos;
        private System.Windows.Forms.Button btn_SubDepas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label label4;
    }
}

