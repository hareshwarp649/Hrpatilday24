using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace LambdaExpreUserRegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Check Using Lambda Expression/Function");
            LambdaRegix atom = new LambdaRegix();

            Console.WriteLine("\nEnter first Name");
            var Firstname = Console.ReadLine();
            Console.WriteLine(atom.validateFirstName(Firstname));

            Console.WriteLine("\nEnter Lastname");
            var Lastname = Console.ReadLine();
            Console.WriteLine(atom.validateLastName(Lastname));

            Console.WriteLine("\nEnter Email");
            var Email = Console.ReadLine();
            Console.WriteLine(atom.validateEmail(Email));

            Console.WriteLine("\nEnter MobileNumber");
            var Mobile = Console.ReadLine();
            Console.WriteLine(atom.validateMobilenum(Mobile));

            Console.WriteLine("\nEnter Password");
            var Pass = Console.ReadLine();
            Console.WriteLine(atom.validatePassword(Pass));
        }
    }
}
