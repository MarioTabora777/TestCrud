using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class MasterRepository
    {
        public TestCrudDBContext db { get; set; }

        public MasterRepository()
        {
            string assemblyPath = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName+ "\\TestCrud\\connectionstring.txt";
             
            string conectionstring = System.IO.File.ReadAllText(assemblyPath);
                TestCrudDBContext.Conectionstring  = conectionstring;
            db = new TestCrudDBContext();
        }

    }
}
