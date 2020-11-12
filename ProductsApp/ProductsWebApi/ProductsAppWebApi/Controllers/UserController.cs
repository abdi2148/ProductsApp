using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAppWebApi.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userService;

        public UserController(IUserRepository userService)
        {

            _userService = userService;
        }
        // GET: api/UserController
        [Authorize]
        [HttpGet]
        public IEnumerable<User> Get() => _userService.GetUsers();

        //ERROR
        // GET api/UserController/5
        //[Authorize(Roles = "Administrator")]
        //[HttpGet("{id}")]
        //public ActionResult<User> Get(int id)
        //{
            //return _userService.ReadById(id);
        //}

        // POST api/UserController
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            return _userService.CreateUser(user);
        }

        // PUT api/UserController/5
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }

        // DELETE api/UserController/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            return _userService.DeleteUser(id);
        }
    }
}
