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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Viajes.View
{
    public partial class FrmNuevaReserva : Form
    {
        // Instancias de la APIs
        private readonly ReservasAPI _reservasApi;
        private readonly ClientesAPI _clientesApi = new ClientesAPI();
        private readonly ViajesAPI _viajesApi = new ViajesAPI();
        // Listas locales
        private List<ClienteDto> _clientes = new List<ClienteDto>();
        private List<ViajeDto> _viajes = new List<ViajeDto>();

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
                _clientes = await _clientesApi.ObtenerClientesAsync();
                cbClienteReserva.DataSource = _clientes; // Fuente de datos
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
                _viajes = await _viajesApi.ObtenerViajesAsync();
                cbViajeReserva.DataSource = _viajes.Where(v => v.PlazasDisponibles > 0).ToList(); // Fuente de datos
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

        // Evento para la selección del cliente al hacer click en el ComboBox
        private void cbClienteReserva_MouseDown(object sender, MouseEventArgs e)
        {
            cbClienteReserva.SelectAll();
        }

        // Evento para filtrar los clientes al escribir en el ComboBox
        private void cbClienteReserva_KeyUp(object sender, KeyEventArgs e)
        {
            // Obtiene los criterios de filtrado
            string criterioCliente = cbClienteReserva.Text;

            List<ClienteDto> listaMostrar;

            // Si no hay criterio, muestra todas las reservas
            if (string.IsNullOrEmpty(criterioCliente))
            {
                listaMostrar = _clientes;
            }
            else
            {
                listaMostrar = _clientes
                    .Where(c => c.NombreCompleto.ToUpper().Contains(criterioCliente.Trim().ToUpper()))
                    .ToList();
            }

            // Vuelve a asignar el origen de datos
            cbClienteReserva.DataSource = listaMostrar;

            // Vuelve a poner el texto escrito
            cbClienteReserva.DroppedDown = true;
            cbClienteReserva.Text = criterioCliente;

            // Pone el cursor al final del texto y selecciona lo escrito
            cbClienteReserva.SelectionStart = criterioCliente.Length;
            cbClienteReserva.SelectionLength = criterioCliente.Length;

            // Si no hay resultados, limpia la selección
            if (listaMostrar.Count == 0) cbClienteReserva.SelectedIndex = -1;
        }

        // Evento para la selección del viaje al hacer click en el ComboBox
        private void cbViajeReserva_MouseDown(object sender, MouseEventArgs e)
        {
            cbViajeReserva.SelectAll();
        }

        // Evento para filtrar los viajes al escribir en el ComboBox
        private void cbViajeReserva_KeyUp(object sender, KeyEventArgs e)
        {
            // Obtiene los criterios de filtrado
            string criterioViaje = cbViajeReserva.Text;

            List<ViajeDto> listaMostrar;

            // Si no hay criterio, muestra todas las reservas
            if (string.IsNullOrEmpty(criterioViaje))
            {
                listaMostrar = _viajes;
            }
            else
            {
                listaMostrar = _viajes
                    .Where(v => v.Destino.ToUpper().Contains(criterioViaje.Trim().ToUpper()))
                    .ToList();
            }

            // Vuelve a asignar el origen de datos
            cbViajeReserva.DataSource = listaMostrar;

            // Vuelve a poner el texto escrito
            cbViajeReserva.DroppedDown = true;
            cbViajeReserva.Text = criterioViaje;

            // Pone el cursor al final del texto y selecciona lo escrito
            cbViajeReserva.SelectionStart = criterioViaje.Length;
            cbViajeReserva.SelectionLength = criterioViaje.Length;

            // Si no hay resultados, limpia la selección
            if (listaMostrar.Count == 0) cbClienteReserva.SelectedIndex = -1;
        }

        // Evento click del botón para agregar la reserva
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
                    this.DialogResult = DialogResult.OK;
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
