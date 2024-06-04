using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using proy_web_api.Models;
using System.Linq.Expressions;

namespace proy_web_api.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            try
            {
                var dbcreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;    
                if (dbcreator != null) 
                { if (!dbcreator.CanConnect())
                        dbcreator.Create();
                  if(!dbcreator.HasTables())
                        dbcreator.CreateTables();
                }


            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
