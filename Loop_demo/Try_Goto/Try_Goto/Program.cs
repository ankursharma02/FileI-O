using System;

namespace Try_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("you are not eligible to vote ");

            Console.WriteLine("Enter you age \n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                goto ineligible;
            else
                Console.WriteLine("u r eligible to vote ");

            Console.ReadLine();
        }
    }
}
