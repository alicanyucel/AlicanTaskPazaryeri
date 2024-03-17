using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class Board:BaseEntity
    {
        public string Title { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
