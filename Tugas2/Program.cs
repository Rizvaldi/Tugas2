using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2
{
    class Program
    {
            static void Main(string[] args)
            {
                new Program().Tugas2();
            }
            public void Tugas2()
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source = MSI\\MSSQLSERVER02; database = ExerciseSatu; User ID = sa; Password = 123");
                    con.Open();

                    SqlCommand cm = new SqlCommand("insert into owner(id_owner, Nama, Alamat) values ('031', 'Erik', 'Batam')" +
                        "insert into owner(id_owner, Nama, Alamat) values ('032', 'Indra', 'Kaltara')" + "insert into owner(id_owner, Nama, Alamat) values ('033', 'Aldo', 'Kalteng')" + 
                        "insert into owner(id_owner, Nama, Alamat) values ('034', 'Paldi', 'Riau')" + "insert into owner(id_owner, Nama, Alamat) values ('035', 'Ucup', 'Bekasi')", con);
                    cm.ExecuteNonQuery();

                    Console.WriteLine("Sukses menambahkan data");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Gagal menambahkan data, " + e);
                    Console.ReadKey();
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }