using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class Column:BaseEntity
    {
        public string Title { get; set; }
        public List<Cart> Cards { get; set; } = new List<Cart>();
        public int BoardId { get; set; }
    }
}
