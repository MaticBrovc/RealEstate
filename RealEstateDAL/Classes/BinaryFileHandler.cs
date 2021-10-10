using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDAL.Classes
{
    public class BinaryFileHandler
    {
        public bool BinarySerialize<T>(string fileName, List<T> m_list)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(fileName)) File.Delete(fileName);
            fileStream = File.Create(fileName);
            #pragma warning disable SYSLIB0011 // Type or member is obsolete
            bf.Serialize(fileStream, m_list);
            #pragma warning restore SYSLIB0011 // Type or member is obsolete
            fileStream.Close();
            return true;
        }

        public List<T> BinaryDeSerialize<T>(string fileName)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new();
            if (File.Exists(fileName))
            {
                fileStream = File.OpenRead(fileName);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                obj = bf.Deserialize(fileStream);
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                fileStream.Close();
                return (List<T>)obj;
            }
            return null;
        }
    }
}
