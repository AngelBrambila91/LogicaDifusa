// Annotations
using System.ComponentModel.DataAnnotations.Schema;
namespace WorkingWithEntityFrameWorkCore;

public class Category
{
    // These properties is going to map each field on the DB
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    // Navigation Property
    // When a Join is called related rows
    public virtual ICollection<Product> Products {get; set;}
    public Category()
    {
        // we need a way to add products to a category
        // initialize the navigation property to an empty collection
        Products = new HashSet<Product>();
    }
}