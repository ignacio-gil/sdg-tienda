using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SdG___Prueba.Clases
{
    public class Venta(int id, DateOnly fecha, TimeOnly hora, decimal importeTotal, decimal importePagado, 
                       decimal importeCambio, int idPersonal, int idCliente, int idCaja)
    {
        public int Id { set; get; } = id;
        public DateOnly Fecha { set; get; } = fecha;
        public TimeOnly Hora { set; get; } = hora;
        public decimal ImporteTotal { set; get; } = importeTotal;
        public decimal ImportePagado { set; get; } = importePagado;
        public decimal ImporteCambio { set; get; } = importeCambio;
        public int IdPersonal { set; get; } = idPersonal;
        public int IdCliente { set; get; } = idCliente;
        public int IdCaja { set; get; } = idCaja;
    }
}
