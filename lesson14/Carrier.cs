using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Carrier
    {
       public Vehice[] _v = new Vehice[2];

        public override string ToString()
        {
            for (int i = 0; i < _v.Length; i++)
            {
                Console.WriteLine(_v[i].ToString());
            }
            return "";

        }
    }
}
