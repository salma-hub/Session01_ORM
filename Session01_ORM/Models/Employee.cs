using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_ORM.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(1)]
        [Length(1, 100)]
        public string? Name { get; set; }
      
        [Required]
        [Range(20,90)]
        [AllowedValues(20,40,60)]
        [DeniedValues(30,67)]
        public int Age { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [DefaultValue(3000)]
        [DataType(DataType.Currency)]
        public decimal salary { get; set; }
    }
}
