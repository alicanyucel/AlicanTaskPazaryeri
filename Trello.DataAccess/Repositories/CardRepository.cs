using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.DataAccess.Context;
using Trollo.Entities;
using Trollo.Entities.Repositories;

namespace Trello.DataAccess.Repositories
{
    internal sealed class CardRepository : Repository<Cart>
    {
        public CardRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
