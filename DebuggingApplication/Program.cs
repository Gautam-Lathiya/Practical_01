using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something: ");
            string userResponse = Console.ReadLine();
            try
            {
                if (Convert.ToBoolean(int.Parse(userResponse)))
                {

                    Console.WriteLine("The entered value is a integer");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The entered value is not a integer");
            }
        }
    }
}
