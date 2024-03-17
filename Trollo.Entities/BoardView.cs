using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class BoardView:BaseEntity
    {
        public string Title { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();

        public class Column:BaseEntity
        {
          
            public string Title { get; set; }
            public List<Card> Cards { get; set; } = new List<Card>();
        }

        public class Card:BaseEntity
        {

            public string Content { get; set; }
        }
    }
}