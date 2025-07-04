using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Caja(int id, string nombre, float efectivo)
    {

        public int Id { set; get; } = id;
        public string Nombre { set; get; } = nombre;
        public float Efectivo { set; get; } = efectivo;
    }
}
