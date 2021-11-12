using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ITokenService
    {
        public string CreateToken(List<Claim> claims);
    }
}
