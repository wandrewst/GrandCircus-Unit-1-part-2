using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1_Grand_Circus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Hello! Nice to have you here. --------------------\n" +
                "Please state your name.");

                      string name = Console.ReadLine();
                        Console.WriteLine("Hello {0} what is your interest today? \n 1 Action \n 2. Chill Time \n 3. Danger \n 4. Good Food ", name);
                      string number = Console.ReadLine();
                        Console.WriteLine("How many will be with you?");

              


                int result;
                         if (int.TryParse(Console.ReadLine(), out result))

            {
                if (result == 1)
                    Console.WriteLine("Well {0} I am glad to hear it, cool!", name);

                else if (result == 2)
                    Console.WriteLine("Well {0} I am sorry to hear it, that sucks!", name);

                

                else
                    Console.WriteLine("Incorrect response");
                                                             }

                                                 else
                                                                Console.WriteLine("Incorrect response");

                       
            }
        }
    }



    
