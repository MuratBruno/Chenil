using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models;
using Chenil.Models.DonneeDAO;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Chenil.Models.Users;
using IdentityServer4.EntityFramework.Options;
using Microsoft.Extensions.Options;

namespace Chenil.Data
{
    public class ChenilContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ChenilContext(DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        //Pour les tests unitaires
       /*public static ChenilContext getContext()
        {
            return 
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=db;Database=master;User=sa;Password=CHANGE_THIS_P4ssW0rd!;");
        }

    
        //entities
        public DbSet<MessageDAO> Messages { get; set; }
    }
}
