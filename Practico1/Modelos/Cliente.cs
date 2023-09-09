using System;

namespace Practico1
{
    public class Cliente
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public bool EsEmpresa { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CantidadFacturas { get; set; }
        public int NumeroUltimaFactura { get; set; }
        public decimal MontoUltimaFactura { get; set; }
    }
}
