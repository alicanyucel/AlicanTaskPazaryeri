using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class NewBoard:BaseEntity
    {

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please use letters only without special characters and capitalize the first letter.")]
        [Required]
        public string Title { get; set; }
    }
}
