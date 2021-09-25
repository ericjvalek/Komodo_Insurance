using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Library
{
    public class Developer
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public bool HasPluralsight { get; set; }
        public Developer(string name, int id, bool pluralsight)
        {
            Name = name;
            ID = id;
            HasPluralsight = pluralsight;
        }
    }

}
