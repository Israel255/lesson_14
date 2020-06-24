using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    class Car : Vehice
    {
        public int _NumberOfDoors;
        public int _NearTheDriver;

        public override int GetMaxNumOfPassengers()
        {
            return _Driver + _NearTheDriver + _Back;
        }
        public override int GetMaxSpeed()
        {
            return _NumberOfTransmissions * 20;
        }

        public override string ToString()
        {
            return "[number of doors] : " + _NumberOfDoors + " " + base.ToString();
        }
    }
}
