using Microsoft.AspNetCore.Mvc;
using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using ProductsAppWebApi.Models;
using System.Linq;
using ProductsAppWebApi.Helpers;

namespace ProductsAppWebApi.Controllers
{
    [Route("/token")]
    public class TokenController : Controller
    {
        private readonly IUserRepository<User> repository;
        private IAuthenticationHelper authenticationHelper;
        public TokenController(IUserRepository<User> repos)
        {
            repository = repos;
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginInputModel model)
        {


            var user = repository.GetUsers().FirstOrDefault(u => u.Username == model.Username);


            // check if username exists
            if (user == null)
                return Unauthorized();

            // check if password is correct
            if (!model.Password.Equals(user.Password))
                return Unauthorized();

            // Authentication successful
            return Ok(new
            {
                username = user.Username,
                token = authenticationHelper.GenerateToken(user)
            });
        }
    }   
}
