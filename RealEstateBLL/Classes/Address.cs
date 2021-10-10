using RealEstateBLL.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Classes
{
    [Serializable]
    public class Address
    {
        /* Properties of the class */
        string street;
        string zip;
        string city;
        Countries country;

        //Default constructor
        public Address() { }

        //Constructor that gets all the necessary data to create an object with a full Address
        public Address(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zip = zip;
            this.city = city;
            this.country = country;
        }

        //Function to update the address on already created address object.
        public void update(string street, string zip, string city, Countries country)
        {
            this.street = street;
            this.zip = zip;
            this.city = city;
            this.country = country;
        }
        //Tostring methods that defines the format of the address
        public override string ToString()
        {
            return street + " " + zip + " " + city + " " + country.ToString();
        }

        //Method that returns the address in a form of a string array
        public string[] getAdrress()
        {
            string[] s = { street, zip, city };
            return s;
        }
        //Method that returns the country of the address
        public Countries getCountry()
        {
            return country;
        }

        public Dictionary<string, Object> getParemeters()
        {
            Dictionary<string, Object> parms = new Dictionary<string, object>
            {
                { "street", street },
                { "zip", zip },
                { "city", city },
                { "country", country }
            };

            return parms;
        }
    }
}
