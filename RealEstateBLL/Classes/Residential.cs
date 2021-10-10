using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Residential : Estate
    {
        //private variable
        private int numberOfRooms;

        //Getters and Setters
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }

        public override double Cost()
        {
            //Completly basic calculation based on fixed value(10000) + number of rooms * fixed value(1500)
            int fixedCost = 10000;
            double cost = fixedCost + (NumberOfRooms * 1500);

            return cost;
        }

        //To string function that shows entries and their properties.
        public override string ToString()
        {
            return "(" + ID + ") " + this.GetType().Name + " - " + Address.ToString() + " Rooms: " + numberOfRooms; 
        }
    }
}