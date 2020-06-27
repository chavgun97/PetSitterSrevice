using PetSitterSrevice.ORM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetSitterSrevice.ORM
{
    public class PetSitterDbContext : DbContext
    {
        public PetSitterDbContext() : base("DbConectionString")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Sitter> Sitters { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}