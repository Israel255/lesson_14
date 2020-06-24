using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Motorcycle : Vehice
    {
        public int _NumberOfHandBreaks;

        public override int GetMaxNumOfPassengers()
        {
            return _Driver + _Back;
        }
        public override int GetMaxSpeed()
        {
            return _NumberOfTransmissions * 10;
        }

        public override string ToString()
        {
            return "[number of hand breaks] : " + _NumberOfHandBreaks + " " + base.ToString();
        }
    }
}
