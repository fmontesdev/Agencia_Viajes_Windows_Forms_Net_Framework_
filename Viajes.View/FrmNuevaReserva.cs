using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viajes.Controller;

namespace Viajes.View
{
    public partial class FrmNuevaReserva : Form
    {
        // Instancias de la APIs
        private readonly ReservasAPI _reservasApi;
        private readonly ClientesAPI _clientesApi = new ClientesAPI();
        private readonly ViajesAPI _viajesApi = new ViajesAPI();

        public FrmNuevaReserva(ReservasAPI reservasApi)
        {
            InitializeComponent();
            _reservasApi = reservasApi;
        }

        // Evento Load del formulario
        private async void FrmNuevaReserva_Load(object sender, EventArgs e)
        {
            // Carga los datos en los ComboBox
            await CargarClientes();
            await CargarViajes();
            // Establece la fecha actual en el DateTimePicker
            dtpFechaReserva.Value = DateTime.Now.Date;
        }

        // Carga los datos de todos los clientes en el ComboBox
        private async Task CargarClientes()
        {
            try
            {
                List<ClienteDto> clientes = await _clientesApi.ObtenerClientesAsync();
                cbClienteReserva.DataSource = clientes; // Fuente de datos
                cbClienteReserva.DisplayMember = "NombreCompleto"; // Lo que se ve en el ComboBox
                cbClienteReserva.ValueMember = "IdCliente"; // El valor asociado a cada ítem
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

        // Carga los datos de todos los viajes con plazas disponibles en el ComboBox
        private async Task CargarViajes()
        {
            try
            {
                List<ViajeDto> viajes = await _viajesApi.ObtenerViajesAsync();
                cbViajeReserva.DataSource = viajes.Where(v => v.PlazasDisponibles > 0).ToList(); // Fuente de datos
                cbViajeReserva.DisplayMember = "Destino"; // Lo que se ve en el ComboBox
                cbViajeReserva.ValueMember = "IdViaje"; // El valor asociado a cada ítem
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

        private async void AgregarReserva_Click(object sender, EventArgs e)
        {
            // Valida formulario y crea la reserva
            if (ValidarFormulario())
            {
                try
                {
                    await _reservasApi.CrearReservaAsync(new ReservaDto
                    {
                        IdCliente = (int)cbClienteReserva.SelectedValue,
                        IdViaje = (int)cbViajeReserva.SelectedValue,
                        FechaReserva = dtpFechaReserva.Value.Date
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

        // Cierra el formulario sin crear la reserva
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida los campos del formulario
        private bool ValidarFormulario()
        {
            bool ok = true;

            if (cbClienteReserva.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debes de seleccionar un cliente",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (cbViajeReserva.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debes de seleccionar un viaje",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (dtpFechaReserva.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show(
                    "La fecha para la reserva debe de ser posterior o igual al dia de hoy",
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
