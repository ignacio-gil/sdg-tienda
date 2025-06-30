using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Modulos.Personal
{
    public class Personal
    {
        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NroTelefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public int IdRol { get; set; }
        public string ClaveAcceso { get; set; }

        public Personal(int idPersonal, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion,
                          int idRol, string claveAcceso)
        {
            IdPersonal = idPersonal;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            NroTelefono = nroTelefono;
            Mail = mail;
            Direccion = direccion;
            IdRol = idRol;
            ClaveAcceso = claveAcceso;
        }

        public Personal(int idPersonal, string nombre, string apellido, int idRol)
        {
            IdPersonal = idPersonal;
            Nombre = nombre;
            Apellido = apellido;
            IdRol = idRol;
        }
    }

}
