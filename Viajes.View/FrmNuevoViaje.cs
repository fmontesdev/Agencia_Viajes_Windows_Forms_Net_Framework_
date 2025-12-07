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
    public partial class FrmNuevoViaje : Form
    {
        // Instancia del API de Viajes
        private readonly ViajesAPI _viajesApi;

        public FrmNuevoViaje(ViajesAPI api)
        {
            InitializeComponent();
            _viajesApi = api;
        }

        private async void AgregarViaje_Click(object sender, EventArgs e)
        {
            // Valida formulario y crea el viaje
            if (ValidarFormulario())
            {
                try
                {
                    await _viajesApi.CrearViajeAsync(new ViajeDto
                    {
                        Destino = txtCrearDestino.Text,
                        Precio = decimal.Parse(txtCrearPrecio.Text),
                        PlazasDisponibles = int.Parse(txtCrearPlazas.Text)
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

        // Cierra el formulario sin crear el viaje
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida los campos del formulario
        private bool ValidarFormulario()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtCrearDestino.Text))
            {
                MessageBox.Show(
                    "El destino del viaje es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtCrearDestino.Text, out _))
            {
                MessageBox.Show(
                    "El destino del viaje no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!decimal.TryParse(txtCrearPrecio.Text, out _))
            {
                MessageBox.Show(
                    "El precio del viaje debe de ser un número",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!int.TryParse(txtCrearPlazas.Text, out _))
            {
                MessageBox.Show(
                    "Las plazas disponibles del viaje debe de ser un número entero",
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
