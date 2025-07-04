using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdG___Prueba.Clases
{
    public class Cliente : Persona
    {
        public Cliente(int idCliente, string nombre,
                          string apellido, string dni,
                          DateTime fechaNacimiento, string nroTelefono,
                          string mail, string direccion, string localidad, int idProvincia)
                        :
                        base(idCliente, nombre, apellido, dni, fechaNacimiento,
                            nroTelefono, mail, direccion, localidad, idProvincia)
        {
        }

    }
}
