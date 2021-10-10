using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{

    [Serializable]
    public abstract class Commercial : Estate
    {
        //Define private variables
        private ShopType shopType;
        private int size;

        //Getters and Setters
        public ShopType ShopType
        {
            get { return shopType; }
            set { shopType = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public override double Cost()
        {
            //Completly basic calculation based on size and fixed value
            int fixedCost = 15000;
            double cost = fixedCost + (size * 25);

            return cost;
        }

        public override string ToString()
        {
            return "(" + ID + ") " + this.GetType().Name + " - " + Address.ToString() + " Size: " + size + "m^2 Type: " + shopType.ToString();
        }


    }
}