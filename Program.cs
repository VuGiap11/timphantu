
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timphantumang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("moi nhap vao so luong phan tu");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("gia tri cua phan tu thu {0} = ",i);
                a[i]= int.Parse(Console.ReadLine());
            }
            int find = 5;
            bool flag = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == find)
                {
                    flag = true;
                    Console.Write("phan tu co gia tri 5 la {0}", i);
                }
            }
            if (flag == false)
            {
                Console.WriteLine("khong tim thay");
            }

        }
    }
}
