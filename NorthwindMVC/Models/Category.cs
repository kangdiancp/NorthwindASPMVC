using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindMVC.Models
{
    [Table("categories",Schema ="master")]
    public class Category
    {
        [Key]
        [DisplayName("Category ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="CategoryName length not exceeded than 50")]
        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        public string? Photo { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
