using AcademyCoreAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyCoreAPI.Controllers
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options)
        {

        }

        public DbSet<Student> tblStudent { get; set; }
		public DbSet<User> tblUser { get; set; }
        public DbSet<UserRole> tblUserRole { get; set; }
		public DbSet<UserDetail> USP_getUserDetails { get; set; }
	}
}
