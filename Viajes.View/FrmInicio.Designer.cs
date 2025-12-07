namespace Viajes.View
{
    partial class FrmInicio
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
            this.pnInicio = new System.Windows.Forms.Panel();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.tlpEstadísticas = new System.Windows.Forms.TableLayoutPanel();
            this.pnTicketMedio = new System.Windows.Forms.Panel();
            this.lblValorTicketMedio = new System.Windows.Forms.Label();
            this.lblTicketMedio = new System.Windows.Forms.Label();
            this.pnTotalReservas = new System.Windows.Forms.Panel();
            this.lblValorTotalReservas = new System.Windows.Forms.Label();
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.pnTotalViajes = new System.Windows.Forms.Panel();
            this.lblValorTotalViajes = new System.Windows.Forms.Label();
            this.lblTotalViajes = new System.Windows.Forms.Label();
            this.pnTotalClientes = new System.Windows.Forms.Panel();
            this.lblValorTotalClientes = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnInicio.SuspendLayout();
            this.tlpEstadísticas.SuspendLayout();
            this.pnTicketMedio.SuspendLayout();
            this.pnTotalReservas.SuspendLayout();
            this.pnTotalViajes.SuspendLayout();
            this.pnTotalClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnInicio
            // 
            this.pnInicio.BackColor = System.Drawing.Color.SteelBlue;
            this.pnInicio.Controls.Add(this.lblAgencia);
            this.pnInicio.ForeColor = System.Drawing.Color.White;
            this.pnInicio.Location = new System.Drawing.Point(0, 0);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(502, 44);
            this.pnInicio.TabIndex = 45;
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Location = new System.Drawing.Point(138, 4);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(201, 31);
            this.lblAgencia.TabIndex = 16;
            this.lblAgencia.Text = "Agencia de Viajes";
            this.lblAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(106, 241);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(290, 55);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Ir a Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // tlpEstadísticas
            // 
            this.tlpEstadísticas.ColumnCount = 2;
            this.tlpEstadísticas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstadísticas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstadísticas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEstadísticas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEstadísticas.Controls.Add(this.pnTicketMedio, 1, 1);
            this.tlpEstadísticas.Controls.Add(this.pnTotalReservas, 0, 1);
            this.tlpEstadísticas.Controls.Add(this.pnTotalViajes, 1, 0);
            this.tlpEstadísticas.Controls.Add(this.pnTotalClientes, 0, 0);
            this.tlpEstadísticas.Location = new System.Drawing.Point(9, 64);
            this.tlpEstadísticas.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEstadísticas.Name = "tlpEstadísticas";
            this.tlpEstadísticas.RowCount = 2;
            this.tlpEstadísticas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstadísticas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEstadísticas.Size = new System.Drawing.Size(484, 158);
            this.tlpEstadísticas.TabIndex = 53;
            // 
            // pnTicketMedio
            // 
            this.pnTicketMedio.BackColor = System.Drawing.Color.White;
            this.pnTicketMedio.Controls.Add(this.lblValorTicketMedio);
            this.pnTicketMedio.Controls.Add(this.lblTicketMedio);
            this.pnTicketMedio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTicketMedio.Location = new System.Drawing.Point(250, 87);
            this.pnTicketMedio.Margin = new System.Windows.Forms.Padding(8);
            this.pnTicketMedio.Name = "pnTicketMedio";
            this.pnTicketMedio.Size = new System.Drawing.Size(226, 63);
            this.pnTicketMedio.TabIndex = 23;
            // 
            // lblValorTicketMedio
            // 
            this.lblValorTicketMedio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTicketMedio.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblValorTicketMedio.Location = new System.Drawing.Point(117, 11);
            this.lblValorTicketMedio.Name = "lblValorTicketMedio";
            this.lblValorTicketMedio.Size = new System.Drawing.Size(108, 40);
            this.lblValorTicketMedio.TabIndex = 14;
            this.lblValorTicketMedio.Text = "0";
            this.lblValorTicketMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTicketMedio
            // 
            this.lblTicketMedio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketMedio.ForeColor = System.Drawing.Color.Gray;
            this.lblTicketMedio.Location = new System.Drawing.Point(18, 3);
            this.lblTicketMedio.Name = "lblTicketMedio";
            this.lblTicketMedio.Size = new System.Drawing.Size(93, 56);
            this.lblTicketMedio.TabIndex = 13;
            this.lblTicketMedio.Text = "Ticket medio €:";
            this.lblTicketMedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnTotalReservas
            // 
            this.pnTotalReservas.BackColor = System.Drawing.Color.White;
            this.pnTotalReservas.Controls.Add(this.lblValorTotalReservas);
            this.pnTotalReservas.Controls.Add(this.lblTotalReservas);
            this.pnTotalReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTotalReservas.Location = new System.Drawing.Point(8, 87);
            this.pnTotalReservas.Margin = new System.Windows.Forms.Padding(8);
            this.pnTotalReservas.Name = "pnTotalReservas";
            this.pnTotalReservas.Size = new System.Drawing.Size(226, 63);
            this.pnTotalReservas.TabIndex = 22;
            // 
            // lblValorTotalReservas
            // 
            this.lblValorTotalReservas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalReservas.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblValorTotalReservas.Location = new System.Drawing.Point(114, 11);
            this.lblValorTotalReservas.Name = "lblValorTotalReservas";
            this.lblValorTotalReservas.Size = new System.Drawing.Size(108, 40);
            this.lblValorTotalReservas.TabIndex = 14;
            this.lblValorTotalReservas.Text = "0";
            this.lblValorTotalReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalReservas
            // 
            this.lblTotalReservas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReservas.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalReservas.Location = new System.Drawing.Point(8, 3);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(100, 56);
            this.lblTotalReservas.TabIndex = 13;
            this.lblTotalReservas.Text = "Total de Reservas:";
            this.lblTotalReservas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnTotalViajes
            // 
            this.pnTotalViajes.BackColor = System.Drawing.Color.White;
            this.pnTotalViajes.Controls.Add(this.lblValorTotalViajes);
            this.pnTotalViajes.Controls.Add(this.lblTotalViajes);
            this.pnTotalViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTotalViajes.Location = new System.Drawing.Point(250, 8);
            this.pnTotalViajes.Margin = new System.Windows.Forms.Padding(8);
            this.pnTotalViajes.Name = "pnTotalViajes";
            this.pnTotalViajes.Size = new System.Drawing.Size(226, 63);
            this.pnTotalViajes.TabIndex = 21;
            // 
            // lblValorTotalViajes
            // 
            this.lblValorTotalViajes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalViajes.ForeColor = System.Drawing.Color.Salmon;
            this.lblValorTotalViajes.Location = new System.Drawing.Point(117, 11);
            this.lblValorTotalViajes.Name = "lblValorTotalViajes";
            this.lblValorTotalViajes.Size = new System.Drawing.Size(108, 40);
            this.lblValorTotalViajes.TabIndex = 14;
            this.lblValorTotalViajes.Text = "0";
            this.lblValorTotalViajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalViajes
            // 
            this.lblTotalViajes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalViajes.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalViajes.Location = new System.Drawing.Point(18, 3);
            this.lblTotalViajes.Name = "lblTotalViajes";
            this.lblTotalViajes.Size = new System.Drawing.Size(93, 56);
            this.lblTotalViajes.TabIndex = 13;
            this.lblTotalViajes.Text = "Total de Viajes:";
            this.lblTotalViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnTotalClientes
            // 
            this.pnTotalClientes.BackColor = System.Drawing.Color.White;
            this.pnTotalClientes.Controls.Add(this.lblValorTotalClientes);
            this.pnTotalClientes.Controls.Add(this.lblTotalClientes);
            this.pnTotalClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTotalClientes.Location = new System.Drawing.Point(8, 8);
            this.pnTotalClientes.Margin = new System.Windows.Forms.Padding(8);
            this.pnTotalClientes.Name = "pnTotalClientes";
            this.pnTotalClientes.Size = new System.Drawing.Size(226, 63);
            this.pnTotalClientes.TabIndex = 19;
            // 
            // lblValorTotalClientes
            // 
            this.lblValorTotalClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalClientes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblValorTotalClientes.Location = new System.Drawing.Point(114, 11);
            this.lblValorTotalClientes.Name = "lblValorTotalClientes";
            this.lblValorTotalClientes.Size = new System.Drawing.Size(108, 40);
            this.lblValorTotalClientes.TabIndex = 14;
            this.lblValorTotalClientes.Text = "0";
            this.lblValorTotalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalClientes.Location = new System.Drawing.Point(8, 3);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(100, 56);
            this.lblTotalClientes.TabIndex = 13;
            this.lblTotalClientes.Text = "Total de clientes:";
            this.lblTotalClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnViajes
            // 
            this.btnViajes.BackColor = System.Drawing.Color.Salmon;
            this.btnViajes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViajes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViajes.FlatAppearance.BorderSize = 0;
            this.btnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajes.ForeColor = System.Drawing.Color.White;
            this.btnViajes.Location = new System.Drawing.Point(106, 304);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(290, 55);
            this.btnViajes.TabIndex = 2;
            this.btnViajes.Text = "Ir a Viajes";
            this.btnViajes.UseVisualStyleBackColor = false;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Location = new System.Drawing.Point(106, 367);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(290, 55);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Ir a Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(106, 431);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(290, 55);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 513);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnViajes);
            this.Controls.Add(this.tlpEstadísticas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.pnInicio);
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.pnInicio.ResumeLayout(false);
            this.pnInicio.PerformLayout();
            this.tlpEstadísticas.ResumeLayout(false);
            this.pnTicketMedio.ResumeLayout(false);
            this.pnTotalReservas.ResumeLayout(false);
            this.pnTotalViajes.ResumeLayout(false);
            this.pnTotalClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnInicio;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.TableLayoutPanel tlpEstadísticas;
        private System.Windows.Forms.Panel pnTotalViajes;
        private System.Windows.Forms.Label lblValorTotalViajes;
        private System.Windows.Forms.Label lblTotalViajes;
        private System.Windows.Forms.Panel pnTotalClientes;
        private System.Windows.Forms.Label lblValorTotalClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Panel pnTicketMedio;
        private System.Windows.Forms.Label lblValorTicketMedio;
        private System.Windows.Forms.Label lblTicketMedio;
        private System.Windows.Forms.Panel pnTotalReservas;
        private System.Windows.Forms.Label lblValorTotalReservas;
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.Button btnSalir;
    }
}

