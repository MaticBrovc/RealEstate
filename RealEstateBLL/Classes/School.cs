using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class School : Institutional
    {
        //Default constructor
        public School() { }

        //Constructor that gets the study field as a property
        public School(StudyField sf)
        {
            StudyField = sf;
        }
    }
}