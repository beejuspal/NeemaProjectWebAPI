using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCoreAPI.DataModels
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
		public string Email { get; set; }
		public int RoleId { get; set; }
		public int IsActive { get; set; }
		//public string RoleName { get; set; }
	}
}
