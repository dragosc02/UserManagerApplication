using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = InstanceProvider.GetUserService();

            Console.WriteLine("******************** Welcome to the User Manager Application *************************");
            Console.WriteLine();

            Console.WriteLine("Until now there are " + userService.GetUserCount() + " users registered in the application" );

            Console.WriteLine("The youngest users has " + "WRITE_PROPER_CODE" + " years");

            Console.WriteLine("The older users has " + "WRITE_PROPER_CODE" + " years");

            // WRITE A SEQUENCCE OF CODE THAT WILL DISPLAY THE FIRST NAME OF THE USERS THAT HAVE Phd DEGREE.
            Console.WriteLine("WRITE A SEQUENCCE OF CODE THAT WILL DISPLAY THE FIRST NAME OF THE USERS THAT HAVE Phd DEGREE.");

            // WRITE A SEQUENCCE OF CODE THAT WILL DISPLAY THE FIRST NAME AND THE AGE OF THE USERS WHO's age is a prime number.
            Console.WriteLine("WRITE A SEQUENCCE OF CODE THAT WILL DISPLAY THE FIRST NAME AND THE AGE OF THE USERS WHO's age or year of birth is a prime number");


            Console.WriteLine();
            Console.WriteLine("******************** Press any key to exit *************************");

            Console.ReadLine();
        }
    }
}
