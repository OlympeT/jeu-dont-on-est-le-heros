using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MesPremiersTestsAvecEntitiesCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Recuperation du json de connnectio
            ConfigurationBuilder builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();
            #endregion

            #region Definir la connection
            string connectionString = config.GetConnectionString("DefaultContext");

            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            #endregion

            #region Definir un connection de typ SQL SERVER
            optionsBuilder.UseSqlServer(connectionString);
            #endregion

            using (DefaultContext context = new DefaultContext(optionsBuilder.Options))
            {
                var query = from droide in context.Droides
                            select droide;

                foreach (var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);
                }

            }

            Console.WriteLine("Hello World!");
        }
    }
}
