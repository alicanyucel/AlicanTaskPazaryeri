using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
    public class BoardList:BaseEntity
    {
        public List<Board> Boards = new List<Board>();

        public class Board
        {
            
            public string Title { get; set; }
        }
    }
}
