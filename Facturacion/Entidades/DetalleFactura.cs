using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleFactura
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public DetalleFactura()
        {
        }

        public DetalleFactura(int id, int idFactura, string identidadCliente, string codigoProducto, decimal precio, int cantidad, decimal total)
        {
            Id = id;
            IdFactura = idFactura;
            IdentidadCliente = identidadCliente;
            CodigoProducto = codigoProducto;
            Precio = precio;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
