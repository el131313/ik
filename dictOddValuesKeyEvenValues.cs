using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            
            
            
            while (input!="stop")
            {
                var number = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(input))
                {
                    dict[input] = 0;

                }
               
                    dict[input] += number;

                
                
               

                
                input = Console.ReadLine();
               
            }
            
            

           

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
//Gold
//155
//Silver
//10
//Copper
//17
//stop

//    Output
//Gold -> 155
//Silver -> 10
//Copper -> 17
