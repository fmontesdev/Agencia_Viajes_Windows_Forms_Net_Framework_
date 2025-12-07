using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viajes.Controller;

namespace Viajes.View
{
    public partial class FrmNuevoCliente : Form
    {
        // Instancia del API de Clientes
        private readonly ClientesAPI _clientesApi;

        public FrmNuevoCliente(ClientesAPI api)
        {
            InitializeComponent();
            _clientesApi = api;
        }

        private async void AgregarCiente_Click(object sender, EventArgs e)
        {
            // Valida formulario y crea el cliente
            if (ValidarFormulario())
            {
                try
                {
                    await _clientesApi.CrearClienteAsync(new ClienteDto
                    {
                        Nombre = txtCrearNombre.Text,
                        Apellidos = txtCrearApellidos.Text,
                        Email = txtCrearEmail.Text
                    });

                    // Cierra el formulario
                    this.Close();
                }
                catch (SqlException ex)
                {
                    UiHelpers.MostrarErrorSql(ex);
                }
                catch (Exception ex)
                {
                    UiHelpers.MostrarError(ex);
                }
            }
        }

        // Cierra el formulario sin crear el cliente
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida los campos del formulario
        private bool ValidarFormulario()
        {
            bool ok = true;

            // Patrón de email
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(txtCrearNombre.Text))
            {
                MessageBox.Show(
                    "El nombre del cliente es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtCrearNombre.Text, out _))
            {
                MessageBox.Show(
                    "El nombre del cliente no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (string.IsNullOrEmpty(txtCrearApellidos.Text))
            {
                MessageBox.Show(
                    "Los apellidos del cliente son obligatorios",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtCrearApellidos.Text, out _))
            {
                MessageBox.Show(
                    "Los apellidos del cliente no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (string.IsNullOrEmpty(txtCrearEmail.Text))
            {
                MessageBox.Show(
                    "El email del cliente es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!Regex.IsMatch(txtCrearEmail.Text, patron))
            {
                MessageBox.Show(
                    "El email debe tener un formato válido (ejemplo@email.com)",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }

            return ok;
        }
    }
}
