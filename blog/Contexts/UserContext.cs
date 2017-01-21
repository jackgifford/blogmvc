using blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace blog.Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}