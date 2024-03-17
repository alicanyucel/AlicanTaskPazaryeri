using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trollo.Entities.Abstractions;

namespace Trollo.Entities
{
  public  class MoveCardCommand:BaseEntity
    {
        public Guid CardId { get; set; }
        public Guid ColumnId { get; set; }
    }
}
