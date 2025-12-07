namespace Viajes.View
{
    partial class FrmViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViajes));
            this.ssViajes = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblValorTotalViajes = new System.Windows.Forms.Label();
            this.lblTotalViajes = new System.Windows.Forms.Label();
            this.gpListaViajes = new System.Windows.Forms.GroupBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.gbViaje = new System.Windows.Forms.GroupBox();
            this.lblPlazas = new System.Windows.Forms.Label();
            this.txtPlazas = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.tsViajes = new System.Windows.Forms.ToolStrip();
            this.tsCrearViaje = new System.Windows.Forms.ToolStripButton();
            this.tsEditarViaje = new System.Windows.Forms.ToolStripButton();
            this.tsEliminarViaje = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReservasViaje = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAtrasViaje = new System.Windows.Forms.ToolStripButton();
            this.pnViajes = new System.Windows.Forms.Panel();
            this.lblViajes = new System.Windows.Forms.Label();
            this.ssViajes.SuspendLayout();
            this.gpListaViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.gbViaje.SuspendLayout();
            this.tsViajes.SuspendLayout();
            this.pnViajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssViajes
            // 
            this.ssViajes.BackColor = System.Drawing.Color.DarkGray;
            this.ssViajes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssViajes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssViajes.Location = new System.Drawing.Point(0, 684);
            this.ssViajes.Name = "ssViajes";
            this.ssViajes.Size = new System.Drawing.Size(932, 26);
            this.ssViajes.TabIndex = 57;
            this.ssViajes.Text = "statusStrip1";
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
            // lblValorTotalViajes
            // 
            this.lblValorTotalViajes.AutoSize = true;
            this.lblValorTotalViajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalViajes.Location = new System.Drawing.Point(154, 648);
            this.lblValorTotalViajes.Name = "lblValorTotalViajes";
            this.lblValorTotalViajes.Size = new System.Drawing.Size(24, 28);
            this.lblValorTotalViajes.TabIndex = 56;
            this.lblValorTotalViajes.Text = "0";
            // 
            // lblTotalViajes
            // 
            this.lblTotalViajes.AutoSize = true;
            this.lblTotalViajes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalViajes.Location = new System.Drawing.Point(13, 651);
            this.lblTotalViajes.Name = "lblTotalViajes";
            this.lblTotalViajes.Size = new System.Drawing.Size(130, 23);
            this.lblTotalViajes.TabIndex = 55;
            this.lblTotalViajes.Text = "Total de Viajes:";
            // 
            // gpListaViajes
            // 
            this.gpListaViajes.Controls.Add(this.dgvViajes);
            this.gpListaViajes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListaViajes.Location = new System.Drawing.Point(16, 210);
            this.gpListaViajes.Name = "gpListaViajes";
            this.gpListaViajes.Size = new System.Drawing.Size(900, 432);
            this.gpListaViajes.TabIndex = 54;
            this.gpListaViajes.TabStop = false;
            this.gpListaViajes.Text = "Lista de Viajes";
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(0, 32);
            this.dgvViajes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.RowHeadersWidth = 51;
            this.dgvViajes.Size = new System.Drawing.Size(900, 400);
            this.dgvViajes.TabIndex = 4;
            // 
            // gbViaje
            // 
            this.gbViaje.Controls.Add(this.lblPlazas);
            this.gbViaje.Controls.Add(this.txtPlazas);
            this.gbViaje.Controls.Add(this.lblPrecio);
            this.gbViaje.Controls.Add(this.txtPrecio);
            this.gbViaje.Controls.Add(this.lblDestino);
            this.gbViaje.Controls.Add(this.txtDestino);
            this.gbViaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbViaje.Location = new System.Drawing.Point(16, 120);
            this.gbViaje.Name = "gbViaje";
            this.gbViaje.Size = new System.Drawing.Size(900, 78);
            this.gbViaje.TabIndex = 53;
            this.gbViaje.TabStop = false;
            this.gbViaje.Text = "Datos del Viaje";
            // 
            // lblPlazas
            // 
            this.lblPlazas.AutoSize = true;
            this.lblPlazas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazas.Location = new System.Drawing.Point(690, 32);
            this.lblPlazas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlazas.Name = "lblPlazas";
            this.lblPlazas.Size = new System.Drawing.Size(61, 23);
            this.lblPlazas.TabIndex = 33;
            this.lblPlazas.Text = "Plazas:";
            this.lblPlazas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlazas
            // 
            this.txtPlazas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazas.Location = new System.Drawing.Point(762, 28);
            this.txtPlazas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlazas.Name = "txtPlazas";
            this.txtPlazas.Size = new System.Drawing.Size(100, 30);
            this.txtPlazas.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(448, 32);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 23);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(519, 28);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(140, 30);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(26, 32);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(72, 23);
            this.lblDestino.TabIndex = 37;
            this.lblDestino.Text = "Destino:";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(108, 28);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(310, 30);
            this.txtDestino.TabIndex = 1;
            // 
            // tsViajes
            // 
            this.tsViajes.BackColor = System.Drawing.SystemColors.Control;
            this.tsViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsViajes.Dock = System.Windows.Forms.DockStyle.None;
            this.tsViajes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsViajes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsViajes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCrearViaje,
            this.tsEditarViaje,
            this.tsEliminarViaje,
            this.toolStripSeparator2,
            this.tsReservasViaje,
            this.toolStripSeparator1,
            this.tsAtrasViaje});
            this.tsViajes.Location = new System.Drawing.Point(13, 56);
            this.tsViajes.Name = "tsViajes";
            this.tsViajes.ShowItemToolTips = false;
            this.tsViajes.Size = new System.Drawing.Size(329, 47);
            this.tsViajes.TabIndex = 52;
            // 
            // tsCrearViaje
            // 
            this.tsCrearViaje.AutoSize = false;
            this.tsCrearViaje.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCrearViaje.Image = ((System.Drawing.Image)(resources.GetObject("tsCrearViaje.Image")));
            this.tsCrearViaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCrearViaje.Name = "tsCrearViaje";
            this.tsCrearViaje.Size = new System.Drawing.Size(56, 44);
            this.tsCrearViaje.Text = "Nuevo";
            this.tsCrearViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCrearViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCrearViaje.Click += new System.EventHandler(this.CrearViaje_Click);
            // 
            // tsEditarViaje
            // 
            this.tsEditarViaje.AutoSize = false;
            this.tsEditarViaje.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEditarViaje.Image = ((System.Drawing.Image)(resources.GetObject("tsEditarViaje.Image")));
            this.tsEditarViaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditarViaje.Name = "tsEditarViaje";
            this.tsEditarViaje.Size = new System.Drawing.Size(56, 44);
            this.tsEditarViaje.Text = "Edita";
            this.tsEditarViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEditarViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEditarViaje.Click += new System.EventHandler(this.EditarViaje_Click);
            // 
            // tsEliminarViaje
            // 
            this.tsEliminarViaje.AutoSize = false;
            this.tsEliminarViaje.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEliminarViaje.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminarViaje.Image")));
            this.tsEliminarViaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminarViaje.Name = "tsEliminarViaje";
            this.tsEliminarViaje.Size = new System.Drawing.Size(56, 44);
            this.tsEliminarViaje.Text = "Elimina";
            this.tsEliminarViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsEliminarViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEliminarViaje.Click += new System.EventHandler(this.EliminarViaje_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // tsReservasViaje
            // 
            this.tsReservasViaje.AutoSize = false;
            this.tsReservasViaje.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsReservasViaje.Image = ((System.Drawing.Image)(resources.GetObject("tsReservasViaje.Image")));
            this.tsReservasViaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReservasViaje.Name = "tsReservasViaje";
            this.tsReservasViaje.Size = new System.Drawing.Size(90, 44);
            this.tsReservasViaje.Text = "Ir a Reservas";
            this.tsReservasViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsReservasViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReservasViaje.Click += new System.EventHandler(this.ReservasViaje_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tsAtrasViaje
            // 
            this.tsAtrasViaje.AutoSize = false;
            this.tsAtrasViaje.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtrasViaje.Image = ((System.Drawing.Image)(resources.GetObject("tsAtrasViaje.Image")));
            this.tsAtrasViaje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtrasViaje.Name = "tsAtrasViaje";
            this.tsAtrasViaje.Size = new System.Drawing.Size(56, 44);
            this.tsAtrasViaje.Text = "Ir atrás";
            this.tsAtrasViaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAtrasViaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAtrasViaje.Click += new System.EventHandler(this.FrmCerrar_Click);
            // 
            // pnViajes
            // 
            this.pnViajes.BackColor = System.Drawing.Color.Salmon;
            this.pnViajes.Controls.Add(this.lblViajes);
            this.pnViajes.ForeColor = System.Drawing.Color.White;
            this.pnViajes.Location = new System.Drawing.Point(0, 0);
            this.pnViajes.Name = "pnViajes";
            this.pnViajes.Size = new System.Drawing.Size(932, 44);
            this.pnViajes.TabIndex = 51;
            // 
            // lblViajes
            // 
            this.lblViajes.AutoSize = true;
            this.lblViajes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViajes.Location = new System.Drawing.Point(429, 5);
            this.lblViajes.Name = "lblViajes";
            this.lblViajes.Size = new System.Drawing.Size(77, 31);
            this.lblViajes.TabIndex = 16;
            this.lblViajes.Text = "Viajes";
            this.lblViajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 710);
            this.Controls.Add(this.ssViajes);
            this.Controls.Add(this.lblValorTotalViajes);
            this.Controls.Add(this.lblTotalViajes);
            this.Controls.Add(this.gpListaViajes);
            this.Controls.Add(this.gbViaje);
            this.Controls.Add(this.tsViajes);
            this.Controls.Add(this.pnViajes);
            this.MaximizeBox = false;
            this.Name = "FrmViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            this.ssViajes.ResumeLayout(false);
            this.ssViajes.PerformLayout();
            this.gpListaViajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.gbViaje.ResumeLayout(false);
            this.gbViaje.PerformLayout();
            this.tsViajes.ResumeLayout(false);
            this.tsViajes.PerformLayout();
            this.pnViajes.ResumeLayout(false);
            this.pnViajes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssViajes;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label lblValorTotalViajes;
        private System.Windows.Forms.Label lblTotalViajes;
        private System.Windows.Forms.GroupBox gpListaViajes;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.GroupBox gbViaje;
        private System.Windows.Forms.Label lblPlazas;
        private System.Windows.Forms.TextBox txtPlazas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.ToolStrip tsViajes;
        private System.Windows.Forms.ToolStripButton tsCrearViaje;
        private System.Windows.Forms.ToolStripButton tsEditarViaje;
        private System.Windows.Forms.ToolStripButton tsEliminarViaje;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsAtrasViaje;
        private System.Windows.Forms.Panel pnViajes;
        private System.Windows.Forms.Label lblViajes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsReservasViaje;
    }
}