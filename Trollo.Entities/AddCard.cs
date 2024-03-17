using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
   public class AddCard:BaseEntity
    {
        [Required]
        public string Contents { get; set; }
    }
}
