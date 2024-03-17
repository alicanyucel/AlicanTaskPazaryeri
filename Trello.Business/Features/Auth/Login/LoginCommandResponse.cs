using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trello.Business.Features.Auth.Login
{
    public sealed record LoginCommandResponse(
    string AccessToken,
    Guid UserId);
}
