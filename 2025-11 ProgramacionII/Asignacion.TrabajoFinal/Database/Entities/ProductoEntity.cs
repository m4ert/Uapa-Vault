using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asignacion.TrabajoFinal.Database.Entities;

[Table("producto")]
public class ProductoEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CodigoProducto { get; set; }

    [StringLength(35)]
    public string DescripcionProducto { get; set; }
    public decimal PrecioProducto { get; set; }
    public decimal CostoProducto { get; set; }
    public int ExistenciaProducto { get; set; }
    public char EstatusProducto { get; set; }
}