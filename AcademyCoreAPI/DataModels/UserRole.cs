using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCoreAPI.DataModels
{
    public class UserRole
    {
        public int Id { get; set; }

        public string RoleName { get; set; }
      
        public int IsActive { get; set; }

		public int IsAdmin { get; set; }
	}
}
