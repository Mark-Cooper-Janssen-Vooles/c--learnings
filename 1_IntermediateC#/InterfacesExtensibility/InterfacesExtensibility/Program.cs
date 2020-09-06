using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}
