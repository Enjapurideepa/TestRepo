
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8_2
{
    class Lab8q2
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable = GetHashtable();
            if (hashtable.Contains("Perimeter"))
                Console.WriteLine("Perimeter is Present in Hashtable");
            else
                Console.WriteLine("Perimeter is Not Present in Hashtable");
            Console.WriteLine(hashtable.ContainsKey("Perimeter"));
            //Contains and ContainsKey Both Methods Returs True If the Key is Prsenet and works in Same Manner.
            string area = hashtable["Area"].ToString();
            Console.WriteLine($"The Value Of Area is : {area}");
            Console.WriteLine("Displaying Data Before Deletion Of Mortgage : ");
            foreach (Object d in hashtable.Keys)
                Console.WriteLine($"{d} : {hashtable[d]}");
            hashtable.Remove("Mortgage");
            Console.WriteLine();
            Console.WriteLine("Displaying Data After Deletion Of Mortgage : ");
            foreach (Object d in hashtable.Keys)
                Console.WriteLine($"{d} : {hashtable[d]}");
            Console.ReadKey();
        }
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }

    }
}

