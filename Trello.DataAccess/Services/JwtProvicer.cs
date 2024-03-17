using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Trello.DataAccess.Context;
using Trollo.Entities;
using Trollo.Entities.Options;

namespace Trello.DataAccess.Services
{
    internal sealed class JwtProvider : IJwtProvider
    {
        private readonly ApplicationDbContext _context;
        private readonly Jwt _jwt;
        public JwtProvider(ApplicationDbContext context, IOptions<Jwt> jwt)
        {
            _context = context;
            _jwt = jwt.Value;
        }

        public async Task<string> CreateTokenAsync(AppUser user)
        {
            Claim[] claims = new Claim[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim("NameLastname", string.Join(" ",user.Name,user.Lastname)),
            new Claim("Email", user.Email)
            };

            JwtSecurityToken securityToken = new(
                issuer: _jwt.Issuer,
                audience: _jwt.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddDays(5),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.SecretKey)), SecurityAlgorithms.HmacSha512));

            JwtSecurityTokenHandler handler = new();
            string token = handler.WriteToken(securityToken);

            return token;
        }
    }
}
