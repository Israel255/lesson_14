using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    abstract class Vehice
    {
        public int _NumberOfWheels;
        public string _Model;
        public int _Driver;
        public int _Back;
        public int _NumberOfTransmissions;

        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
           int max_passengers = GetMaxNumOfPassengers();
           int max_speed = GetMaxSpeed();
            return $"[model] : {_Model} [number of wheels] : {_NumberOfWheels} [max speed] : {max_speed} [max passengers] : {max_passengers} ";
        }
    }
}
