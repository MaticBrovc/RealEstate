using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using RealEstateBLL.Classes;
using RealEstateBLL.Interfaces;

namespace RealEstateBLL.Classes
{
    [Serializable]
    //XML includes so XML serialization is possible with all objects.
    [XmlInclude(typeof(Villa))]
    [XmlInclude(typeof(Townhouse))]
    [XmlInclude(typeof(Rental))]
    [XmlInclude(typeof(Tenement))]
    [XmlInclude(typeof(Shop))]
    [XmlInclude(typeof(Warehouse))]
    [XmlInclude(typeof(School))]
    [XmlInclude(typeof(University))]
    public abstract class Estate : IEstate
    {
        //Define private variables from the Interface
        private int t_ID;

        private Address t_address;

        private string t_imagePath;

        private LegalForm t_legalForm;

        //Getters and Setters for the variables
        public int ID
        {
            get { return t_ID; }
            set { t_ID = value; }
        }
        public Address Address
        {
            get { return t_address; }
            set { t_address = value; }
        }

        public string ImagePath
        {
            get { return t_imagePath; }
            set { t_imagePath = value; }
        }

        public LegalForm LegalForm
        {
            get { return t_legalForm; }
            set { t_legalForm = value; }
        }

        //Function that will be implemented in other clases
        public abstract double Cost();

        public override string ToString()
        {
            return "(" +ID + ") " +  t_address.ToString();
        }
    }
}