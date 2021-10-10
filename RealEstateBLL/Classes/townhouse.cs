using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Townhouse : Residential
    {
        //Default constructor
        public Townhouse() { }

        //Constructor that gets the number of rooms in the estate
        public Townhouse(int rooms)
        {
            NumberOfRooms = rooms;
        }
    }
}