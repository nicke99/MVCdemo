
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class MVCModel
    {
        [Required]
        [StringLength(100)]
        public string Hello { get; set; }
    }
}
