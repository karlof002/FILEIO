using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string hobby;

            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Alter:");
            age = Console.ReadLine();

            string txt = String.Format("Sie heissen {0} und sind {1} Jahre alt!\r\nHobbies:\r\n", name, age);

            File.WriteAllText("text.txt", txt, Encoding.Unicode);

            do
            {
                Console.Write("Hobby (Enter für ENDE):");
                hobby = Console.ReadLine();
                if (hobby!="")
                {
                    File.AppendAllText("text.txt", hobby+"\r\n");
                }
            } while (hobby!="");
        }
    }
}
