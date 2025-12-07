namespace Viajes.View
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.pnClientes = new System.Windows.Forms.Panel();
            this.lblClientes = new System.Windows.Forms.Label();
            this.tsClientes = new System.Windows.Forms.ToolStrip();
            this.tsCrearCliente = new System.Windows.Forms.ToolStripButton();
            this.tsEditarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsEliminarCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReservasCliente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAtrasCliente = new System.Windows.Forms.ToolStripButton();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpListaClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblValorTotalClientes = new System.Windows.Forms.Label();
            this.ssClientes = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnClientes.SuspendLayout();
            this.tsClientes.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gpListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.ssClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnClientes
            // 
            this.pnClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.pnClientes.Controls.Add(this.lblClientes);
            this.pnClientes.ForeColor = System.Drawing.Color.White;
            this.pnClientes.Location = new System.Drawing.Point(0, 0);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Size = new System.Drawing.Size(932, 44);
            this.pnClientes.TabIndex = 44;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(421, 5);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(99, 31);
            this.lblClientes.TabIndex = 16;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsClientes
            // 
            this.tsClientes.BackColor = System.Drawing.SystemColors.Control;
            this.tsClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsClientes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsClientes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCrearCliente,
            this.tsEditarCliente,
            this.tsEliminarCliente,
            this.toolStripSeparator1,
            this.tsReservasCliente,
            this.toolStripSeparator2,
            this.tsAtrasCliente});
            this.tsClientes.Location = new System.Drawing.Point(13, 56);
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.ShowItemToolTips = false;
            this.tsClientes.Size = new System.Drawing.Size(329, 47);
            this.tsClientes.TabIndex = 45;
            // 
            // tsCrearCliente
            // 
            this.tsCrearCliente.AutoSize = false;
            this.tsCrearCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCrearCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsCrearCliente.Image")));
            this.tsCrearCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCrearCliente.Name = "tsCrearCliente";
            this.tsCrearCliente.Size = new System.Drawing.Size(56, 44);
            this.tsCrearCliente.Text = "Nuevo";
            this.tsCrearCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCrearCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCrearCliente.Click += new System.EventHandler(this.CrearCliente_Click);
            // 
            // tsEditarCliente
            // 
            this.tsEditarCliente.AutoSize = false;
            this.tsEditarCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsEditarCliente.Image")));
            this.tsEditarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarCliente.Name = "tsEditarCliente";
            this.tsEditarCliente.Size = new System.Drawing.Size(56, 44);
            this.tsEditarCliente.Text = "Edita";
            this.tsEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEditarCliente.Click += new System.EventHandler(this.EditarCliente_Click);
            // 
            // tsEliminarCliente
            // 
            this.tsEliminarCliente.AutoSize = false;
            this.tsEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminarCliente.Image")));
            this.tsEliminarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminarCliente.Name = "tsEliminarCliente";
            this.tsEliminarCliente.Size = new System.Drawing.Size(56, 44);
            this.tsEliminarCliente.Text = "Elimina";
            this.tsEliminarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tsReservasCliente
            // 
            this.tsReservasCliente.AutoSize = false;
            this.tsReservasCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReservasCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsReservasCliente.Image")));
            this.tsReservasCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReservasCliente.Name = "tsReservasCliente";
            this.tsReservasCliente.Size = new System.Drawing.Size(90, 44);
            this.tsReservasCliente.Text = "Ir a Reservas";
            this.tsReservasCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsReservasCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReservasCliente.Click += new System.EventHandler(this.ReservasCliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // tsAtrasCliente
            // 
            this.tsAtrasCliente.AutoSize = false;
            this.tsAtrasCliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtrasCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsAtrasCliente.Image")));
            this.tsAtrasCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtrasCliente.Name = "tsAtrasCliente";
            this.tsAtrasCliente.Size = new System.Drawing.Size(56, 44);
            this.tsAtrasCliente.Text = "Ir atrás";
            this.tsAtrasCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAtrasCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAtrasCliente.Click += new System.EventHandler(this.FrmCerrar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblEmail);
            this.gbCliente.Controls.Add(this.txtEmail);
            this.gbCliente.Controls.Add(this.lblApellidos);
            this.gbCliente.Controls.Add(this.txtApellidos);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(16, 120);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(900, 125);
            this.gbCliente.TabIndex = 46;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(41, 78);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(107, 74);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 30);
            this.txtEmail.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(420, 32);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(83, 23);
            this.lblApellidos.TabIndex = 30;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(513, 28);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(360, 30);
            this.txtApellidos.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 32);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(107, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // gpListaClientes
            // 
            this.gpListaClientes.Controls.Add(this.dgvClientes);
            this.gpListaClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaClientes.Location = new System.Drawing.Point(16, 257);
            this.gpListaClientes.Name = "gpListaClientes";
            this.gpListaClientes.Size = new System.Drawing.Size(900, 432);
            this.gpListaClientes.TabIndex = 47;
            this.gpListaClientes.TabStop = false;
            this.gpListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 32);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(900, 400);
            this.dgvClientes.TabIndex = 4;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(13, 698);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(147, 23);
            this.lblTotalClientes.TabIndex = 48;
            this.lblTotalClientes.Text = "Total de Clientes:";
            // 
            // lblValorTotalClientes
            // 
            this.lblValorTotalClientes.AutoSize = true;
            this.lblValorTotalClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalClientes.Location = new System.Drawing.Point(173, 695);
            this.lblValorTotalClientes.Name = "lblValorTotalClientes";
            this.lblValorTotalClientes.Size = new System.Drawing.Size(24, 28);
            this.lblValorTotalClientes.TabIndex = 49;
            this.lblValorTotalClientes.Text = "0";
            // 
            // ssClientes
            // 
            this.ssClientes.BackColor = System.Drawing.Color.DarkGray;
            this.ssClientes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssClientes.Location = new System.Drawing.Point(0, 731);
            this.ssClientes.Name = "ssClientes";
            this.ssClientes.Size = new System.Drawing.Size(932, 26);
            this.ssClientes.TabIndex = 50;
            this.ssClientes.Text = "statusStrip1";
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
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 757);
            this.Controls.Add(this.ssClientes);
            this.Controls.Add(this.lblValorTotalClientes);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.gpListaClientes);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.tsClientes);
            this.Controls.Add(this.pnClientes);
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnClientes.ResumeLayout(false);
            this.pnClientes.PerformLayout();
            this.tsClientes.ResumeLayout(false);
            this.tsClientes.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gpListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ssClientes.ResumeLayout(false);
            this.ssClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ToolStrip tsClientes;
        private System.Windows.Forms.ToolStripButton tsCrearCliente;
        private System.Windows.Forms.ToolStripButton tsEditarCliente;
        private System.Windows.Forms.ToolStripButton tsEliminarCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsAtrasCliente;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpListaClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label lblValorTotalClientes;
        private System.Windows.Forms.StatusStrip ssClientes;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripButton tsReservasCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}