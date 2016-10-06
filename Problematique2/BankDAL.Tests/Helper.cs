using BankDAL.Tests.Properties;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankDAL.Tests
{
    public class Helper
    {
        public static void ReinitialiserBaseDeDonnees()
        {
            using (SqlConnection conn = BankAccountManager.GetDatabaseConnection())
            {
                conn.Open();
                SqlCommand resetTableContentCommand = new SqlCommand(Resources.resettable, conn);
                resetTableContentCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
