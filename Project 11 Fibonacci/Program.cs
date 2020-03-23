using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_11_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            //Console.WriteLine("Hangi Değere Kadar Fibonacci Dizisi Oluşturulsun:");
            //N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İlk Kaç Fibonacci Sayısı Oluşturulsun:");
            N = Convert.ToInt32(Console.ReadLine());

            int x = 1;
            int y = 1;

            int z=x+y;

            Console.Write(x+" "+y+" "+z);

            for (int i=0; i <= 6; i++ )
            {
                x = y;
                y = z;
                z = x + y;
                Console.Write(" "+z);
            }

            Console.ReadKey();
        }
    }
}
