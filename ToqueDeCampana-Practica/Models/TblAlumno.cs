using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ToqueDeCampana_Practica.Models
{
    public partial class TblAlumno
    {
        [Key]
        public int IdAlumnos { get; set; }
        public string VchMatricula { get; set; }
        public string VchNombre { get; set; }
        public string VchApellidos { get; set; }
        public string VchCurp { get; set; }
        public DateTime? VchFechaNac { get; set; }
        public int? VchTel1 { get; set; }
        public int? VchTel2 { get; set; }
        public string VchCorreo { get; set; }
        public string VchDisertacion { get; set; }
        public string VchGenero { get; set; }
        public string VchFoto { get; set; }
        public string VchAvatar { get; set; }
        public DateTime? DtFechaIngreso { get; set; }
        public string VchCalle { get; set; }
        public int? IntNoExterior { get; set; }
        public int? IntNoInterior { get; set; }
        public string VchMaps { get; set; }
        public int? IdUniversidad2 { get; set; }
        public int? IdCarrera2 { get; set; }
        public int? IdResidencia2 { get; set; }

        public virtual TblCarrera IdCarrera2Navigation { get; set; }
        public virtual TblResidencium IdResidencia2Navigation { get; set; }
        public virtual TblUniversidad IdUniversidad2Navigation { get; set; }
    }
}
