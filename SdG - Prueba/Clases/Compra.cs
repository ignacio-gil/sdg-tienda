using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Compra(int id, DateOnly fecha, TimeOnly hora, decimal importeTotal,
                        int idPersonal, int idCliente)
    {
        public int Id { set; get; } = id;
        public DateOnly Fecha { set; get; } = fecha;
        public TimeOnly Hora { set; get; } = hora;
        public decimal ImporteTotal { set; get; } = importeTotal;
        public int IdPersonal { set; get; } = idPersonal;
        public int IdProveedor { set; get; } = idCliente;
    }
}
