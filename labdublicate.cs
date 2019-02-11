using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
          
            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i]+" ");
            }
            
           
        }
    }
}
