using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hachiko.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ trống")]
        public string Title { get; set; }
        public string? Description { get; set; }
        //[Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name ="List Price")]
        [Range(0,int.MaxValue)]
        public double ListPrice { get; set; }

        [Display(Name = "Price 1")]
        [Range(0, int.MaxValue)]
        public double Price1 { get; set; }

        [Display(Name = "Price 2")]
        [Range(0, int.MaxValue)]
        public double Price2 { get; set; }

        [Display(Name = "Price 3")]
        [Range(0, int.MaxValue)]
        public double Price3 { get; set; }

    }
}
