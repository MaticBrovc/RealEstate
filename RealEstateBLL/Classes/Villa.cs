using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Villa : Residential
    {
        //Default constructor
        public Villa() { }

        //Constructor that gets the number of rooms in the estate
        public Villa(int rooms)
        {
            NumberOfRooms = rooms;
        }
    }
}