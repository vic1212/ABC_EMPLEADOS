using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABC_EMPLEADOS.Logica
{
    public class Lempleados
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Fecha_Alta { get; set; }
        public int IdPuesto { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdEmpresa { get; set; }
    }
}
