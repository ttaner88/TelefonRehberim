using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberim
{
    internal class Baglanti
    {
        public string telreh = System.IO.File.ReadAllText(@"C:\TelefonRehberim.txt");
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(telreh);
            baglan.Open();
            return baglan;
        }
    }
}

