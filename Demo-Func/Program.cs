using System;
using System.Collections.Generic;

namespace Demo_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = {1,2,5,3,7,8,6,9,11,13,45,59 };
            Func<int, bool> checkNt = (num) => {
                int count = 0;
                if(num >= 2)
                {
                    for(int i = 3; i < num; i++)
                    {
                        if(num %i == 0)
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    return false;
                }
                if(count == 0)
                {
                    return true;
                }
                return false;
            };

            Func<int[], List<int>> arrNT = (arr) =>
            {
                List<int> listNt = new List<int>();
                foreach(int item in arr)
                {
                    if (checkNt(item))
                    {
                        listNt.Add(item);
                    }
                }
                return listNt;
            };
            List<int> arrAfterCheck = arrNT(arrInt);
            foreach(int item in arrAfterCheck)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
