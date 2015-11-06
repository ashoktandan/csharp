using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApplication41
{
    class Program
    {
        static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;Initial Catalog=student;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        static void Main(string[] args)
        {
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
            da.Fill(ds); 

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                var v = r.ItemArray.GetValue(0).ToString();
              
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
