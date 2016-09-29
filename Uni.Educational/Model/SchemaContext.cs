using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni.Educational.Model
{
    class SchemaContext : DbContext
    {

        private const int SSPI = 0;
        private const int SQL_CREDENTALS = 1;

        public static SchemaContext Create()
        {
            var auth = int.Parse(ConfigurationManager.AppSettings["Authentication"]);
            if (auth == SSPI)
            {
                return new SchemaContext(ConfigurationManager.AppSettings["EFConnectionStringLocal"]);
            }
            else if (auth == SQL_CREDENTALS)
            {
                return new SchemaContext(ConfigurationManager.AppSettings["EFConnectionStringRemote"]);
            }
            return null;
        }

        public SchemaContext(string connectionString)
            : base(connectionString)
        {

        }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TechnologyStack> Technologies { get; set; }
    }
}
