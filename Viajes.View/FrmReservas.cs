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
    public partial class FrmReservas : Form
    {
        // Instancia de la API de Reservas
        private readonly ReservasAPI _reservasApi = new ReservasAPI();
        // Listas local de reservas
        private List<ReservaDto> _reservas = new List<ReservaDto>();

        public FrmReservas(List<ReservaDto> reservas)
        {
            InitializeComponent();
            _reservas = reservas;
            this.dgvReservas.SelectionChanged += DgvReservas_SelectionChanged;
            this.txtBuscarClienteReserva.TextChanged += TxtBuscarClienteReserva_TextChanged;
            this.txtBuscarViajeReserva.TextChanged += TxtBuscarViajeReserva_TextChanged;

            // Limpia el estado del status strip
            tsslStatus.Text = "";
        }

        private async void FrmReservas_Load(object sender, EventArgs e)
        {
            // Resaltar solo fila seleccionada
            ResaltarFilaSeleccionada();

            // Carga la lista de reservas desde la base de datos
            if (_reservas == null) await CargarReservas();

            // Refresca el DataGridView y actualiza las estadísticas
            RefrescarGrid();
            ActualizarTotal();

            // Selecciona la primera fila al cargar el formulario
            SeleccionarPrimeraFila();
        }

        // Carga la lista de reservas desde la base de datos
        private async Task CargarReservas()
        {
            try
            {
                _reservas = await _reservasApi.ObtenerReservasAsync();
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

        // Refresca el DataGridView con la lista de reservas
        private void RefrescarGrid()
        {
            // Rellena el DataGridView con la lista si esta no está vacia
            if (_reservas.Count != 0)
            {
                AplicarFiltro();
            }
            else if (_reservas.Count == 0)
            {
                dgvReservas.DataSource = null;
                LimpiarCampos();
            }
        }

        // Configura las columnas del DataGridView manualmente
        private void ConfigurarColumnasDGV()
        {
            // AutoGenerateColumns a false para definir columnas manualmente
            dgvReservas.AutoGenerateColumns = false;
            // Limpia columnas existentes
            dgvReservas.Columns.Clear();

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdReserva",
                DataPropertyName = "IdReserva",
                HeaderText = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 40,
                MinimumWidth = 40
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClienteNombreCompleto",
                DataPropertyName = "ClienteNombreCompleto",
                HeaderText = "Cliente",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 210,
                MinimumWidth = 210
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ViajeDestino",
                DataPropertyName = "ViajeDestino",
                HeaderText = "Viaje",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 220,
                MinimumWidth = 220
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaReserva",
                DataPropertyName = "FechaReserva",
                HeaderText = "Fecha de Reserva",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 110,
                MinimumWidth = 110
            });

            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ViajePrecio",
                DataPropertyName = "ViajePrecio",
                HeaderText = "Precio del Viaje",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 92,
                MinimumWidth = 92
            });
        }

        // Selecciona la primera fila del DataGridView
        private void SeleccionarPrimeraFila()
        {
            if (dgvReservas.Rows.Count > 0)
            {
                // Limpia cualquier selección anterior
                dgvReservas.ClearSelection();
                // Marca la primera fila completa
                dgvReservas.Rows[0].Selected = true;
                // Establece el foco
                dgvReservas.CurrentCell = dgvReservas.Rows[0].Cells[0];
            }
        }

        // Resalta solo la fila seleccionada en el DataGridView
        private void ResaltarFilaSeleccionada()
        {
            // Al hacer clic en cualquier celda, se selecciona toda la fila
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Permite seleccionar solo una fila a la vez
            dgvReservas.MultiSelect = false;

            // Oculta el margen lateral con el triángulo gris
            dgvReservas.RowHeadersVisible = false;

            // Color fijo para los encabezados (no cambiará al moverse el foco)
            dgvReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvReservas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvReservas.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            // Evita que el color del encabezado cambie con el tema de Windows
            dgvReservas.EnableHeadersVisualStyles = false;

            // Colores de selección
            dgvReservas.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvReservas.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Colores de filas normales y alternas
            dgvReservas.RowsDefaultCellStyle.BackColor = Color.White;
            dgvReservas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        // Dispara al cambiar la selección en el DataGridView y carga los datos en los campos correspondientes
        private void DgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada y que el indice de fila seleccionada sea menor al tamaño de la lista
            var currentRow = dgvReservas.CurrentRow;
            if (currentRow != null && currentRow.Index < _reservas.Count)
            {
                // Obtiene la reserva seleccionada desde el DataGridView
                ReservaDto reservaSeleccionada = currentRow.DataBoundItem as ReservaDto;
                RellenarCampos(reservaSeleccionada);
            }
        }

        // Filtra la lista de vehículos al escribir en el TextBox de búsqueda de cliente
        private void TxtBuscarClienteReserva_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Filtra la lista de vehículos al escribir en el TextBox de búsqueda de viaje
        private void TxtBuscarViajeReserva_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Aplica el filtro de cliente y/o viaje y actualiza el DataGridView
        private void AplicarFiltro()
        {
            // Obtiene los criterios de búsqueda
            string criterioCliente = txtBuscarClienteReserva.Text.Trim().ToUpper();
            string criterioViaje = txtBuscarViajeReserva.Text.Trim().ToUpper();

            List<ReservaDto> listaMostrar;

            // Si no hay criterio, muestra todas las reservas
            if (string.IsNullOrEmpty(criterioCliente) && string.IsNullOrEmpty(criterioViaje))
            {
                listaMostrar = _reservas;
            }
            else
            {
                listaMostrar = _reservas
                    .Where(r =>
                        (r.Cliente.NombreCompleto != null && r.Cliente.NombreCompleto.ToUpper().Contains(criterioCliente)) &&
                        (r.Viaje.Destino != null && r.Viaje.Destino.ToUpper().Contains(criterioViaje)))
                    .ToList();
            }

            // Enlaza el grid con la lista filtrada
            dgvReservas.DataSource = listaMostrar;
            // Configura las columnas del DataGridView
            ConfigurarColumnasDGV();

            // Si no hay resultados, limpia los campos
            if (listaMostrar.Count == 0) LimpiarCampos();
        }

        // Actualiza el total de reservas mostradas
        private void ActualizarTotal()
        {
            // Total reservas
            int totalReservas = _reservas.Count;
            lblValorTotalReservas.Text = totalReservas.ToString();
        }

        // Rellena los campos del formulario con los datos de la reserva seleccionada
        private void RellenarCampos(ReservaDto reserva)
        {
            if (reserva == null)
            {
                LimpiarCampos();
            }
            else
            {
                lblValorClienteReserva.Text = reserva.Cliente.NombreCompleto.ToString();
                lblValorViajeReserva.Text = reserva.Viaje.Destino.ToString();
                dtpFechaReserva.Value = reserva.FechaReserva;
            }
        }

        // Limpia los campos del formulario
        private void LimpiarCampos()
        {
            lblValorClienteReserva.Text = "";
            lblValorViajeReserva.Text = "";
            dtpFechaReserva.Value = DateTime.Today;
        }

        // Evento click para ir al formulario de crear una nueva reserva
        private async void CrearReserva_Click(object sender, EventArgs e)
        {
            // Abre el formulario para crear una nueva reserva
            // Using asegura que se libere la memoria al cerrar el formulario
            using (Form frmNuevaReserva = new FrmNuevaReserva(_reservasApi))
            {
                frmNuevaReserva.ShowDialog();
            }

            try
            {
                // Recarga la lista de reservas desde la base de datos
                await CargarReservas();
                // Refresca el DataGridView
                RefrescarGrid();
                // Actualiza el total de clientes
                ActualizarTotal();
                // Muestra mensaje de éxito en el status strip
                await MostrarMensajeTemporalAsync("Reserva creada corréctamente");
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

        // Evento click para editar la fecha de la reserva seleccionada
        private async void EditarReserva_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una reserva para editar");

            }
            else if (ValidarFormulario())
            {
                try
                {
                    // Obtiene la reserva seleccionada desde el DataGridView
                    ReservaDto reservaSeleccionada = dgvReservas.CurrentRow.DataBoundItem as ReservaDto;

                    // Obtiene los nuevos valores desde los campos del formulario
                    DateTime fechaReserva = dtpFechaReserva.Value.Date;

                    // Actualiza la fecha de la reserva en la base de datos
                    await _reservasApi.ActualizarReservaAsync(new ReservaDto
                    {
                        IdReserva = reservaSeleccionada.IdReserva,
                        FechaReserva = fechaReserva
                    });

                    // Actualiza el objeto en memoria para que el grid refleje el cambio
                    reservaSeleccionada.FechaReserva = fechaReserva;

                    RefrescarGrid();

                    // Muestra mensaje de éxito en el status strip
                    await MostrarMensajeTemporalAsync("Reserva editada corréctamente");
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

        // Evento click para eliminar una reserva seleccionada
        private async void EliminarReserva_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una reserva para eliminar");
            }
            else
            {
                try
                {
                    // Guarda índice actual
                    int indicePrevio = dgvReservas.CurrentRow.Index;

                    // Obtiene la reserva seleccionada desde el DataGridView
                    ReservaDto reservaSeleccionada = dgvReservas.CurrentRow.DataBoundItem as ReservaDto;

                    // Confirma con el usuario antes de eliminar
                    var confirmacion = MessageBox.Show(
                        $"¿Seguro que deseas cancelar la reserva Nº {reservaSeleccionada.IdReserva}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Elimina la reserva de la base de datos
                        await _reservasApi.EliminarReservaAsync(reservaSeleccionada.IdReserva);

                        // Elimina la reserva de la lista en memoria
                        _reservas.Remove(reservaSeleccionada);

                        RefrescarGrid();
                        ActualizarTotal();

                        // Si hay filas en el DataGridView, reposiciona la selección al eliminar y rellena campos
                        if (dgvReservas.Rows.Count > 0 && indicePrevio == dgvReservas.Rows.Count)
                        {
                            int indiceNuevo = Math.Min(indicePrevio, dgvReservas.Rows.Count - 1);
                            dgvReservas.CurrentCell = dgvReservas.Rows[indiceNuevo].Cells[0];

                            // Rellena los campos del formulario cuando eliminamos una fila, si hay datos en el DataGridView
                            ReservaDto reservaNueva = dgvReservas.Rows[indiceNuevo].DataBoundItem as ReservaDto;
                            if (reservaNueva != null) RellenarCampos(reservaNueva);
                            else LimpiarCampos();
                        }

                        // Si ya no quedan filas, limpia campos
                        if (dgvReservas.Rows.Count == 0) LimpiarCampos();

                        // Muestra mensaje de éxito en el status strip
                        await MostrarMensajeTemporalAsync("Reserva eliminada corréctamente");
                    }
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

        // Evento click para limpiar el campo de búsqueda
        private void BtnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscarClienteReserva.Clear();
            txtBuscarViajeReserva.Clear();
        }

        // Evento click para cerrar el formulario
        private void FrmCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida los campos del formulario
        private bool ValidarFormulario()
        {
            bool ok = true;

            if (dtpFechaReserva.Value.Date < DateTime.Now.Date)
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

        // Muestra un mensaje temporal en el status strip
        private async Task MostrarMensajeTemporalAsync(string mensaje, int duracionMs = 5000)
        {
            tsslStatus.Text = mensaje;
            await Task.Delay(duracionMs);
            tsslStatus.Text = "";
        }
    }
}
