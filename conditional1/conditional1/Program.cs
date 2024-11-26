using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter thr no \n");
            int no=Convert.ToInt32(Console.ReadLine());
           
            if(no %2==0)
            { 
              
                Console.WriteLine("given no is :" + no + "No is even\n");
            }
            else
            {
                Console.WriteLine("given no :"+no +" No is odd \n");
            }
                Console.ReadLine();

                    
        }

    }
}
