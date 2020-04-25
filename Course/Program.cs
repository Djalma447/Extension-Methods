using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 04, 24, 22, 47, 00);
            Console.WriteLine(dt.TimeElapse());
        }
    }
}
