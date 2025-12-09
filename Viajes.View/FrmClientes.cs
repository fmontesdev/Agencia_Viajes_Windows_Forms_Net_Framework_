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
    public partial class FrmClientes : Form
    {
        // Instancias de las APIs
        private readonly ClientesAPI _clientesApi = new ClientesAPI();
        private readonly ReservasAPI _reservasApi = new ReservasAPI();
        // Lista local de clientes
        private List<ClienteDto> _clientes = new List<ClienteDto>();

        public FrmClientes()
        {
            InitializeComponent();
            this.dgvClientes.SelectionChanged += DgvClientes_SelectionChanged;

            // Limpia el estado del status strip
            tsslStatus.Text = "";
        }

        // Evento Load del formulario
        private async void FrmClientes_Load(object sender, EventArgs e)
        {
            // Resaltar solo fila seleccionada
            ResaltarFilaSeleccionada();

            // Carga la lista de viajes desde la base de datos
            await CargarClientes();

            // Refresca el DataGridView y actualiza las estadísticas
            RefrescarGrid();
            ActualizarTotal();

            // Selecciona la primera fila al cargar el formulario
            SeleccionarPrimeraFila();
        }

        // Carga la lista de clientes desde la base de datos
        private async Task CargarClientes()
        {
            try
            {
                _clientes = await _clientesApi.ObtenerClientesAsync();
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

        // Refresca el DataGridView con la lista de clientes
        private void RefrescarGrid()
        {
            // Rellena el DataGridView con la lista si esta no está vacia
            if (_clientes.Count != 0)
            {
                // Enlaza el grid con la lista
                dgvClientes.DataSource = _clientes;
                // Configura las columnas del DataGridView
                ConfigurarColumnasDGV();
            }
            else if (_clientes.Count == 0)
            {
                dgvClientes.DataSource = null;
                LimpiarCampos();
            }
        }

        // Configura las columnas del DataGridView manualmente
        private void ConfigurarColumnasDGV()
        {
            // AutoGenerateColumns a false para definir columnas manualmente
            dgvClientes.AutoGenerateColumns = false;
            // Limpia columnas existentes
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCliente",
                DataPropertyName = "IdCliente",
                HeaderText = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 50,
                MinimumWidth = 50
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 150,
                MinimumWidth = 150
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Apellidos",
                DataPropertyName = "Apellidos",
                HeaderText = "Apellidos",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 220,
                MinimumWidth = 220
            });

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                //Width = 250,
                MinimumWidth = 250
            });
        }

        // Selecciona la primera fila del DataGridView
        private void SeleccionarPrimeraFila()
        {
            if (dgvClientes.Rows.Count > 0)
            {
                // Limpia cualquier selección anterior
                dgvClientes.ClearSelection();
                // Marca la primera fila completa
                dgvClientes.Rows[0].Selected = true;
                // Establece el foco
                dgvClientes.CurrentCell = dgvClientes.Rows[0].Cells[0];
            }
        }

        // Resalta solo la fila seleccionada en el DataGridView
        private void ResaltarFilaSeleccionada()
        {
            // Al hacer clic en cualquier celda, se selecciona toda la fila
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Permite seleccionar solo una fila a la vez
            dgvClientes.MultiSelect = false;

            // Oculta el margen lateral con el triángulo gris
            dgvClientes.RowHeadersVisible = false;

            // Color fijo para los encabezados (no cambiará al moverse el foco)
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvClientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvClientes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            // Evita que el color del encabezado cambie con el tema de Windows
            dgvClientes.EnableHeadersVisualStyles = false;

            // Colores de selección
            dgvClientes.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dgvClientes.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Colores de filas normales y alternas
            dgvClientes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        // Dispara al cambiar la selección en el DataGridView y carga los datos en los campos correspondientes
        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada y que el indice de fila seleccionada sea menor al tamaño de la lista
            var currentRow = dgvClientes.CurrentRow;
            if (currentRow != null && currentRow.Index < _clientes.Count)
            {
                // Obtiene el cliente seleccionado desde el DataGridView
                ClienteDto clienteSeleccionado = currentRow.DataBoundItem as ClienteDto;
                RellenarCampos(clienteSeleccionado);
            }
        }
        
        // Actualiza el total de clientes mostrados
        private void ActualizarTotal()
        {
            // Total clientes
            int totalClientes = _clientes.Count;
            lblValorTotalClientes.Text = totalClientes.ToString();
        }

        // Rellena los campos del formulario con los datos del cliente seleccionado
        private void RellenarCampos(ClienteDto cliente)
        {
            if (cliente == null)
            {
                LimpiarCampos();
            }
            else
            {
                txtNombre.Text = cliente.Nombre.ToString();
                txtApellidos.Text = cliente.Apellidos.ToString();
                txtEmail.Text = cliente.Email.ToString();
            }
        }

        // Limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
        }

        // Evento click para ir al formulario de crear un nuevo cliente
        private async void CrearCliente_Click(object sender, EventArgs e)
        {
            // Abre el formulario para crear un nuevo cliente
            // Using asegura que se libere la memoria al cerrar el formulario
            using (Form frmNuevoCliente = new FrmNuevoCliente(_clientesApi))
            {
                var result = frmNuevoCliente.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        // Recarga la lista de clientes desde la base de datos
                        await CargarClientes();
                        // Refresca el DataGridView
                        RefrescarGrid();
                        // Actualiza el total de clientes
                        ActualizarTotal();
                        // Muestra mensaje de éxito en el status strip
                        await MostrarMensajeTemporalAsync("Cliente creado corréctamente");
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

        // Evento click para editar cliente seleccionado
        private async void EditarCliente_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cliente para editar.");

            }
            else if (ValidarFormulario())
            {
                try
                {
                    // Obtiene el cliente seleccionado desde el DataGridView
                    ClienteDto clienteSeleccionado = dgvClientes.CurrentRow.DataBoundItem as ClienteDto;

                    // Obtiene los nuevos valores desde los campos del formulario
                    string nombre = txtNombre.Text;
                    string apellidos = txtApellidos.Text;
                    string email = txtEmail.Text;

                    // Actualiza el cliente en la base de datos
                    await _clientesApi.ActualizarClienteAsync(new ClienteDto
                    {
                        IdCliente = clienteSeleccionado.IdCliente,
                        Nombre = nombre,
                        Apellidos = apellidos,
                        Email = email
                    });

                    // Actualiza el objeto en memoria para que el grid refleje el cambio
                    clienteSeleccionado.Nombre = nombre;
                    clienteSeleccionado.Apellidos = apellidos;
                    clienteSeleccionado.Email = email;

                    RefrescarGrid();

                    // Muestra mensaje de éxito en el status strip
                    await MostrarMensajeTemporalAsync("Cliente editado corréctamente");
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

        // Evento click para eliminar un cliente seleccionado
        private async void EliminarCliente_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un cliente para eliminar.");
            }
            else
            {
                try
                {
                    // Guarda índice actual
                    int indicePrevio = dgvClientes.CurrentRow.Index;

                    // Obtiene el cliente seleccionado desde el DataGridView
                    ClienteDto clienteSeleccionado = dgvClientes.CurrentRow.DataBoundItem as ClienteDto;

                    // Obtiene las reservas asociadas al cliente
                    List<ReservaDto> reservasCliente = clienteSeleccionado.Reservas;

                    // Verifica si el cliente tiene reservas activas
                    List<ReservaDto> reservasActivas = reservasCliente
                        .Where(r => r.FechaReserva >= DateTime.Now).ToList();

                    // Si tiene reservas activas, no permite eliminar
                    if (reservasActivas.Count > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar el cliente porque tiene reservas activas asociadas",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        // Confirma con el usuario antes de eliminar, dependiendo si tiene historial de reservas o no
                        var confirmacion = DialogResult.No;
                        if (reservasCliente.Count == 0)
                        {
                            confirmacion = MessageBox.Show(
                                $"¿Seguro que quieres eliminar al cliente {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellidos}?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                        }
                        else
                        {
                            confirmacion = MessageBox.Show(
                                $"El cliente {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellidos} tiene un historial de reservas. ¿Seguro que quieres eliminarlo junto el historial?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );
                        }

                        if (confirmacion == DialogResult.Yes)
                        {
                            // Elimina el cliente de la base de datos
                            await _clientesApi.EliminarClienteAsync(clienteSeleccionado.IdCliente);

                            // Elimina el cliente de la lista en memoria
                            _clientes.Remove(clienteSeleccionado);

                            RefrescarGrid();
                            ActualizarTotal();

                            // Si hay filas en el DataGridView, reposiciona la selección al eliminar y rellena campos
                            if (dgvClientes.Rows.Count > 0 && indicePrevio == dgvClientes.Rows.Count)
                            {
                                int indiceNuevo = Math.Min(indicePrevio, dgvClientes.Rows.Count - 1);
                                dgvClientes.CurrentCell = dgvClientes.Rows[indiceNuevo].Cells[0];

                                // Rellena los campos del formulario cuando eliminamos una fila, si hay datos en el DataGridView
                                ClienteDto clienteNuevo = dgvClientes.Rows[indiceNuevo].DataBoundItem as ClienteDto;
                                if (clienteNuevo != null) RellenarCampos(clienteNuevo);
                                else LimpiarCampos();
                            }

                            // Si ya no quedan filas, limpia campos
                            if (dgvClientes.Rows.Count == 0) LimpiarCampos();

                            // Muestra mensaje de éxito en el status strip
                            await MostrarMensajeTemporalAsync("Cliente eliminado corréctamente");
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

        // Evento click para acceder a las reservas del cliente
        private async void ReservasCliente_Click(object sender, EventArgs e)
        {
            // Obtiene el cliente seleccionado desde el DataGridView
            ClienteDto clienteSeleccionado = dgvClientes.CurrentRow.DataBoundItem as ClienteDto;

            // Obtiene las reservas asociadas al cliente
            List<ReservaDto> reservas = await _reservasApi.ObtenerReservasAsync();
            List<ReservaDto> reservasCliente = reservas
                .Where(r => r.IdCliente == clienteSeleccionado.IdCliente)
                .ToList();

            using (Form frmReservas = new FrmReservas(reservasCliente))
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

            // Patrón de email
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show(
                    "El nombre del cliente es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show(
                    "El nombre del cliente no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show(
                    "Los apellidos del cliente son obligatorios",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (int.TryParse(txtApellidos.Text, out _))
            {
                MessageBox.Show(
                    "Los apellidos del cliente no pueden ser números",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(
                    "El email del cliente es obligatorio",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                ok = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, patron))
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

        // Muestra un mensaje temporal en el status strip
        private async Task MostrarMensajeTemporalAsync(string mensaje, int duracionMs = 5000)
        {
            tsslStatus.Text = mensaje;
            await Task.Delay(duracionMs);
            tsslStatus.Text = "";
        }
    }
}
