using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string  : ");
            string mystr = Console.ReadLine();
            string updatedString = "";
            for(int i = 0; i < mystr.Length;i ++)
            {
                int myint = Convert.ToInt32(mystr[i]);
                if (i < 4)
                {
                    updatedString += mystr[i];
                    continue;
                }

                if ( myint > 64 && myint < 91  )
                {
                    updatedString += mystr[i];
                }
                else if (myint > 96 && myint < 123)
                {
                    updatedString += Convert.ToChar(mystr[i] - 32);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The Update String  : " + updatedString);
            Console.ReadKey();
        }
    }
}
