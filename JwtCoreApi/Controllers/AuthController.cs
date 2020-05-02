using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JwtCoreApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtCoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Login()
        {
            return Ok("Login get executed");
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (login.Username == "neeraj" && login.Password == "password")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name,login.Username),
                    new Claim(ClaimTypes.PostalCode,"560067"),
                    new Claim(ClaimTypes.Country, "India"),
                    new Claim("MyClaim", "MyClaimValue")
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("thisismysecuritystring"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.Now.AddDays(1),
                    SigningCredentials = creds
                };

                var tokenhandler = new JwtSecurityTokenHandler();
                var token = tokenhandler.CreateToken(tokenDescriptor);

                return Ok(new
                {
                    token = tokenhandler.WriteToken(token)
                });
            }

            else
                return Unauthorized();
        }
    }
}