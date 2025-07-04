using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Proveedor(string id, string razonSocial, string mail, string telefono, string cuil, string direccion, string localidad, int idProvincia, string pagWeb)
    {
        public string Id { get; set; } = id;
        public string RazonSocial { get; set; } = razonSocial;
        public string Mail { get; set; } = mail;
        public string Telefono { get; set; } = telefono;
        public string Cuil { get; set; } = cuil;
        public string Direccion { get; set; } = direccion;
        public string Localidad { get; set; } = localidad;
        public int IdProvincia { get; set; } = idProvincia;
        public string PagWeb { get; set; } = pagWeb;

    }
}
