using System;
using System.Collections.Generic;

namespace Practico1.Controladores
{
    public class ClienteController
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        public bool GuardarCliente(string rut, Cliente cliente)
        {
            if (ClienteExistente(rut))
            {
                return false; // Cliente con el mismo Rut ya existe
            }

            cliente.Rut = rut; // Asigna el Rut proporcionado al cliente antes de agregarlo
            listaClientes.Add(cliente);
            return true; // Cliente agregado exitosamente
        }

        public List<Cliente> ObtenerListaClientes()
        {
            return listaClientes;
        }

        public void ModificarCliente(Cliente cliente, int filaSeleccionada)
        {
            listaClientes[filaSeleccionada] = cliente;
        }

        public void EliminarCliente(int filaSeleccionada)
        {
            listaClientes.RemoveAt(filaSeleccionada);
        }

        public Cliente ObtenerCliente(int filaSeleccionada)
        {
            return listaClientes[filaSeleccionada];
        }

        private bool ClienteExistente(string rut)
        {
            // Verifica si ya existe un cliente con el mismo Rut en la lista
            return listaClientes.Exists(c => c.Rut == rut);
        }
    }
}
