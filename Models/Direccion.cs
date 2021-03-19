using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_Vacunas.Models
{
    public partial class Direccion
    {
        public Direccion()
        {
            Paciente = new HashSet<Paciente>();
        }

        public int ProvinciasId { get; set; }
        public string Calle { get; set; }
        public string Provincia { get; set; }
        public string Sector { get; set; }
        public string Num { get; set; }

        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
