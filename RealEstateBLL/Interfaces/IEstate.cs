using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RealEstateBLL.Classes;
using RealEstateBLL.Enumerators;

namespace RealEstateBLL.Interfaces 
{ 
    public interface IEstate
    {
        //Define the variables
        int ID { get; set; }
        Address Address { get; set; }

        string ImagePath { get; set; }

        LegalForm LegalForm { get; set; }

        double Cost();
        //Cost of the estate function that could vary by different residental status.
    }
    
}