using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int m = int.Parse("56"), n = 0;
                int r = m / n;
                var ex = new FileNotFoundException("Specified file not found.");
                throw ex;

            }
            catch (FormatException fex)
            {
                Console.WriteLine("Input Error: " + fex.Message);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Illegal Operation: " + dex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unkonwn Error: " + ex.Message);
            }






            Console.ReadKey();
        }//Main
    }//Class
}//Namespace
