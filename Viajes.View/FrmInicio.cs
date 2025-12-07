using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viajes.Controller;

namespace Viajes.View
{
    public partial class FrmInicio : Form
    {
        // Instancias de las APIs
        private readonly ClientesAPI _clientesApi = new ClientesAPI();
        private readonly ViajesAPI _viajesApi = new ViajesAPI();
        private readonly ReservasAPI _reservasApi = new ReservasAPI();
        // Listas locales
        private List<ClienteDto> _clientes = new List<ClienteDto>();
        private List<ViajeDto> _viajes = new List<ViajeDto>();
        private List<ReservaDto> _reservas = new List<ReservaDto>();

        public FrmInicio()
        {
            InitializeComponent();
            Estilos();
        }

        // Evento load del formulario de inicio
        private async void FrmInicio_Load(object sender, EventArgs e)
        {
            // Carga todos los datos necesarios y las estadísticas
            await CargarDatos();
            CargarEstadísticas();
        }

        // Carga todas las estadísticas del formulario de inicio
        private void CargarEstadísticas()
        {
            // Total de clientes
            int totalClientes = _clientes.Count;
            lblValorTotalClientes.Text = totalClientes.ToString();

            // Total de viajes
            int totalViajes = _viajes.Count;
            lblValorTotalViajes.Text = totalViajes.ToString();

            // Total de reservas
            int totalReservas = _reservas.Count;
            lblValorTotalReservas.Text = totalReservas.ToString();

            // Ticket medio
            decimal ticketMedio = totalReservas > 0
                ? _reservas.Average(r => r.ViajePrecio)
                : 0;
            lblValorTicketMedio.Text = ticketMedio.ToString("F0");
        }

        // Carga los datos desde las APIs
        private async Task CargarDatos()
        {
            _clientes = await _clientesApi.ObtenerClientesAsync();
            _viajes = await _viajesApi.ObtenerViajesAsync();
            _reservas = await _reservasApi.ObtenerReservasAsync();
        }

        // Evento click para ir al formulario de Clientes
        private async void btnClientes_Click(object sender, EventArgs e)
        {
            using (FrmClientes frmClientes = new FrmClientes())
            {
                frmClientes.ShowDialog();
            }

            // Carga todos los datos necesarios y las estadísticas
            await CargarDatos();
            CargarEstadísticas();

        }

        // Evento click para ir al formulario de Viajes
        private async void btnViajes_Click(object sender, EventArgs e)
        {
            using (FrmViajes frmViajes = new FrmViajes())
            {
                frmViajes.ShowDialog();
            }

            // Carga todos los datos necesarios y las estadísticas
            await CargarDatos();
            CargarEstadísticas();
        }

        // Evento click para ir al formulario de Reservas
        private async void btnReservas_Click(object sender, EventArgs e)
        {
            using (FrmReservas frmReservas = new FrmReservas(null))
            {
                frmReservas.ShowDialog();
            }

            // Carga todos los datos necesarios y las estadísticas
            await CargarDatos();
            CargarEstadísticas();
        }

        // Evento click para salir de la aplicacion
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Estilos de los paneles
        private void Estilos()
        {
            // Estilos paneles de estadísticas
            EstiloPanelEstadistica(pnTotalClientes, Color.SteelBlue);
            EstiloPanelEstadistica(pnTotalViajes, Color.Salmon);
            EstiloPanelEstadistica(pnTotalReservas, Color.DarkSeaGreen);
            EstiloPanelEstadistica(pnTicketMedio, Color.Goldenrod);
        }

        // Aplica estilos a los paneles de estadísticas
        private void EstiloPanelEstadistica(Panel panel, Color color)
        {
            // Agregar borde izquierdo de color
            Panel bordeIzquierdo = new Panel
            {
                Width = 4,
                Dock = DockStyle.Left,
                BackColor = color
            };
            panel.Controls.Add(bordeIzquierdo);
            bordeIzquierdo.BringToFront();

            // Colorear labels numéricos
            foreach (Control control in panel.Controls)
            {
                if (control is Label label)
                {
                    if (label.Name.StartsWith("lblValor")) label.ForeColor = color;
                }
            }
        }
    }
}
