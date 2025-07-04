using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NroTelefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public int IdProvincia { get; set; }

        public Persona(int id, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, string localidad, int idProvincia)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            NroTelefono = nroTelefono;
            Mail = mail;
            Direccion = direccion;
            Localidad = localidad;
            IdProvincia = idProvincia;
        }

        public Persona(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
