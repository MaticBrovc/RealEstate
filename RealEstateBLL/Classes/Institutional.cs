using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Institutional : Estate
    {
        //Private variables of the class
        private StudyField studyField;

        //Getters and Setters
        public StudyField StudyField
        {
            get { return studyField; }
            set { studyField = value; }
        }

        public override double Cost()
        {
            //Completly basic calculation based on fixed value * (index of enum + 1)
            int fixedCost = 15000;
            int index = Array.IndexOf(Enum.GetValues(StudyField.GetType()), studyField) + 1;
            double cost = fixedCost + (5000*index);

            return cost;
        }

        public override string ToString()
        {
            return "(" + ID + ") " + this.GetType().Name + " - " + Address.ToString() + " Study Field: " + studyField.ToString();
        }
    }
}