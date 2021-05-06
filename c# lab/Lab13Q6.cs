using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.IO;

namespace Lab13
{
    [Serializable]
    public class Student : ISerializable
    {
        private int rollNo;
        private string name;
        private string city;
        private string degree;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Degree { get => degree; set => degree = value; }
        public Student()
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("RollNo", RollNo, typeof(int));
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("City", City, typeof(string));
            info.AddValue("Degree", Degree, typeof(string));

        }
        public Student(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            rollNo = (int)info.GetValue("RollNo", typeof(int));
            name = (string)info.GetValue("Name", typeof(string));
            city = (string)info.GetValue("City", typeof(string));
            degree = (string)info.GetValue("Degree", typeof(string));
        }
    }
    public class Iserlize
    {
        static void Main()
        {
            // This is the name of the file holding the data. You can use any file extension you like.
            string fileName = "dataStuff.myData";

            // Use a BinaryFormatter or SoapFormatter.
            IFormatter formatter = new BinaryFormatter();
            //IFormatter formatter = new SoapFormatter();

            Iserlize.SerializeItem(fileName, formatter); // Serialize an instance of the class.
            Iserlize.DeserializeItem(fileName, formatter); // Deserialize the instance.
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public static void SerializeItem(string fileName, IFormatter formatter)
        {
            // Create an instance of the type and serialize it.
            Student t = new Student();
            t.RollNo = 1;
            t.Name = "deepa";
            t.City = "Hyderabad";
            t.Degree = "BE";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }

        public static void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            Student t = (Student)formatter.Deserialize(s);
            Console.WriteLine(t.RollNo + " " + t.Name + " " + t.City + " " + t.Degree);

        }
    }
}

