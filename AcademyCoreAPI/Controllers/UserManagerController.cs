using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademyCoreAPI.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
   
    public class UserManagerController : ControllerBase
    {
        private readonly AcademyContext _context;
        public UserManagerController(AcademyContext context)
        {
            _context = context;
        }

        // GET: api/Users
        // Get all User Details
        //[Route("api/User")]
        [HttpGet("User")]
        public IEnumerable<User> GetAllUser()
        {
            return _context.tblUser;
        }

        // Get all User Roles
        //[Route("api/UserRole")]
        [HttpGet("AllUserRole")]
        public IEnumerable<UserRole> GetUserRoles()
        {
            return _context.tblUserRole;
        }
		// Get all User List
		[HttpGet("AllUser")]
		public IEnumerable<UserDetail> GetUsers()
		{
			List<UserDetail> lst = _context.USP_getUserDetails
					 .FromSql("USP_getUserDetails").ToList();
			return lst;
		}

		// Get all User Roles Except Admin
		//[Route("api/UserRole")]
		[HttpGet("OtherUserRole")]
		public List<UserRole> GetOtherUserRoles()
		{
			//return _context.tblUserRole;

			//if (!ModelState.IsValid)
			//{
			//	return BadRequest(ModelState);
			//}
			List<UserRole> userRoleLst = new List<UserRole>();
			userRoleLst =  _context.tblUserRole.Where(m => m.IsAdmin == 0).ToList();

			if (userRoleLst != null)
			{
				return userRoleLst;
			}
			else
			{
				return null;
			}

			
		}

        // POST: api/Users
        [HttpPost("AddUser")]
        public async Task<IActionResult> PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.tblUser.Add(user);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetUser", new { id = user.UserId }, user);
            return Ok(user);
        }
    }
}