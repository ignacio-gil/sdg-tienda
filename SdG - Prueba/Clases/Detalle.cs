using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Detalle(int id, int cantidad, decimal precio, decimal total, 
                         string descripcion, int idProducto, int idCompraVenta)
    {
        public int Id { set; get; } = id;
        public int Cantidad { set; get; } = cantidad;
        public decimal Precio { set; get; } = precio;
        public decimal Total { set; get; } = total;
        public string Descripcion { set; get; } = descripcion;
        public int IdProducto { set; get; } = idProducto;
        public int IdCompraVenta { set; get; } = idCompraVenta;
    }


}
