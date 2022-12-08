using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PassengerTransportCompany
{

    internal class DatabaseContext : DbContext
    {

        public DatabaseContext() : base("DefaultConnection")
        {
            Database.SetInitializer<DatabaseContext>(new DataInitializer());
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
