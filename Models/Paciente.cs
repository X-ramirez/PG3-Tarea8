using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_Vacunas.Models
{
    public partial class Paciente
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int ProvinciasId { get; set; }
        public int VacunasId { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaPrimeraVacuna { get; set; }
        public string FechaSegundaVacuna { get; set; }
        public string SignoDelZodiaco { get; set; }
        public double? Latitud { get; set; }
        public double? Longitud { get; set; }
        public string Estado { get; set; }

        public virtual Direccion Provincias { get; set; }
        public virtual Vacunas Vacunas { get; set; }
    }
}
