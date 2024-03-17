using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Business.Features.Roles.GetRoles
{
    public sealed record GetRolesQueryResponse(
     Guid Id,
     string Name);
}
