using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models
{
    public class ProductOrdersModel
    {
        [Key]
        public int IdOrders { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [MaxLength(50)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
    }
}
