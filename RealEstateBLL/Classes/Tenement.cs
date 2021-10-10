using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Tenement : Appartment
    {
        //Default constructor
        public Tenement() { }

        //Constructor that gets the number of rooms in the estate
        public Tenement(int rooms)
        {
            NumberOfRooms = rooms;
        }
    }
}