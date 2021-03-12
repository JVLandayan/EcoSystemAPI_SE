using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using EcoSystemAPI.Models;

namespace EcoSystemAPI.Data
{
    public interface IAuthenticationRepos
    {
        JwtSecurityToken Authenticate(string UserName, string Password);
    }
}
