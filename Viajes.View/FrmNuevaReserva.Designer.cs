namespace Viajes.View
{
    partial class FrmNuevaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaReserva));
            this.gbDatosReserva = new System.Windows.Forms.GroupBox();
            this.lblViaje = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbClienteReserva = new System.Windows.Forms.ComboBox();
            this.cbViajeReserva = new System.Windows.Forms.ComboBox();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.tsNuevaReserva = new System.Windows.Forms.ToolStrip();
            this.tsCrearNR = new System.Windows.Forms.ToolStripButton();
            this.tsAtrasNR = new System.Windows.Forms.ToolStripButton();
            this.pnNuevaReserva = new System.Windows.Forms.Panel();
            this.lblNuevaReserva = new System.Windows.Forms.Label();
            this.gbDatosReserva.SuspendLayout();
            this.tsNuevaReserva.SuspendLayout();
            this.pnNuevaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosReserva
            // 
            this.gbDatosReserva.Controls.Add(this.lblViaje);
            this.gbDatosReserva.Controls.Add(this.lblFecha);
            this.gbDatosReserva.Controls.Add(this.lblCliente);
            this.gbDatosReserva.Controls.Add(this.cbClienteReserva);
            this.gbDatosReserva.Controls.Add(this.cbViajeReserva);
            this.gbDatosReserva.Controls.Add(this.dtpFechaReserva);
            this.gbDatosReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosReserva.Location = new System.Drawing.Point(16, 120);
            this.gbDatosReserva.Name = "gbDatosReserva";
            this.gbDatosReserva.Size = new System.Drawing.Size(471, 176);
            this.gbDatosReserva.TabIndex = 54;
            this.gbDatosReserva.TabStop = false;
            this.gbDatosReserva.Text = "Datos de la Reserva";
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViaje.Location = new System.Drawing.Point(45, 83);
            this.lblViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(51, 23);
            this.lblViaje.TabIndex = 24;
            this.lblViaje.Text = "Viaje:";
            this.lblViaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(39, 130);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 23);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(29, 35);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(67, 23);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbClienteReserva
            // 
            this.cbClienteReserva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClienteReserva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbClienteReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClienteReserva.FormattingEnabled = true;
            this.cbClienteReserva.Location = new System.Drawing.Point(108, 29);
            this.cbClienteReserva.Name = "cbClienteReserva";
            this.cbClienteReserva.Size = new System.Drawing.Size(330, 31);
            this.cbClienteReserva.TabIndex = 1;
            // 
            // cbViajeReserva
            // 
            this.cbViajeReserva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbViajeReserva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbViajeReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViajeReserva.FormattingEnabled = true;
            this.cbViajeReserva.Location = new System.Drawing.Point(108, 77);
            this.cbViajeReserva.Name = "cbViajeReserva";
            this.cbViajeReserva.Size = new System.Drawing.Size(330, 31);
            this.cbViajeReserva.TabIndex = 2;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaReserva.Location = new System.Drawing.Point(108, 125);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(330, 30);
            this.dtpFechaReserva.TabIndex = 3;
            this.dtpFechaReserva.Value = new System.DateTime(2025, 12, 5, 12, 59, 20, 0);
            // 
            // tsNuevaReserva
            // 
            this.tsNuevaReserva.BackColor = System.Drawing.SystemColors.Control;
            this.tsNuevaReserva.Dock = System.Windows.Forms.DockStyle.None;
            this.tsNuevaReserva.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsNuevaReserva.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsNuevaReserva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCrearNR,
            this.tsAtrasNR});
            this.tsNuevaReserva.Location = new System.Drawing.Point(13, 56);
            this.tsNuevaReserva.Name = "tsNuevaReserva";
            this.tsNuevaReserva.ShowItemToolTips = false;
            this.tsNuevaReserva.Size = new System.Drawing.Size(115, 47);
            this.tsNuevaReserva.TabIndex = 53;
            this.tsNuevaReserva.Text = "Barra de herramientas Agregar Vehículo";
            // 
            // tsCrearNR
            // 
            this.tsCrearNR.AutoSize = false;
            this.tsCrearNR.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCrearNR.Image = ((System.Drawing.Image)(resources.GetObject("tsCrearNR.Image")));
            this.tsCrearNR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCrearNR.Name = "tsCrearNR";
            this.tsCrearNR.Size = new System.Drawing.Size(56, 44);
            this.tsCrearNR.Text = "Crear";
            this.tsCrearNR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCrearNR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCrearNR.Click += new System.EventHandler(this.AgregarReserva_Click);
            // 
            // tsAtrasNR
            // 
            this.tsAtrasNR.AutoSize = false;
            this.tsAtrasNR.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtrasNR.Image = ((System.Drawing.Image)(resources.GetObject("tsAtrasNR.Image")));
            this.tsAtrasNR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtrasNR.Name = "tsAtrasNR";
            this.tsAtrasNR.Size = new System.Drawing.Size(56, 44);
            this.tsAtrasNR.Text = "Atrás";
            this.tsAtrasNR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAtrasNR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAtrasNR.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // pnNuevaReserva
            // 
            this.pnNuevaReserva.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnNuevaReserva.Controls.Add(this.lblNuevaReserva);
            this.pnNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.pnNuevaReserva.Location = new System.Drawing.Point(1, 0);
            this.pnNuevaReserva.Name = "pnNuevaReserva";
            this.pnNuevaReserva.Size = new System.Drawing.Size(500, 44);
            this.pnNuevaReserva.TabIndex = 52;
            // 
            // lblNuevaReserva
            // 
            this.lblNuevaReserva.AutoSize = true;
            this.lblNuevaReserva.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaReserva.Location = new System.Drawing.Point(166, 5);
            this.lblNuevaReserva.Name = "lblNuevaReserva";
            this.lblNuevaReserva.Size = new System.Drawing.Size(158, 31);
            this.lblNuevaReserva.TabIndex = 16;
            this.lblNuevaReserva.Text = "Crear Reserva";
            this.lblNuevaReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.gbDatosReserva);
            this.Controls.Add(this.tsNuevaReserva);
            this.Controls.Add(this.pnNuevaReserva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.FrmNuevaReserva_Load);
            this.gbDatosReserva.ResumeLayout(false);
            this.gbDatosReserva.PerformLayout();
            this.tsNuevaReserva.ResumeLayout(false);
            this.tsNuevaReserva.PerformLayout();
            this.pnNuevaReserva.ResumeLayout(false);
            this.pnNuevaReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosReserva;
        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ToolStrip tsNuevaReserva;
        private System.Windows.Forms.ToolStripButton tsCrearNR;
        private System.Windows.Forms.ToolStripButton tsAtrasNR;
        private System.Windows.Forms.Panel pnNuevaReserva;
        private System.Windows.Forms.Label lblNuevaReserva;
        private System.Windows.Forms.ComboBox cbClienteReserva;
        private System.Windows.Forms.ComboBox cbViajeReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
    }
}