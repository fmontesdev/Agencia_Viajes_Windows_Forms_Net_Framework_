namespace Viajes.View
{
    partial class FrmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            this.ssReservas = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblValorTotalReservas = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.gpListaReservas = new System.Windows.Forms.GroupBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.tsReservas = new System.Windows.Forms.ToolStrip();
            this.tsCrearReserva = new System.Windows.Forms.ToolStripButton();
            this.tsEditarReserva = new System.Windows.Forms.ToolStripButton();
            this.tsCancelarReserva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAtrasReserva = new System.Windows.Forms.ToolStripButton();
            this.pnReservas = new System.Windows.Forms.Panel();
            this.lblReservas = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBuscarViajeReserva = new System.Windows.Forms.TextBox();
            this.lblViajeReserva = new System.Windows.Forms.Label();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.txtBuscarClienteReserva = new System.Windows.Forms.TextBox();
            this.lblClienteReserva = new System.Windows.Forms.Label();
            this.gbReserva = new System.Windows.Forms.GroupBox();
            this.lblViaje = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.pnClienteReserva = new System.Windows.Forms.Panel();
            this.lblValorClienteReserva = new System.Windows.Forms.Label();
            this.pnViajeReserva = new System.Windows.Forms.Panel();
            this.lblValorViajeReserva = new System.Windows.Forms.Label();
            this.ssReservas.SuspendLayout();
            this.gpListaReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.tsReservas.SuspendLayout();
            this.pnReservas.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.gbReserva.SuspendLayout();
            this.pnClienteReserva.SuspendLayout();
            this.pnViajeReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssReservas
            // 
            this.ssReservas.BackColor = System.Drawing.Color.DarkGray;
            this.ssReservas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssReservas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssReservas.Location = new System.Drawing.Point(0, 824);
            this.ssReservas.Name = "ssReservas";
            this.ssReservas.Size = new System.Drawing.Size(932, 26);
            this.ssReservas.TabIndex = 57;
            this.ssReservas.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslStatus.ForeColor = System.Drawing.Color.White;
            this.tsslStatus.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(53, 20);
            this.tsslStatus.Text = "Status";
            // 
            // lblValorTotalReservas
            // 
            this.lblValorTotalReservas.AutoSize = true;
            this.lblValorTotalReservas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalReservas.Location = new System.Drawing.Point(183, 788);
            this.lblValorTotalReservas.Name = "lblValorTotalReservas";
            this.lblValorTotalReservas.Size = new System.Drawing.Size(24, 28);
            this.lblValorTotalReservas.TabIndex = 56;
            this.lblValorTotalReservas.Text = "0";
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReservas.Location = new System.Drawing.Point(13, 790);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(153, 23);
            this.lblTotalReservas.TabIndex = 55;
            this.lblTotalReservas.Text = "Total de Reservas:";
            // 
            // gpListaReservas
            // 
            this.gpListaReservas.Controls.Add(this.dgvReservas);
            this.gpListaReservas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaReservas.Location = new System.Drawing.Point(16, 349);
            this.gpListaReservas.Name = "gpListaReservas";
            this.gpListaReservas.Size = new System.Drawing.Size(900, 432);
            this.gpListaReservas.TabIndex = 54;
            this.gpListaReservas.TabStop = false;
            this.gpListaReservas.Text = "Lista de Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(0, 32);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReservas.MultiSelect = false;
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.Size = new System.Drawing.Size(900, 400);
            this.dgvReservas.TabIndex = 4;
            // 
            // tsReservas
            // 
            this.tsReservas.BackColor = System.Drawing.SystemColors.Control;
            this.tsReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsReservas.Dock = System.Windows.Forms.DockStyle.None;
            this.tsReservas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsReservas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsReservas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCrearReserva,
            this.tsEditarReserva,
            this.tsCancelarReserva,
            this.toolStripSeparator1,
            this.tsAtrasReserva});
            this.tsReservas.Location = new System.Drawing.Point(13, 56);
            this.tsReservas.Name = "tsReservas";
            this.tsReservas.ShowItemToolTips = false;
            this.tsReservas.Size = new System.Drawing.Size(233, 47);
            this.tsReservas.TabIndex = 52;
            // 
            // tsCrearReserva
            // 
            this.tsCrearReserva.AutoSize = false;
            this.tsCrearReserva.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCrearReserva.Image = ((System.Drawing.Image)(resources.GetObject("tsCrearReserva.Image")));
            this.tsCrearReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCrearReserva.Name = "tsCrearReserva";
            this.tsCrearReserva.Size = new System.Drawing.Size(56, 44);
            this.tsCrearReserva.Text = "Nueva";
            this.tsCrearReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCrearReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCrearReserva.Click += new System.EventHandler(this.CrearReserva_Click);
            // 
            // tsEditarReserva
            // 
            this.tsEditarReserva.AutoSize = false;
            this.tsEditarReserva.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEditarReserva.Image = ((System.Drawing.Image)(resources.GetObject("tsEditarReserva.Image")));
            this.tsEditarReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarReserva.Name = "tsEditarReserva";
            this.tsEditarReserva.Size = new System.Drawing.Size(56, 44);
            this.tsEditarReserva.Text = "Edita";
            this.tsEditarReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEditarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEditarReserva.Click += new System.EventHandler(this.EditarReserva_Click);
            // 
            // tsCancelarReserva
            // 
            this.tsCancelarReserva.AutoSize = false;
            this.tsCancelarReserva.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCancelarReserva.Image = ((System.Drawing.Image)(resources.GetObject("tsCancelarReserva.Image")));
            this.tsCancelarReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancelarReserva.Name = "tsCancelarReserva";
            this.tsCancelarReserva.Size = new System.Drawing.Size(56, 44);
            this.tsCancelarReserva.Text = "Cancela";
            this.tsCancelarReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCancelarReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCancelarReserva.Click += new System.EventHandler(this.EliminarReserva_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tsAtrasReserva
            // 
            this.tsAtrasReserva.AutoSize = false;
            this.tsAtrasReserva.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtrasReserva.Image = ((System.Drawing.Image)(resources.GetObject("tsAtrasReserva.Image")));
            this.tsAtrasReserva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtrasReserva.Name = "tsAtrasReserva";
            this.tsAtrasReserva.Size = new System.Drawing.Size(56, 44);
            this.tsAtrasReserva.Text = "Ir atrás";
            this.tsAtrasReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAtrasReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAtrasReserva.Click += new System.EventHandler(this.FrmCerrar_Click);
            // 
            // pnReservas
            // 
            this.pnReservas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnReservas.Controls.Add(this.lblReservas);
            this.pnReservas.ForeColor = System.Drawing.Color.White;
            this.pnReservas.Location = new System.Drawing.Point(0, 0);
            this.pnReservas.Name = "pnReservas";
            this.pnReservas.Size = new System.Drawing.Size(932, 44);
            this.pnReservas.TabIndex = 51;
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.Location = new System.Drawing.Point(413, 5);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(106, 31);
            this.lblReservas.TabIndex = 16;
            this.lblReservas.Text = "Reservas";
            this.lblReservas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtBuscarViajeReserva);
            this.gbBusqueda.Controls.Add(this.lblViajeReserva);
            this.gbBusqueda.Controls.Add(this.btnLimpiarBusqueda);
            this.gbBusqueda.Controls.Add(this.txtBuscarClienteReserva);
            this.gbBusqueda.Controls.Add(this.lblClienteReserva);
            this.gbBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(16, 257);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(900, 80);
            this.gbBusqueda.TabIndex = 58;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar por";
            // 
            // txtBuscarViajeReserva
            // 
            this.txtBuscarViajeReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarViajeReserva.Location = new System.Drawing.Point(534, 28);
            this.txtBuscarViajeReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarViajeReserva.Name = "txtBuscarViajeReserva";
            this.txtBuscarViajeReserva.Size = new System.Drawing.Size(242, 30);
            this.txtBuscarViajeReserva.TabIndex = 2;
            // 
            // lblViajeReserva
            // 
            this.lblViajeReserva.AutoSize = true;
            this.lblViajeReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajeReserva.Location = new System.Drawing.Point(412, 32);
            this.lblViajeReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViajeReserva.Name = "lblViajeReserva";
            this.lblViajeReserva.Size = new System.Drawing.Size(114, 23);
            this.lblViajeReserva.TabIndex = 42;
            this.lblViajeReserva.Text = "Destino Viaje:";
            this.lblViajeReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(795, 28);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(87, 33);
            this.btnLimpiarBusqueda.TabIndex = 3;
            this.btnLimpiarBusqueda.Text = "Limpiar";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.BtnLimpiarBusqueda_Click);
            // 
            // txtBuscarClienteReserva
            // 
            this.txtBuscarClienteReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClienteReserva.Location = new System.Drawing.Point(88, 28);
            this.txtBuscarClienteReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarClienteReserva.Name = "txtBuscarClienteReserva";
            this.txtBuscarClienteReserva.Size = new System.Drawing.Size(310, 30);
            this.txtBuscarClienteReserva.TabIndex = 1;
            // 
            // lblClienteReserva
            // 
            this.lblClienteReserva.AutoSize = true;
            this.lblClienteReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteReserva.Location = new System.Drawing.Point(13, 32);
            this.lblClienteReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteReserva.Name = "lblClienteReserva";
            this.lblClienteReserva.Size = new System.Drawing.Size(67, 23);
            this.lblClienteReserva.TabIndex = 40;
            this.lblClienteReserva.Text = "Cliente:";
            this.lblClienteReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbReserva
            // 
            this.gbReserva.Controls.Add(this.lblViaje);
            this.gbReserva.Controls.Add(this.lblCliente);
            this.gbReserva.Controls.Add(this.lblFechaReserva);
            this.gbReserva.Controls.Add(this.dtpFechaReserva);
            this.gbReserva.Controls.Add(this.pnClienteReserva);
            this.gbReserva.Controls.Add(this.pnViajeReserva);
            this.gbReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReserva.Location = new System.Drawing.Point(16, 120);
            this.gbReserva.Name = "gbReserva";
            this.gbReserva.Size = new System.Drawing.Size(900, 125);
            this.gbReserva.TabIndex = 59;
            this.gbReserva.TabStop = false;
            this.gbReserva.Text = "Datos de la Reserva";
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaje.Location = new System.Drawing.Point(505, 32);
            this.lblViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(51, 23);
            this.lblViaje.TabIndex = 30;
            this.lblViaje.Text = "Viaje:";
            this.lblViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(101, 32);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 23);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(22, 79);
            this.lblFechaReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(145, 23);
            this.lblFechaReserva.TabIndex = 39;
            this.lblFechaReserva.Text = "Fecha de Reserva:";
            this.lblFechaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.Location = new System.Drawing.Point(180, 75);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(325, 30);
            this.dtpFechaReserva.TabIndex = 94;
            this.dtpFechaReserva.Value = new System.DateTime(2025, 12, 5, 12, 59, 20, 0);
            // 
            // pnClienteReserva
            // 
            this.pnClienteReserva.BackColor = System.Drawing.Color.OliveDrab;
            this.pnClienteReserva.Controls.Add(this.lblValorClienteReserva);
            this.pnClienteReserva.Location = new System.Drawing.Point(180, 27);
            this.pnClienteReserva.Name = "pnClienteReserva";
            this.pnClienteReserva.Size = new System.Drawing.Size(300, 30);
            this.pnClienteReserva.TabIndex = 97;
            // 
            // lblValorClienteReserva
            // 
            this.lblValorClienteReserva.AutoSize = true;
            this.lblValorClienteReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorClienteReserva.ForeColor = System.Drawing.Color.White;
            this.lblValorClienteReserva.Location = new System.Drawing.Point(5, 3);
            this.lblValorClienteReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorClienteReserva.Name = "lblValorClienteReserva";
            this.lblValorClienteReserva.Size = new System.Drawing.Size(66, 23);
            this.lblValorClienteReserva.TabIndex = 99;
            this.lblValorClienteReserva.Text = "Cliente";
            this.lblValorClienteReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnViajeReserva
            // 
            this.pnViajeReserva.BackColor = System.Drawing.Color.OliveDrab;
            this.pnViajeReserva.Controls.Add(this.lblValorViajeReserva);
            this.pnViajeReserva.Location = new System.Drawing.Point(568, 27);
            this.pnViajeReserva.Name = "pnViajeReserva";
            this.pnViajeReserva.Size = new System.Drawing.Size(300, 30);
            this.pnViajeReserva.TabIndex = 98;
            // 
            // lblValorViajeReserva
            // 
            this.lblValorViajeReserva.AutoSize = true;
            this.lblValorViajeReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorViajeReserva.ForeColor = System.Drawing.Color.White;
            this.lblValorViajeReserva.Location = new System.Drawing.Point(5, 3);
            this.lblValorViajeReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorViajeReserva.Name = "lblValorViajeReserva";
            this.lblValorViajeReserva.Size = new System.Drawing.Size(49, 23);
            this.lblValorViajeReserva.TabIndex = 100;
            this.lblValorViajeReserva.Text = "Viaje";
            this.lblValorViajeReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 850);
            this.Controls.Add(this.gbReserva);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.ssReservas);
            this.Controls.Add(this.lblValorTotalReservas);
            this.Controls.Add(this.lblTotalReservas);
            this.Controls.Add(this.gpListaReservas);
            this.Controls.Add(this.tsReservas);
            this.Controls.Add(this.pnReservas);
            this.MaximizeBox = false;
            this.Name = "FrmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            this.ssReservas.ResumeLayout(false);
            this.ssReservas.PerformLayout();
            this.gpListaReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.tsReservas.ResumeLayout(false);
            this.tsReservas.PerformLayout();
            this.pnReservas.ResumeLayout(false);
            this.pnReservas.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbReserva.ResumeLayout(false);
            this.gbReserva.PerformLayout();
            this.pnClienteReserva.ResumeLayout(false);
            this.pnClienteReserva.PerformLayout();
            this.pnViajeReserva.ResumeLayout(false);
            this.pnViajeReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssReservas;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label lblValorTotalReservas;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.GroupBox gpListaReservas;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.ToolStrip tsReservas;
        private System.Windows.Forms.ToolStripButton tsCrearReserva;
        private System.Windows.Forms.ToolStripButton tsCancelarReserva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsAtrasReserva;
        private System.Windows.Forms.Panel pnReservas;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TextBox txtBuscarClienteReserva;
        private System.Windows.Forms.Label lblClienteReserva;
        private System.Windows.Forms.TextBox txtBuscarViajeReserva;
        private System.Windows.Forms.Label lblViajeReserva;
        private System.Windows.Forms.GroupBox gbReserva;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.ToolStripButton tsEditarReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label lblValorClienteReserva;
        private System.Windows.Forms.Panel pnClienteReserva;
        private System.Windows.Forms.Panel pnViajeReserva;
        private System.Windows.Forms.Label lblValorViajeReserva;
    }
}