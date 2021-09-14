using EstateProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateProject.DataAccess.EntityFrameworkCore
{
    public class EstateProjectDBContext:DbContext
    {
        //public EstateProjectDBContext(DbContextOptions options) : base(options)
        //{

        //}

        //public EstateProjectDBContext(DbContextOptions<EstateProjectDBContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EstateProjectDB;Trusted_Connection=True");
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=EstateDb;Trusted_Connection=True");
        //}

        #region --DbSet--
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        //public DbSet<UserWorkPlace> UserWorkPlaces { get; set; }
        public DbSet<EstateType> EstateTypes { get; set; }
        #endregion



    }
}
