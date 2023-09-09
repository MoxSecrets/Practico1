using Practico1.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        private ClienteController ClienteController = new ClienteController();
        private int FilaSeleccionada;
        private int IndiceClienteEditando = -1; // Inicialmente, no estás en modo de edición

        public Form1()
        {
            InitializeComponent();
            try
            {
                InicializarTablaCliente();
                MostrarListaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarTablaCliente()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Rut");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("EsEmpresa");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("Fecha Registro");
            tabla.Columns.Add("Cantidad de Facturas");
            tabla.Columns.Add("Numero Ultima Factura");
            tabla.Columns.Add("Monto la Ultima Factura");

            dgCliente.DataSource = tabla;
        }

        private void MostrarListaCliente()
        {
            InicializarTablaCliente();

            List<Cliente> clientes = ClienteController.ObtenerListaClientes();

            if (clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    DataRow row = tabla.NewRow();
                    row["Rut"] = cliente.Rut;
                    row["Nombre"] = cliente.Nombre;
                    row["EsEmpresa"] = cliente.EsEmpresa ? "Si" : "No";
                    row["Telefono"] = cliente.Telefono;
                    row["Direccion"] = cliente.Direccion;
                    row["Fecha Registro"] = cliente.FechaRegistro.ToString("dd/MM/yyyy");
                    row["Cantidad de Facturas"] = cliente.CantidadFacturas;
                    row["Numero Ultima Factura"] = cliente.NumeroUltimaFactura;
                    row["Monto la Ultima Factura"] = cliente.MontoUltimaFactura;

                    tabla.Rows.Add(row);
                }
            }
        }

        private void LimpiarFormularioCliente()
        {
            text_Rut.Text = string.Empty;
            text_Nombre.Text = string.Empty;
            rbtn_EmpresaSi.Checked = false;
            rbtn_EmpresaNo.Checked = false;
            text_Telefono.Text = string.Empty;
            text_Direccion.Text = string.Empty;
            dt_FechaRegistro.Value = DateTime.Today;
            text_CantidadFacturas.Text = string.Empty;
            text_NumeroUltimaFactura.Text = string.Empty;
            text_MontoUltimaFactura.Text = string.Empty;
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaRegistro = dt_FechaRegistro.Value; // Obtiene la fecha del DateTimePicker

                if (int.TryParse(text_CantidadFacturas.Text, out int cantidadFacturas) &&
                    int.TryParse(text_NumeroUltimaFactura.Text, out int numeroUltimaFactura) &&
                    decimal.TryParse(text_MontoUltimaFactura.Text, out decimal montoUltimaFactura))
                {
                    if (IndiceClienteEditando != -1)
                    {
                        // Si estás en modo de edición, modifica el cliente existente en lugar de agregar uno nuevo
                        Cliente clienteEditando = ClienteController.ObtenerCliente(IndiceClienteEditando);

                        clienteEditando.Rut = text_Rut.Text;
                        clienteEditando.Nombre = text_Nombre.Text;
                        clienteEditando.EsEmpresa = rbtn_EmpresaSi.Checked;
                        clienteEditando.Telefono = text_Telefono.Text;
                        clienteEditando.Direccion = text_Direccion.Text;
                        clienteEditando.FechaRegistro = fechaRegistro;
                        clienteEditando.CantidadFacturas = cantidadFacturas;
                        clienteEditando.NumeroUltimaFactura = numeroUltimaFactura;
                        clienteEditando.MontoUltimaFactura = montoUltimaFactura;

                        // Modifica el cliente en la lista
                        ClienteController.ModificarCliente(clienteEditando, IndiceClienteEditando);

                        // Limpia el modo de edición
                        IndiceClienteEditando = -1;
                    }
                    else
                    {
                        // Si no estás en modo de edición, crea un nuevo cliente
                        Cliente cliente = new Cliente()
                        {
                            Rut = text_Rut.Text,
                            Nombre = text_Nombre.Text,
                            EsEmpresa = rbtn_EmpresaSi.Checked,
                            Telefono = text_Telefono.Text,
                            Direccion = text_Direccion.Text,
                            FechaRegistro = fechaRegistro,
                            CantidadFacturas = cantidadFacturas,
                            NumeroUltimaFactura = numeroUltimaFactura,
                            MontoUltimaFactura = montoUltimaFactura
                        };

                        ClienteController.GuardarCliente(text_Rut.Text, cliente);
                    }

                    // Vuelve a cargar la lista de clientes en la tabla
                    MostrarListaCliente();
                    LimpiarFormularioCliente();
                }
                else
                {
                    MessageBox.Show("Los campos de cantidad de facturas, número de última factura y monto de última factura deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilaSeleccionada >= 0 && FilaSeleccionada < tabla.Rows.Count)
                {
                    // Obtén el cliente seleccionado
                    Cliente cliente = ClienteController.ObtenerCliente(FilaSeleccionada);

                    // Carga la información del cliente en los campos de texto
                    text_Rut.Text = cliente.Rut;
                    text_Nombre.Text = cliente.Nombre;
                    rbtn_EmpresaSi.Checked = cliente.EsEmpresa;
                    text_Telefono.Text = cliente.Telefono;
                    text_Direccion.Text = cliente.Direccion;
                    dt_FechaRegistro.Value = cliente.FechaRegistro;
                    text_CantidadFacturas.Text = cliente.CantidadFacturas.ToString();
                    text_NumeroUltimaFactura.Text = cliente.NumeroUltimaFactura.ToString();
                    text_MontoUltimaFactura.Text = cliente.MontoUltimaFactura.ToString();

                    // Guarda el índice del cliente que se está editando
                    IndiceClienteEditando = FilaSeleccionada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilaSeleccionada >= 0 && FilaSeleccionada < tabla.Rows.Count)
                {

                    // Pregunta al usuario si está seguro de eliminar el cliente
                    DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Elimina el cliente de la lista
                        ClienteController.EliminarCliente(FilaSeleccionada);

                        // Vuelve a cargar la lista de clientes en la tabla
                        MostrarListaCliente();
                        LimpiarFormularioCliente();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    FilaSeleccionada = e.RowIndex;
                    ActualizarCamposFilaSeleccionada();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCamposFilaSeleccionada()
        {
            if (FilaSeleccionada >= 0)
            {
                DataGridViewRow fila = dgCliente.Rows[FilaSeleccionada];
                text_Rut.Text = fila.Cells["Rut"].Value.ToString();
                text_Nombre.Text = fila.Cells["Nombre"].Value.ToString();
                rbtn_EmpresaSi.Checked = fila.Cells["EsEmpresa"].Value.ToString() == "Si";
                rbtn_EmpresaNo.Checked = fila.Cells["EsEmpresa"].Value.ToString() == "No";
                text_Telefono.Text = fila.Cells["Telefono"].Value.ToString();
                text_Direccion.Text = fila.Cells["Direccion"].Value.ToString();
                dt_FechaRegistro.Text = fila.Cells["Fecha Registro"].Value.ToString();
                text_CantidadFacturas.Text = fila.Cells["Cantidad de Facturas"].Value.ToString();
                text_NumeroUltimaFactura.Text = fila.Cells["Numero Ultima Factura"].Value.ToString();
                text_MontoUltimaFactura.Text = fila.Cells["Monto la Ultima Factura"].Value.ToString();
            }
        } 
    }
}
