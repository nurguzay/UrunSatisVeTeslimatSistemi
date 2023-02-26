using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proje
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti() {
            SqlConnection sql = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=model;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return sql;
        }
    }
}
