using Forum.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Contracts
{
    public interface IJwtGenerator
    {
        string GenerateToken(User applicationUser, IEnumerable<string> roles);

    }
}
