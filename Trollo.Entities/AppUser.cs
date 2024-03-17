using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Trollo.Entities
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
     
    }
}
