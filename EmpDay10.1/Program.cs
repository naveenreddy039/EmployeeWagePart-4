using System;

namespace EmpDay10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int isFullTime = 1;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if(empCheck==isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadKey();
        }
    }
}
