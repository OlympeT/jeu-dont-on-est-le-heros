using System;
using Microsoft.EntityFrameworkCore;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Droide> Droides { get; set; }
    }
}
