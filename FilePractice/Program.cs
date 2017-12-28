using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            using (StreamWriter writer = new StreamWriter("SecondTaskOfPractice.txt"))
            {
                writer.WriteLine("Едиге");
                writer.WriteLine("Нуркайыр");
                writer.WriteLine(19);
            }
            Console.ReadLine();
        }

        private static void FirstTask()
        {
            char[] symbols = new char[256];
            for (int i = 0; i < 256; i++)
                symbols[i] = (char)(i);

            byte[] array;
            using (FileStream stream = new FileStream("FirstTaskOfPractice.txt", FileMode.OpenOrCreate))
            {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
            }

            foreach (var symbol in symbols)
            {
                int count = 0;
                foreach (var sym in array)
                {
                    if (symbol.Equals((char)sym))
                        count++;
                }
                Console.WriteLine(symbol + " - " + count);
            }

            Console.ReadLine();
        }
    }
}
