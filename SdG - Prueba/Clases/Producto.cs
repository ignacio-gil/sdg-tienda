using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Producto(string codigo, int idMarca, string modelo, int cantidad, float precio, int idCat)
    {
        public string Codigo { get; set; } = codigo;
        public int IdMarca { get; set; } = idMarca;
        public string Modelo { get; set; } = modelo;
        public int Cantidad { get; set; } = cantidad;
        public float Precio { get; set; } = precio;
        public int IdCat { get; set; } = idCat;

    }
}
