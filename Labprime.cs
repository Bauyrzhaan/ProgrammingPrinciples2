using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static bool F1(int k)
        {
            if (k <= 1) return false;
            for(int i=2;i<k;i++)
            {
                if (k % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine().Split();
            int k = arr.Length;
            int[] a = new int[k];
            for (int i = 0; i < arr.Length; i++)
            {
                a[i] = int.Parse(arr[i]);
            }
            for(int i = 0; i < a.Length; i++)
            {
                if (F1(a[i]) == true) Console.Write(a[i]+" ");
            }
        }
    }
}
