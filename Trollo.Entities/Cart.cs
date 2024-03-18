using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class Cart:BaseEntity
    {
        public string Name { get; set; }
        [Required]
        public string Contents { get; set; }
        public string Notes { get; set; }
        public Column Column { get; set; }
    }
}
