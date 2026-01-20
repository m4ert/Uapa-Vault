using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion.ProyectoFinal._6.Database.Entities
{
    [Table("pacientes")]
    public class PacienteEntity
    {
        [Key]
        [StringLength(50)]
        [Column("codigopac")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CodigoPac { get; set; }

        [StringLength(50)]
        [Column("nombrepac")]
        public string NombrePac { get; set; }

        [StringLength(50)]
        [Column("apelldiopac")]
        public string ApelldioPac { get; set; }

        [StringLength(50)]
        [Column("direccionpac")]
        public string? DireccionPac { get; set; }

        [StringLength(50)]
        [Column("telefonopac")]
        public string? TelefonoPac { get; set; }

        [Column("estatuspac")]
        public bool EstatusPac { get; set; }
    }
}
