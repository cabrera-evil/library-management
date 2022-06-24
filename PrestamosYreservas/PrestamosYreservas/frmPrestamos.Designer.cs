namespace PrestamosYreservas
{
    partial class frmPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabReservas = new System.Windows.Forms.TabPage();
            this.tabPrestamos = new System.Windows.Forms.TabPage();
            this.btnCancelarPre = new System.Windows.Forms.Button();
            this.btnAceptarPres = new System.Windows.Forms.Button();
            this.grbDevolucionPres = new System.Windows.Forms.GroupBox();
            this.dtpFechaDevo = new System.Windows.Forms.DateTimePicker();
            this.lblHoraDevolución = new System.Windows.Forms.Label();
            this.lblFechaDevo = new System.Windows.Forms.Label();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.txtTituloE = new System.Windows.Forms.TextBox();
            this.lblNomU = new System.Windows.Forms.Label();
            this.txtHistorialPres = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lbltituloPrestamos = new System.Windows.Forms.Label();
            this.txtUR = new System.Windows.Forms.TextBox();
            this.lblUR = new System.Windows.Forms.Label();
            this.txtNombreUR = new System.Windows.Forms.TextBox();
            this.txtEjemplarReserva = new System.Windows.Forms.TextBox();
            this.lblNombreUR = new System.Windows.Forms.Label();
            this.txtCodigoRes = new System.Windows.Forms.TextBox();
            this.lblCodigoER = new System.Windows.Forms.Label();
            this.lblTituloER = new System.Windows.Forms.Label();
            this.lblTituloReservas = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnAceptarReserva = new System.Windows.Forms.Button();
            this.grbFyHReservasDevo = new System.Windows.Forms.GroupBox();
            this.dtpfechaDevReserva = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbFyHReservas = new System.Windows.Forms.GroupBox();
            this.dtpfechaMaxReserva = new System.Windows.Forms.DateTimePicker();
            this.lblFechaMaxReserva = new System.Windows.Forms.Label();
            this.dtpfechareserva = new System.Windows.Forms.DateTimePicker();
            this.lblhorareserva = new System.Windows.Forms.Label();
            this.lblfechareserva = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabReservas.SuspendLayout();
            this.tabPrestamos.SuspendLayout();
            this.grbDevolucionPres.SuspendLayout();
            this.grbFechas.SuspendLayout();
            this.grbFyHReservasDevo.SuspendLayout();
            this.grbFyHReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabReservas);
            this.tabMenu.Controls.Add(this.tabPrestamos);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1006, 414);
            this.tabMenu.TabIndex = 0;
            // 
            // tabReservas
            // 
            this.tabReservas.Controls.Add(this.btnCancelarReserva);
            this.tabReservas.Controls.Add(this.btnAceptarReserva);
            this.tabReservas.Controls.Add(this.grbFyHReservasDevo);
            this.tabReservas.Controls.Add(this.grbFyHReservas);
            this.tabReservas.Controls.Add(this.txtUR);
            this.tabReservas.Controls.Add(this.lblUR);
            this.tabReservas.Controls.Add(this.txtNombreUR);
            this.tabReservas.Controls.Add(this.txtEjemplarReserva);
            this.tabReservas.Controls.Add(this.lblNombreUR);
            this.tabReservas.Controls.Add(this.txtCodigoRes);
            this.tabReservas.Controls.Add(this.lblCodigoER);
            this.tabReservas.Controls.Add(this.lblTituloER);
            this.tabReservas.Controls.Add(this.lblTituloReservas);
            this.tabReservas.Location = new System.Drawing.Point(4, 25);
            this.tabReservas.Name = "tabReservas";
            this.tabReservas.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservas.Size = new System.Drawing.Size(998, 385);
            this.tabReservas.TabIndex = 0;
            this.tabReservas.Text = "Reservas";
            this.tabReservas.UseVisualStyleBackColor = true;
            // 
            // tabPrestamos
            // 
            this.tabPrestamos.Controls.Add(this.btnCancelarPre);
            this.tabPrestamos.Controls.Add(this.btnAceptarPres);
            this.tabPrestamos.Controls.Add(this.grbDevolucionPres);
            this.tabPrestamos.Controls.Add(this.grbFechas);
            this.tabPrestamos.Controls.Add(this.txtUser);
            this.tabPrestamos.Controls.Add(this.lblUser);
            this.tabPrestamos.Controls.Add(this.txtNombreU);
            this.tabPrestamos.Controls.Add(this.txtTituloE);
            this.tabPrestamos.Controls.Add(this.lblNomU);
            this.tabPrestamos.Controls.Add(this.txtHistorialPres);
            this.tabPrestamos.Controls.Add(this.lblHistorial);
            this.tabPrestamos.Controls.Add(this.txtCodigoE);
            this.tabPrestamos.Controls.Add(this.lblCodigo);
            this.tabPrestamos.Controls.Add(this.lblTituloLibro);
            this.tabPrestamos.Controls.Add(this.lbltituloPrestamos);
            this.tabPrestamos.Location = new System.Drawing.Point(4, 25);
            this.tabPrestamos.Name = "tabPrestamos";
            this.tabPrestamos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamos.Size = new System.Drawing.Size(998, 385);
            this.tabPrestamos.TabIndex = 1;
            this.tabPrestamos.Text = "Prestamos";
            this.tabPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPre
            // 
            this.btnCancelarPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPre.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPre.Location = new System.Drawing.Point(837, 348);
            this.btnCancelarPre.Name = "btnCancelarPre";
            this.btnCancelarPre.Size = new System.Drawing.Size(95, 31);
            this.btnCancelarPre.TabIndex = 28;
            this.btnCancelarPre.Text = "Cancelar";
            this.btnCancelarPre.UseVisualStyleBackColor = true;
            // 
            // btnAceptarPres
            // 
            this.btnAceptarPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPres.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarPres.Location = new System.Drawing.Point(663, 348);
            this.btnAceptarPres.Name = "btnAceptarPres";
            this.btnAceptarPres.Size = new System.Drawing.Size(95, 31);
            this.btnAceptarPres.TabIndex = 27;
            this.btnAceptarPres.Text = "Aceptar";
            this.btnAceptarPres.UseVisualStyleBackColor = true;
            // 
            // grbDevolucionPres
            // 
            this.grbDevolucionPres.Controls.Add(this.dtpFechaDevo);
            this.grbDevolucionPres.Controls.Add(this.lblHoraDevolución);
            this.grbDevolucionPres.Controls.Add(this.lblFechaDevo);
            this.grbDevolucionPres.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDevolucionPres.Location = new System.Drawing.Point(618, 191);
            this.grbDevolucionPres.Name = "grbDevolucionPres";
            this.grbDevolucionPres.Size = new System.Drawing.Size(350, 153);
            this.grbDevolucionPres.TabIndex = 22;
            this.grbDevolucionPres.TabStop = false;
            this.grbDevolucionPres.Text = "Devolución:";
            // 
            // dtpFechaDevo
            // 
            this.dtpFechaDevo.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDevo.CustomFormat = "";
            this.dtpFechaDevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaDevo.Location = new System.Drawing.Point(66, 51);
            this.dtpFechaDevo.Name = "dtpFechaDevo";
            this.dtpFechaDevo.Size = new System.Drawing.Size(278, 24);
            this.dtpFechaDevo.TabIndex = 28;
            this.dtpFechaDevo.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // lblHoraDevolución
            // 
            this.lblHoraDevolución.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDevolución.Location = new System.Drawing.Point(4, 84);
            this.lblHoraDevolución.Name = "lblHoraDevolución";
            this.lblHoraDevolución.Size = new System.Drawing.Size(56, 26);
            this.lblHoraDevolución.TabIndex = 29;
            this.lblHoraDevolución.Text = "Hora:";
            // 
            // lblFechaDevo
            // 
            this.lblFechaDevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevo.Location = new System.Drawing.Point(4, 51);
            this.lblFechaDevo.Name = "lblFechaDevo";
            this.lblFechaDevo.Size = new System.Drawing.Size(56, 26);
            this.lblFechaDevo.TabIndex = 27;
            this.lblFechaDevo.Text = "Fecha:";
            // 
            // grbFechas
            // 
            this.grbFechas.Controls.Add(this.dtpFechaLimite);
            this.grbFechas.Controls.Add(this.lblFechaLimite);
            this.grbFechas.Controls.Add(this.dtpFechaPrestamo);
            this.grbFechas.Controls.Add(this.lblHora);
            this.grbFechas.Controls.Add(this.lblFecha);
            this.grbFechas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFechas.Location = new System.Drawing.Point(616, 45);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(352, 140);
            this.grbFechas.TabIndex = 21;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Fecha y hora:";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.CustomFormat = "";
            this.dtpFechaLimite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaLimite.Location = new System.Drawing.Point(68, 92);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(278, 24);
            this.dtpFechaLimite.TabIndex = 26;
            this.dtpFechaLimite.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.Location = new System.Drawing.Point(6, 92);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(56, 26);
            this.lblFechaLimite.TabIndex = 25;
            this.lblFechaLimite.Text = "Fecha:";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrestamo.CustomFormat = "";
            this.dtpFechaPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(68, 30);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(278, 24);
            this.dtpFechaPrestamo.TabIndex = 23;
            this.dtpFechaPrestamo.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(6, 63);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 26);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 30);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 26);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(177, 79);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(393, 22);
            this.txtUser.TabIndex = 20;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(8, 75);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(209, 26);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = "User:";
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(177, 45);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(393, 22);
            this.txtNombreU.TabIndex = 18;
            // 
            // txtTituloE
            // 
            this.txtTituloE.Location = new System.Drawing.Point(178, 112);
            this.txtTituloE.Name = "txtTituloE";
            this.txtTituloE.Size = new System.Drawing.Size(393, 22);
            this.txtTituloE.TabIndex = 16;
            // 
            // lblNomU
            // 
            this.lblNomU.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomU.Location = new System.Drawing.Point(8, 42);
            this.lblNomU.Name = "lblNomU";
            this.lblNomU.Size = new System.Drawing.Size(209, 26);
            this.lblNomU.TabIndex = 15;
            this.lblNomU.Text = "Nombre del usuario:";
            // 
            // txtHistorialPres
            // 
            this.txtHistorialPres.Location = new System.Drawing.Point(7, 254);
            this.txtHistorialPres.Multiline = true;
            this.txtHistorialPres.Name = "txtHistorialPres";
            this.txtHistorialPres.Size = new System.Drawing.Size(563, 123);
            this.txtHistorialPres.TabIndex = 14;
            // 
            // lblHistorial
            // 
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(8, 225);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(209, 26);
            this.lblHistorial.TabIndex = 13;
            this.lblHistorial.Text = "Historial de prestamos:";
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(178, 146);
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.Size = new System.Drawing.Size(393, 22);
            this.txtCodigoE.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 142);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(209, 26);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codigo del Ejemplar:";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.Location = new System.Drawing.Point(8, 108);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(209, 26);
            this.lblTituloLibro.TabIndex = 5;
            this.lblTituloLibro.Text = "Titulo del ejemplar:";
            // 
            // lbltituloPrestamos
            // 
            this.lbltituloPrestamos.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloPrestamos.Location = new System.Drawing.Point(7, 14);
            this.lbltituloPrestamos.Name = "lbltituloPrestamos";
            this.lbltituloPrestamos.Size = new System.Drawing.Size(266, 28);
            this.lbltituloPrestamos.TabIndex = 0;
            this.lbltituloPrestamos.Text = "Registro de prestamos:";
            // 
            // txtUR
            // 
            this.txtUR.Location = new System.Drawing.Point(178, 78);
            this.txtUR.Name = "txtUR";
            this.txtUR.Size = new System.Drawing.Size(393, 22);
            this.txtUR.TabIndex = 31;
            // 
            // lblUR
            // 
            this.lblUR.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUR.Location = new System.Drawing.Point(9, 74);
            this.lblUR.Name = "lblUR";
            this.lblUR.Size = new System.Drawing.Size(209, 26);
            this.lblUR.TabIndex = 30;
            this.lblUR.Text = "User:";
            // 
            // txtNombreUR
            // 
            this.txtNombreUR.Location = new System.Drawing.Point(178, 44);
            this.txtNombreUR.Name = "txtNombreUR";
            this.txtNombreUR.Size = new System.Drawing.Size(393, 22);
            this.txtNombreUR.TabIndex = 29;
            // 
            // txtEjemplarReserva
            // 
            this.txtEjemplarReserva.Location = new System.Drawing.Point(179, 111);
            this.txtEjemplarReserva.Name = "txtEjemplarReserva";
            this.txtEjemplarReserva.Size = new System.Drawing.Size(393, 22);
            this.txtEjemplarReserva.TabIndex = 28;
            // 
            // lblNombreUR
            // 
            this.lblNombreUR.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUR.Location = new System.Drawing.Point(9, 41);
            this.lblNombreUR.Name = "lblNombreUR";
            this.lblNombreUR.Size = new System.Drawing.Size(209, 26);
            this.lblNombreUR.TabIndex = 27;
            this.lblNombreUR.Text = "Nombre del usuario:";
            // 
            // txtCodigoRes
            // 
            this.txtCodigoRes.Location = new System.Drawing.Point(179, 145);
            this.txtCodigoRes.Name = "txtCodigoRes";
            this.txtCodigoRes.Size = new System.Drawing.Size(393, 22);
            this.txtCodigoRes.TabIndex = 24;
            // 
            // lblCodigoER
            // 
            this.lblCodigoER.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoER.Location = new System.Drawing.Point(9, 141);
            this.lblCodigoER.Name = "lblCodigoER";
            this.lblCodigoER.Size = new System.Drawing.Size(209, 26);
            this.lblCodigoER.TabIndex = 23;
            this.lblCodigoER.Text = "Codigo del Ejemplar:";
            // 
            // lblTituloER
            // 
            this.lblTituloER.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloER.Location = new System.Drawing.Point(9, 107);
            this.lblTituloER.Name = "lblTituloER";
            this.lblTituloER.Size = new System.Drawing.Size(209, 26);
            this.lblTituloER.TabIndex = 22;
            this.lblTituloER.Text = "Titulo del ejemplar:";
            // 
            // lblTituloReservas
            // 
            this.lblTituloReservas.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReservas.Location = new System.Drawing.Point(402, 13);
            this.lblTituloReservas.Name = "lblTituloReservas";
            this.lblTituloReservas.Size = new System.Drawing.Size(266, 28);
            this.lblTituloReservas.TabIndex = 21;
            this.lblTituloReservas.Text = "Registro de reservas:";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(880, 328);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(95, 31);
            this.btnCancelarReserva.TabIndex = 35;
            this.btnCancelarReserva.Text = "Cancelar";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnAceptarReserva
            // 
            this.btnAceptarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReserva.Location = new System.Drawing.Point(765, 328);
            this.btnAceptarReserva.Name = "btnAceptarReserva";
            this.btnAceptarReserva.Size = new System.Drawing.Size(95, 31);
            this.btnAceptarReserva.TabIndex = 34;
            this.btnAceptarReserva.Text = "Aceptar";
            this.btnAceptarReserva.UseVisualStyleBackColor = true;
            // 
            // grbFyHReservasDevo
            // 
            this.grbFyHReservasDevo.Controls.Add(this.dtpfechaDevReserva);
            this.grbFyHReservasDevo.Controls.Add(this.label3);
            this.grbFyHReservasDevo.Controls.Add(this.label7);
            this.grbFyHReservasDevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFyHReservasDevo.Location = new System.Drawing.Point(379, 219);
            this.grbFyHReservasDevo.Name = "grbFyHReservasDevo";
            this.grbFyHReservasDevo.Size = new System.Drawing.Size(358, 140);
            this.grbFyHReservasDevo.TabIndex = 33;
            this.grbFyHReservasDevo.TabStop = false;
            this.grbFyHReservasDevo.Text = "Devolución:";
            // 
            // dtpfechaDevReserva
            // 
            this.dtpfechaDevReserva.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaDevReserva.CustomFormat = "";
            this.dtpfechaDevReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfechaDevReserva.Location = new System.Drawing.Point(66, 51);
            this.dtpfechaDevReserva.Name = "dtpfechaDevReserva";
            this.dtpfechaDevReserva.Size = new System.Drawing.Size(278, 24);
            this.dtpfechaDevReserva.TabIndex = 28;
            this.dtpfechaDevReserva.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Hora:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha:";
            // 
            // grbFyHReservas
            // 
            this.grbFyHReservas.Controls.Add(this.dtpfechaMaxReserva);
            this.grbFyHReservas.Controls.Add(this.lblFechaMaxReserva);
            this.grbFyHReservas.Controls.Add(this.dtpfechareserva);
            this.grbFyHReservas.Controls.Add(this.lblhorareserva);
            this.grbFyHReservas.Controls.Add(this.lblfechareserva);
            this.grbFyHReservas.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFyHReservas.Location = new System.Drawing.Point(9, 219);
            this.grbFyHReservas.Name = "grbFyHReservas";
            this.grbFyHReservas.Size = new System.Drawing.Size(352, 140);
            this.grbFyHReservas.TabIndex = 32;
            this.grbFyHReservas.TabStop = false;
            this.grbFyHReservas.Text = "Fecha y hora:";
            // 
            // dtpfechaMaxReserva
            // 
            this.dtpfechaMaxReserva.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaMaxReserva.CustomFormat = "";
            this.dtpfechaMaxReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfechaMaxReserva.Location = new System.Drawing.Point(68, 92);
            this.dtpfechaMaxReserva.Name = "dtpfechaMaxReserva";
            this.dtpfechaMaxReserva.Size = new System.Drawing.Size(278, 24);
            this.dtpfechaMaxReserva.TabIndex = 26;
            this.dtpfechaMaxReserva.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // lblFechaMaxReserva
            // 
            this.lblFechaMaxReserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaMaxReserva.Location = new System.Drawing.Point(6, 92);
            this.lblFechaMaxReserva.Name = "lblFechaMaxReserva";
            this.lblFechaMaxReserva.Size = new System.Drawing.Size(56, 26);
            this.lblFechaMaxReserva.TabIndex = 25;
            this.lblFechaMaxReserva.Text = "Fecha:";
            // 
            // dtpfechareserva
            // 
            this.dtpfechareserva.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechareserva.CustomFormat = "";
            this.dtpfechareserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpfechareserva.Location = new System.Drawing.Point(68, 30);
            this.dtpfechareserva.Name = "dtpfechareserva";
            this.dtpfechareserva.Size = new System.Drawing.Size(278, 24);
            this.dtpfechareserva.TabIndex = 23;
            this.dtpfechareserva.Value = new System.DateTime(2022, 6, 23, 7, 33, 50, 0);
            // 
            // lblhorareserva
            // 
            this.lblhorareserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorareserva.Location = new System.Drawing.Point(6, 63);
            this.lblhorareserva.Name = "lblhorareserva";
            this.lblhorareserva.Size = new System.Drawing.Size(56, 26);
            this.lblhorareserva.TabIndex = 24;
            this.lblhorareserva.Text = "Hora:";
            // 
            // lblfechareserva
            // 
            this.lblfechareserva.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechareserva.Location = new System.Drawing.Point(6, 30);
            this.lblfechareserva.Name = "lblfechareserva";
            this.lblfechareserva.Size = new System.Drawing.Size(56, 26);
            this.lblfechareserva.TabIndex = 23;
            this.lblfechareserva.Text = "Fecha:";
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 414);
            this.Controls.Add(this.tabMenu);
            this.MaximizeBox = false;
            this.Name = "frmPrestamos";
            this.Text = "PrestamosReservas";
            this.tabMenu.ResumeLayout(false);
            this.tabReservas.ResumeLayout(false);
            this.tabReservas.PerformLayout();
            this.tabPrestamos.ResumeLayout(false);
            this.tabPrestamos.PerformLayout();
            this.grbDevolucionPres.ResumeLayout(false);
            this.grbFechas.ResumeLayout(false);
            this.grbFyHReservasDevo.ResumeLayout(false);
            this.grbFyHReservas.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnAceptarReserva;
        private System.Windows.Forms.GroupBox grbFyHReservasDevo;
        private System.Windows.Forms.DateTimePicker dtpfechaDevReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbFyHReservas;
        private System.Windows.Forms.DateTimePicker dtpfechaMaxReserva;
        private System.Windows.Forms.Label lblFechaMaxReserva;
        private System.Windows.Forms.DateTimePicker dtpfechareserva;
        private System.Windows.Forms.Label lblhorareserva;
        private System.Windows.Forms.Label lblfechareserva;

        private System.Windows.Forms.TextBox txtUR;
        private System.Windows.Forms.Label lblUR;
        private System.Windows.Forms.TextBox txtNombreUR;
        private System.Windows.Forms.TextBox txtEjemplarReserva;
        private System.Windows.Forms.Label lblNombreUR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoRes;
        private System.Windows.Forms.Label lblCodigoER;
        private System.Windows.Forms.Label lblTituloER;
        private System.Windows.Forms.Label lblTituloReservas;

        private System.Windows.Forms.Button btnCancelarPre;

        private System.Windows.Forms.Button btnAceptarPres;

        private System.Windows.Forms.DateTimePicker dtpFechaDevo;
        private System.Windows.Forms.Label lblHoraDevolución;
        private System.Windows.Forms.Label lblFechaDevo;

        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label lblFechaLimite;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;

        private System.Windows.Forms.Label lblHora;

        private System.Windows.Forms.GroupBox grbDevolucionPres;

        private System.Windows.Forms.GroupBox grbFechas;

        private System.Windows.Forms.Label lblNomU;
        private System.Windows.Forms.TextBox txtTituloE;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label lblUser;

        private System.Windows.Forms.TextBox txtUser;

        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lbltituloPrestamos;
        private System.Windows.Forms.TextBox txtHistorialPres;

        private System.Windows.Forms.Label lblHistorial;

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabReservas;
        private System.Windows.Forms.TabPage tabPrestamos;

        #endregion
    }
}