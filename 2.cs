using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1_Grand_Circus_second
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Please state your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0} What are you looking to do today? \n 1) Action \n 2) Chilling \n 3) Danger \n 4) Good Food.", name);
            string result = Console.ReadLine();
            
            Console.WriteLine("How many will be joining you today?");

            string eventResult = Console.ReadLine();
                if (eventResult = 1)
            { Console.WriteLine("Well {0}, you should go stock car racing", name); }

            else if (eventResult = 2)
            { Console.WriteLine("Well {0}, you should try hiking", name); }
            else if (eventResult = 3)
            { Console.WriteLine("Well {0}, try skydiving today", name); }
            else if (eventResult = 4)
            { Console.WriteLine("Well {0}, you should go to Taco Bell!", name); }

            string travelResult = Console.ReadLine();

                int peopleCount = if (int.TryParse(Console.ReadLine(), out peopleCount))
                
               if(travelResult = 0)
            { Console.WriteLine("You should travel by sneakers"); }
               else if (travelResult = 1 && <= 4)
            { Console.WriteLine{ "You should travel by sedan"}; }
                else if(travelResult= >= 5 &&  < 10)
            { Console.WriteLine("You should travel by Volkswagen Bus"); }
                else if (travelResult = > 11 )
            { Console.WriteLine("You should travel by airplane"); }

          }

            








            Console.ReadLine();


        }
    }
}
