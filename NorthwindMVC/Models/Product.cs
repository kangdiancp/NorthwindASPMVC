using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindMVC.Models
{
    [Table("products",Schema ="master")]
    public class Product
    {
        [Key]
        [DisplayName("ProductID")]
        public int Id { get; set; }

        [Required]
        [StringLength(125, ErrorMessage = "Product length name not must exceed than 125")]
        public string? ProductName { get; set; }

        [Column(TypeName = "decimal(15,2)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        // create link (fk) to category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
