using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CustomerApi.Models
{
    public class CustomerModel
    {
        [Key]
        public int IdCustomer { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(22)]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }
    }
}
