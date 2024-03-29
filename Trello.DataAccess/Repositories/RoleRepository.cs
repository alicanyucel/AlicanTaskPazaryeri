﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trello.DataAccess.Context;
using Trollo.Entities.Repositories;
using Trollo.Entities;

namespace Trello.DataAccess.Repositories
{
    internal sealed class RoleRepository : Repository<AppRole>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
