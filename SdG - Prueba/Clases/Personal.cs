using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Personal : Persona
    {
        public int IdRol { get; set; }
        public string ClaveAcceso { get; set; }

        public Personal(int idPersonal, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, string localidad,
                          int idProvincia, int idRol, string claveAcceso)
                            : 
                          base(idPersonal, nombre, apellido, dni,
                          fechaNacimiento, nroTelefono,
                          mail, direccion, localidad, idProvincia)
        {
            IdRol = idRol;
            ClaveAcceso = claveAcceso;
        }

        public Personal(int idPersonal, string nombre, string apellido, int idRol)
                : base(idPersonal, nombre, apellido)
        {
            IdRol = idRol;
        }
    }

}
