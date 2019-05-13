using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4_5_2
{
    class Program
    {
       static bool IsSum(int number, List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        sum = list[i] + list[j];
                        if (sum == number)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    sum = list[i] + list[0];
                    if (sum == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int n, X, S;
            bool isSum;
            List<int> series = new List<int>();
            Console.Write("Vavedete cialoto chislo X:");
            X = int.Parse(Console.ReadLine());
            Console.Write("Vavedete broia na chlenovete na reditsata S:");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.Write("Chisloto {0} e:",i);
                S = int.Parse(Console.ReadLine());
                series.Add(S);
            }
            isSum = IsSum(X, series);
            if (isSum==true)
            {
                Console.Write("V masiava IMA dva elementa, chiato suma savpada s chisloto X!");
            }
            else
            {
                Console.Write("V masiava NIAMA dva elementa, chiato suma savpada s chisloto X! ");
            }
            Console.ReadKey();
        }
    }
}
