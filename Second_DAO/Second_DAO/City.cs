using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_DAO
{
    public class City
    {
        public int Id {set;get;}
        public string Name { set; get; }
        public Country Country { set; get; }
    }
}
