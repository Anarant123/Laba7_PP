//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba7.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
        //public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}
    }
}
