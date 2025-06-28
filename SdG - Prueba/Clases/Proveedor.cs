using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Proveedor(string id, string razonSocial, string mail, string telefono, string cuil, string direccion, string pagWeb)
    {
        public string id { get; set; } = id;
        public string razonSocial { get; set; } = razonSocial;
        public string mail { get; set; } = mail;
        public string telefono { get; set; } = telefono;
        public string cuil { get; set; } = cuil;
        public string direccion { get; set; } = direccion;
        public string pagWeb { get; set; } = pagWeb;

    }
}
