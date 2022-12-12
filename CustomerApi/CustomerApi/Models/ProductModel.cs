using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models
{
    public class ProductModel
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Serial Number")]
        public int SerialNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}
