using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using RealEstateBLL.Interfaces;
using RealEstateDAL.Classes;

namespace RealEstateBLL.Classes
{
    public class ListManager<T> : IListManager<T>
    {

        private List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }
        public int Count
        {
            get
            {
                if ((m_list != null)){
                    return m_list.Count;
                }
                else{
                    return 0;
                }
            }
        }

        public bool Add(T aType)
        {
            int c = Count;
            m_list.Add(aType);
            if(c != Count)
            {
                return true;
            }
            return false;
        }

        public bool BinaryDeSerialize(string fileName)
        {
            BinaryFileHandler bf = new BinaryFileHandler();
            m_list = bf.BinaryDeSerialize<T>(fileName);
            return m_list != null;

            /* //Old Version
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
                m_list = (List<T>)obj;
                return true;
            }
            return false;
            */
        }

        public bool BinarySerialize(string fileName)
        {
            if(Count == 0)
            {
                return false;
            }
            BinaryFileHandler bf = new BinaryFileHandler();
            return bf.BinarySerialize<T>(fileName, m_list);

//            FileStream fileStream;
//            BinaryFormatter bf = new BinaryFormatter();

//            if (File.Exists(fileName)) File.Delete(fileName);
//            fileStream = File.Create(fileName);
//#pragma warning disable SYSLIB0011 // Type or member is obsolete
//            bf.Serialize(fileStream, m_list);
//#pragma warning restore SYSLIB0011 // Type or member is obsolete
//            fileStream.Close();
//            return true;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                m_list[anIndex] = aType;
                return true;
            }
            return false;
        }

        public bool CheckIndex(int index)
        {
            if(index < Count && index >= 0)
            {
                return true;
            }
            return false;
        }

        public void DeleteAll()
        {
            m_list = new List<T>();
        }

        public bool DeleteAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                m_list.RemoveAt(anIndex);
                return true;
            }
            return false;
        }

        public T GetAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                return m_list.ElementAt(anIndex);
            }
            return default(T);
        }

        public string[] ToStringArray()
        {
            string[] values = new string[Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = m_list[i].ToString();
            }
            return values;
        }

        public List<string> ToStringList()
        {
            List<string> lstr = new List<string>();
            foreach(T item in m_list)
            {
                lstr.Add(item.ToString());
            }
            return lstr;
        }

        public bool XMLSerialize(string fileName)
        {
            if (Count == 0)
            {
                return false;
            }
            XMLFileHandler xfh = new XMLFileHandler();
            return xfh.XMLSerialize<T>(fileName, m_list);
            //using (var stream = new FileStream(fileName, FileMode.Create))
            //{
            //    var XML = new XmlSerializer(typeof(List<T>));
            //    XML.Serialize(stream, m_list);
            //}
            //return true;
        }
    }
}