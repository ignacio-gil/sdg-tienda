using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Modulos.Cliente
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NroTelefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public int IdLocalidad { get; set; }

        public Cliente(int idCliente, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, int idLocalidad)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            NroTelefono = nroTelefono;
            Mail = mail;
            Direccion = direccion;
            IdLocalidad = idLocalidad;
        }

    }
}
