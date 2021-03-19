using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea7_Vacunas.Models
{
    public partial class Vacunas
    {
        public Vacunas()
        {
            Paciente = new HashSet<Paciente>();
        }

        public int VacunasId { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public virtual ICollection<Paciente> Paciente { get; set; }
    }
}
