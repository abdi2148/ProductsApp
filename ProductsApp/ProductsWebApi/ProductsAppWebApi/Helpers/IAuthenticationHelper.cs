using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAppWebApi.Helpers
{
    interface IAuthenticationHelper
    {
        string GenerateToken(User user);
    }
}
