using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace Second_DAO
{
    class CountryDAO
    {
        private string _constr;

        public CountryDAO(string constr)
        {
            _constr = constr;
        }

        public int Insert(Country ob)
        {
            int result;
            using(var con = new SqlCeConnection(_constr) )
            {
                con.Open();
                var comm = new SqlCeCommand();
                comm.Connection = con;
                comm.CommandText = "insert into Country(country_name) values(@name)";
                comm.Parameters.Add(new SqlCeParameter("@name", SqlDbType.NVarChar,100));
                comm.Parameters["@name"].Value = ob.Name;
                result = comm.ExecuteNonQuery();
                comm.Dispose();
                Console.WriteLine(result + " string inserted");
                //MessageBox.Show(result+" string inserted");  // правильно через writeline
            }

            return result;
        }

        public List<Country> Select()
        {
            List<Country> listCountry = new List<Country>();
            using (var con = new SqlCeConnection(_constr))
            {
                con.Open();
                var comm = new SqlCeCommand();
                comm.Connection = con;
                comm.CommandText = "select id, country_name from Country";
                var sr = comm.ExecuteReader();
                while (sr.Read())
                {
                    var c = new Country
                    {
                        Id = int.Parse(sr[0].ToString()),
                        Name = sr[1].ToString()
                    };
                    listCountry.Add(c);

                }

                comm.Dispose();
            }
            return listCountry;
        }

    }
}
