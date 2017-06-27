using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var sum = new int[array1.Length - 1];

            if (array1.Length == 1)
            {
                Console.WriteLine(array1[0]);
                return;
            }

            for (int j = 0; j < array1.Length; j++)
            {


                for (int i = 0; i < array1.Length-1; i++)
                {

                    sum[i] = array1[i] + array1[i + 1];


                }
                array1 = sum;
            }
            Console.WriteLine(sum[0]);




        }

    }
    }
//2 10 3	-->output: 25 -->	2 10 3 | 2+10 10+3 | 12 13 | 12 + 13 | 25
