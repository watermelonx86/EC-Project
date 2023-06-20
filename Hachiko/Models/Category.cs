using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hachiko.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
