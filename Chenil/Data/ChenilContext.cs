using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models;
using Chenil.Models.DonneeDAO;

namespace Chenil.Data
{
    public class ChenilContext: DbContext
    {
        public ChenilContext()
        {

        }

        //Pour les tests unitaires
        public static ChenilContext getContext()
        {
            return new ChenilContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1435;Database=master;User=sa;Password=CHANGE_THIS_P4ssW0rd!;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<MessageDAO> Messages { get; set; }
    }
}
