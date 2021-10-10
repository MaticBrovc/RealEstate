using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RealEstateDAL.Classes
{
    public class XMLFileHandler
    {
        public bool XMLSerialize<T>(string fileName, List<T> m_list)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(List<T>));
                XML.Serialize(stream, m_list);
                return true;
            }
            return false;
        }
    }
}
