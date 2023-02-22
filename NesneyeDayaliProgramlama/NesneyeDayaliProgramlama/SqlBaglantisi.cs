using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace NesneyeDayaliProgramlama
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()//baglanti metodum
        { //baglan nesnem
            SqlConnection baglan = new SqlConnection("Data Source=MAT225;Initial Catalog=okul;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
