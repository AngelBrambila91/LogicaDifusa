// StringLenght, Required, ContentType
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WorkingWithEntityFrameWorkCore;

public class Product
{
    public int ProductId { get; set; } // PK
    [Required]
    [StringLength(40)]
    public string ProductName { get; set; } = null!;
    [Column("Price", TypeName = "numeric")]
    public decimal? Cost { get; set; }
    [Column("Unit")]
    public short? Stock { get; set; }
    public bool Discontinued { get; set; }
    // Relationships on the FK
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; } = null!;
}