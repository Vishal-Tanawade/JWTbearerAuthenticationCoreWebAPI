using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JWTbearerAuthenticationCoreWebAPI.Models
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly string Key;

        public JwtAuthenticationManager(string Key)
        {
            this.Key = Key;
        }



        public string Authenticate(string email, string username, string password)
        {

            var tokenHandler = new JwtSecurityTokenHandler();// install System.IdentityModel.Tokens.Jwt
            var tokenKey = Encoding.ASCII.GetBytes(Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, email),
                    new Claim(ClaimTypes.Name,username)
                }
                ),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
