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
    public partial class FrmViajes : Form
    {
        // Instancias de las APIs
        private readonly ViajesAPI _viajesApi = new ViajesAPI();
        private readonly ReservasAPI _reservasApi = new ReservasAPI();
        // Lista local de viajes
        private List<ViajeDto> _viajes = new List<ViajeDto>();

        public FrmViajes()
        {
            InitializeComponent();
            this.dgvViajes.SelectionChanged += DgvViajes_SelectionChanged;

            // Limpia el estado del status strip
            tsslStatus.Text = "";
        }

        // Evento Load del formulario
        private async void FrmViajes_Load(object sender, EventArgs e)
        {
            // Resaltar solo fila seleccionada
            ResaltarFilaSeleccionada();

            // Carga la lista de viajes desde la base de datos
            await CargarViajes();

            // Refresca el DataGridView y actualiza las estadísticas
            RefrescarGrid();
            ActualizarTotal();

            // Selecciona la primera fila al cargar el formulario
            SeleccionarPrimeraFila();
        }

        // Carga la lista de viajes desde la base de datos
        private async Task CargarViajes()
        {
            try
            {
                _viajes = await _viajesApi.ObtenerViajesAsync();
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

        // Refresca el DataGridView con la lista de viajes
        private void RefrescarGrid()
        {
            // Rellena el DataGridView con la lista si esta no está vacia
            if (_viajes.Count != 0)
            {
                // Enlaza el grid con la lista
                dgvViajes.DataSource = _viajes;
                // Configura las columnas del DataGridView
                ConfigurarColumnasDGV();
            }
            else if (_viajes.Count == 0)
            {
                dgvViajes.DataSource = null;
                LimpiarCampos();
            }
        }

        // Configura las columnas del DataGridView manualmente
        private void ConfigurarColumnasDGV()
        {
            // AutoGenerateColumns a false para definir columnas manualmente
            dgvViajes.AutoGenerateColumns = false;
            // Limpia columnas existentes
            dgvViajes.Columns.Clear();

            dgvViajes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdViaje",
                DataPropertyName = "IdViaje",
                HeaderText = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50,
                MinimumWidth = 50
            });

            dgvViajes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Destino",
                DataPropertyName = "Destino",
                HeaderText = "Destino",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 200
            });

            dgvViajes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100,
                MinimumWidth = 100
            });

            dgvViajes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PlazasDisponibles",
                DataPropertyName = "PlazasDisponibles",
                HeaderText = "Plazas Disponibles",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 200,
                MinimumWidth = 200
            });
        }

        // Selecciona la primera fila del DataGridView
        private void SeleccionarPrimeraFila()
        {
            if (dgvViajes.Rows.Count > 0)
            {
                // Limpia cualquier selección anterior
                dgvViajes.ClearSelection();
                // Marca la primera fila completa
                dgvViajes.Rows[0].Selected = true;
                // Establece el foco
                dgvViajes.CurrentCell = dgvViajes.Rows[0].Cells[0];
            }
        }

        // Resalta solo la fila seleccionada en el DataGridView
        private void ResaltarFilaSeleccionada()
        {
            // Al hacer clic en cualquier celda, se selecciona toda la fila
            dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Permite seleccionar solo una fila a la vez
            dgvViajes.MultiSelect = false;

            // Oculta el margen lateral con el triángulo gris
            dgvViajes.RowHeadersVisible = false;

            // Color fijo para los encabezados (no cambiará al moverse el foco)
            dgvViajes.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvViajes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvViajes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvViajes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            // Evita que el color del encabezado cambie con el tema de Windows
            dgvViajes.EnableHeadersVisualStyles = false;

            // Colores de selección
            dgvViajes.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvViajes.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Colores de filas normales y alternas
            dgvViajes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvViajes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        // Dispara al cambiar la selección en el DataGridView y carga los datos en los campos correspondientes
        private void DgvViajes_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada y que el indice de fila seleccionada sea menor al tamaño de la lista
            var currentRow = dgvViajes.CurrentRow;
            if (currentRow != null && currentRow.Index < _viajes.Count)
            {
                // Obtiene el viaje seleccionado desde el DataGridView
                ViajeDto viajeSeleccionado = currentRow.DataBoundItem as ViajeDto;
                RellenarCampos(viajeSeleccionado);
            }
        }

        // Actualiza el total de viajes mostrados
        private void ActualizarTotal()
        {
            // Total viajes
            int totalViajes = _viajes.Count;
            lblValorTotalViajes.Text = totalViajes.ToString();
        }

        // Rellena los campos del formulario con los datos del viaje seleccionado
        private void RellenarCampos(ViajeDto viaje)
        {
            if (viaje == null)
            {
                LimpiarCampos();
            }
            else
            {
                txtDestino.Text = viaje.Destino.ToString();
                txtPrecio.Text = viaje.Precio.ToString();
                txtPlazas.Text = viaje.PlazasDisponibles.ToString();
            }
        }

        // Limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtDestino.Clear();
            txtPrecio.Clear();
            txtPlazas.Clear();
        }

        // Evento click para ir al formulario de crear un nuevo viaje
        private async void CrearViaje_Click(object sender, EventArgs e)
        {
            // Abre el formulario para crear un nuevo viaje
            // Using asegura que se libere la memoria al cerrar el formulario
            using (Form frmNuevoViaje = new FrmNuevoViaje(_viajesApi))
            {
                var result = frmNuevoViaje.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        // Recarga la lista de viajes desde la base de datos
                        await CargarViajes();
                        // Refresca el DataGridView
                        RefrescarGrid();
                        // Actualiza el total de clientes
                        ActualizarTotal();
                        // Muestra mensaje de éxito en el status strip
                        await MostrarMensajeTemporalAsync("Viaje creado corréctamente");
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
        }

        // Evento click para editar el viaje seleccionado
        private async void EditarViaje_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvViajes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un viaje para editar.");

            }
            else if (ValidarFormulario())
            {
                try
                {
                    // Obtiene el viaje seleccionado desde el DataGridView
                    ViajeDto viajeSeleccionado = dgvViajes.CurrentRow.DataBoundItem as ViajeDto;

                    // Obtiene los nuevos valores desde los campos del formulario
                    string destino = txtDestino.Text;
                    decimal precio = decimal.Parse(txtPrecio.Text);
                    int plazas = int.Parse(txtPlazas.Text);

                    // Actualiza el viaje en la base de datos
                    await _viajesApi.ActualizarViajeAsync(new ViajeDto
                    {
                        IdViaje = viajeSeleccionado.IdViaje,
                        Destino = destino,
                        Precio = precio,
                        PlazasDisponibles = plazas
                    });

                    // Actualiza el objeto en memoria para que el grid refleje el cambio
                    viajeSeleccionado.Destino = destino;
                    viajeSeleccionado.Precio = precio;
                    viajeSeleccionado.PlazasDisponibles = plazas;

                    RefrescarGrid();

                    // Muestra mensaje de éxito en el status strip
                    await MostrarMensajeTemporalAsync("Viaje editado corréctamente");
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

        // Evento click para eliminar un viaje seleccionado
        private async void EliminarViaje_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvViajes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un viaje para eliminar.");
            }
            else
            {
                try
                {
                    // Guarda índice actual
                    int indicePrevio = dgvViajes.CurrentRow.Index;

                    // Obtiene el viaje seleccionado desde el DataGridView
                    ViajeDto viajeSeleccionado = dgvViajes.CurrentRow.DataBoundItem as ViajeDto;

                    // Obtiene las reservas asociadas al viaje
                    List<ReservaDto> reservasViaje = viajeSeleccionado.Reservas;

                    // Verifica si el viaje tiene reservas activas
                    List<ReservaDto> reservasActivas = reservasViaje
                        .Where(r => r.FechaReserva >= DateTime.Now).ToList();

                    // Si tiene reservas activas, no permite eliminar
                    if (reservasActivas.Count > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar el viaje porque tiene reservas activas asociadas",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        // Confirma con el usuario antes de eliminar, dependiendo si tiene historial de reservas o no
                        var confirmacion = DialogResult.No;
                        if (reservasViaje.Count == 0)
                        {
                            confirmacion = MessageBox.Show(
                                $"¿Seguro que quieres eliminar el viaje con destino {viajeSeleccionado.Destino}?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                        }
                        else
                        {
                            confirmacion = MessageBox.Show(
                                $"El viaje con destino {viajeSeleccionado.Destino} tiene un historial de reservas. ¿Seguro que quieres eliminarlo junto el historial?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                        }

                        if (confirmacion == DialogResult.Yes)
                        {
                            // Elimina el viaje de la base de datos
                            await _viajesApi.EliminarViajeAsync(viajeSeleccionado.IdViaje);

                            // Elimina el viaje de la lista en memoria
                            _viajes.Remove(viajeSeleccionado);

                            RefrescarGrid();
                            ActualizarTotal();

                            // Si hay filas en el DataGridView, reposiciona la selección al eliminar y rellena campos
                            if (dgvViajes.Rows.Count > 0 && indicePrevio == dgvViajes.Rows.Count)
                            {
                                int indiceNuevo = Math.Min(indicePrevio, dgvViajes.Rows.Count - 1);
                                dgvViajes.CurrentCell = dgvViajes.Rows[indiceNuevo].Cells[0];

                                // Rellena los campos del formulario cuando eliminamos una fila, si hay datos en el DataGridView
                                ViajeDto viajeNuevo = dgvViajes.Rows[indiceNuevo].DataBoundItem as ViajeDto;
                                if (viajeNuevo != null) RellenarCampos(viajeNuevo);
                                else LimpiarCampos();
                            }

                            // Si ya no quedan filas, limpia campos
                            if (dgvViajes.Rows.Count == 0) LimpiarCampos();

                            // Muestra mensaje de éxito en el status strip
                            await MostrarMensajeTemporalAsync("Viaje eliminado corréctamente");
                        }
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

        // Evento click para acceder a las reservas del viaje
        private async void ReservasViaje_Click(object sender, EventArgs e)
        {
            // Obtiene el viaje seleccionado desde el DataGridView
            ViajeDto viajeSeleccionado = dgvViajes.CurrentRow.DataBoundItem as ViajeDto;

            // Obtiene las reservas asociadas al viaje
            List<ReservaDto> reservas = await _reservasApi.ObtenerReservasAsync();
            List<ReservaDto> reservasViaje = reservas
                .Where(r => r.IdViaje == viajeSeleccionado.IdViaje)
                .ToList();

            using (Form frmReservas = new FrmReservas(reservasViaje))
            {
                frmReservas.ShowDialog();
            }
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

            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show(
                    "El destino del viaje es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtDestino.Text, out _))
            {
                MessageBox.Show(
                    "El destino del viaje no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show(
                    "El precio del viaje debe de ser un número",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!int.TryParse(txtPlazas.Text, out _))
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

        // Muestra un mensaje temporal en el status strip
        private async Task MostrarMensajeTemporalAsync(string mensaje, int duracionMs = 5000)
        {
            tsslStatus.Text = mensaje;
            await Task.Delay(duracionMs);
            tsslStatus.Text = "";
        }
    }
}
