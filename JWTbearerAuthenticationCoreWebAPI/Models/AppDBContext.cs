using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTbearerAuthenticationCoreWebAPI.Models
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }

        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


    }
}
