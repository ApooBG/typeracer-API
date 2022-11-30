using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class TyperacerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Ranked> Rankeds { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<MainPage> MainPage { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=studmysql01.fhict.local;Uid=dbi476278;Database=dbi476278;Pwd=e062f192A;",
            new MySqlServerVersion(new Version(8, 0, 11)));
        }

    }
}
