using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetTransportes
{
    [Table("PROVINCIA")]
    public class Provincia
    {
        [Key]
        [Column("IDPROVINCIA")]
        public int IdProvincia { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
    }
}
