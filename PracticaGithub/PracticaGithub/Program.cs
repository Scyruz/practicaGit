using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            if (File.Exists("numeros.txt"))
            {
                // Console.WriteLine("Todo bien");
                string[] text = File.ReadAllLines("numeros.txt");
                int numLineas = text.Length;
                
                for (int i = 0; i < numLineas; i++)
                {
                    string linea = text[i];
                    string[] nums = linea.Split();
                    int numNums = nums.Length;

                    for (int u = 0; u < numNums; u++)
                    {
                        string numeroString = nums[u];
                        int numInt = Int32.Parse(numeroString);
                        if (numInt % 10 == 0)
                        {
                            counter++;
                        }

                    }
                }
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("Todo mal");
            }
        
        }
    }
}
