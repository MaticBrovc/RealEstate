using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Warehouse : Commercial
    {
        //Default constructor
        public Warehouse() { }

        //constructor that gets the Shop/warehouse type and its size
        public Warehouse(ShopType st, int s)
        {
            ShopType = st;
            Size = s;
        }
    }
}