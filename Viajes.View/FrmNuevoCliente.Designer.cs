namespace Viajes.View
{
    partial class FrmNuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoCliente));
            this.pnNuevoCliente = new System.Windows.Forms.Panel();
            this.lblNuevoCliente = new System.Windows.Forms.Label();
            this.tsNuevoCliente = new System.Windows.Forms.ToolStrip();
            this.tsCrearNC = new System.Windows.Forms.ToolStripButton();
            this.tsAtrasNC = new System.Windows.Forms.ToolStripButton();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtCrearApellidos = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCrearEmail = new System.Windows.Forms.TextBox();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.pnNuevoCliente.SuspendLayout();
            this.tsNuevoCliente.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNuevoCliente
            // 
            this.pnNuevoCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.pnNuevoCliente.Controls.Add(this.lblNuevoCliente);
            this.pnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.pnNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.pnNuevoCliente.Name = "pnNuevoCliente";
            this.pnNuevoCliente.Size = new System.Drawing.Size(502, 44);
            this.pnNuevoCliente.TabIndex = 46;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCliente.Location = new System.Drawing.Point(174, 5);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(151, 31);
            this.lblNuevoCliente.TabIndex = 16;
            this.lblNuevoCliente.Text = "Crear Cliente";
            this.lblNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsNuevoCliente
            // 
            this.tsNuevoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.tsNuevoCliente.Dock = System.Windows.Forms.DockStyle.None;
            this.tsNuevoCliente.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsNuevoCliente.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsNuevoCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCrearNC,
            this.tsAtrasNC});
            this.tsNuevoCliente.Location = new System.Drawing.Point(13, 56);
            this.tsNuevoCliente.Name = "tsNuevoCliente";
            this.tsNuevoCliente.ShowItemToolTips = false;
            this.tsNuevoCliente.Size = new System.Drawing.Size(115, 47);
            this.tsNuevoCliente.TabIndex = 47;
            this.tsNuevoCliente.Text = "Barra de herramientas Agregar Vehículo";
            // 
            // tsCrearNC
            // 
            this.tsCrearNC.AutoSize = false;
            this.tsCrearNC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCrearNC.Image = ((System.Drawing.Image)(resources.GetObject("tsCrearNC.Image")));
            this.tsCrearNC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCrearNC.Name = "tsCrearNC";
            this.tsCrearNC.Size = new System.Drawing.Size(56, 44);
            this.tsCrearNC.Text = "Crear";
            this.tsCrearNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsCrearNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCrearNC.Click += new System.EventHandler(this.AgregarCiente_Click);
            // 
            // tsAtrasNC
            // 
            this.tsAtrasNC.AutoSize = false;
            this.tsAtrasNC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsAtrasNC.Image = ((System.Drawing.Image)(resources.GetObject("tsAtrasNC.Image")));
            this.tsAtrasNC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAtrasNC.Name = "tsAtrasNC";
            this.tsAtrasNC.Size = new System.Drawing.Size(56, 44);
            this.tsAtrasNC.Text = "Atrás";
            this.tsAtrasNC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAtrasNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAtrasNC.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.Controls.Add(this.lblApellidos);
            this.gbDatosCliente.Controls.Add(this.txtCrearApellidos);
            this.gbDatosCliente.Controls.Add(this.lblEmail);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.Controls.Add(this.txtCrearEmail);
            this.gbDatosCliente.Controls.Add(this.txtCrearNombre);
            this.gbDatosCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCliente.Location = new System.Drawing.Point(16, 120);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(471, 176);
            this.gbDatosCliente.TabIndex = 48;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos del Cliente";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(23, 82);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(83, 23);
            this.lblApellidos.TabIndex = 24;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCrearApellidos
            // 
            this.txtCrearApellidos.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearApellidos.Location = new System.Drawing.Point(118, 76);
            this.txtCrearApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrearApellidos.Name = "txtCrearApellidos";
            this.txtCrearApellidos.Size = new System.Drawing.Size(320, 30);
            this.txtCrearApellidos.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 129);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(30, 34);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 23);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCrearEmail
            // 
            this.txtCrearEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearEmail.Location = new System.Drawing.Point(118, 124);
            this.txtCrearEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrearEmail.Name = "txtCrearEmail";
            this.txtCrearEmail.Size = new System.Drawing.Size(320, 30);
            this.txtCrearEmail.TabIndex = 3;
            // 
            // txtCrearNombre
            // 
            this.txtCrearNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearNombre.Location = new System.Drawing.Point(118, 28);
            this.txtCrearNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrearNombre.Name = "txtCrearNombre";
            this.txtCrearNombre.Size = new System.Drawing.Size(320, 30);
            this.txtCrearNombre.TabIndex = 1;
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.tsNuevoCliente);
            this.Controls.Add(this.pnNuevoCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.pnNuevoCliente.ResumeLayout(false);
            this.pnNuevoCliente.PerformLayout();
            this.tsNuevoCliente.ResumeLayout(false);
            this.tsNuevoCliente.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNuevoCliente;
        private System.Windows.Forms.Label lblNuevoCliente;
        private System.Windows.Forms.ToolStrip tsNuevoCliente;
        private System.Windows.Forms.ToolStripButton tsCrearNC;
        private System.Windows.Forms.ToolStripButton tsAtrasNC;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtCrearApellidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCrearEmail;
        private System.Windows.Forms.TextBox txtCrearNombre;
    }
}