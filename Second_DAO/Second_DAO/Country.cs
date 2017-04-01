using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_DAO
{
    public class Country
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<City> Cities { set; get; }
    }
}
