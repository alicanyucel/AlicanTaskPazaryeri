using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trollo.Entities.Event.Users
{
    public sealed class UserDomainEvent : INotification
    {
        public AppUser AppUser { get; }

        public UserDomainEvent(AppUser appUser)
        {
            AppUser = appUser;
        }
    }
}
