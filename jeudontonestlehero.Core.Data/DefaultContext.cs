using System;
using jeudontonestlehero.Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestlehero.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Proprietes
        public DbSet<Aventure> Aventures { get; set; }
        public DbSet<Paragraphe> Paragraphes { get; set; }
        #endregion
    }
}
