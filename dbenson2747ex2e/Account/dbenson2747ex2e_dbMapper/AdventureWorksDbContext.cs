using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dbenson2747ex2e_dbmapper
{
    class AdventureWorksDbContext
    {
        public static SqlConnection connection;
        public static SqlTransaction transaction;
    }
}
