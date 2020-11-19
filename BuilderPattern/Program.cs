using BuildPattern.BuilderPattern;
using System;

namespace BuildPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentBuilder sb = new StudentBuilder();
            Student oneParameter = sb.WithName("Marie").Build();
            Student twoParameter = sb.WithName("Jonh").WithAge(25).Build();
            Student threeParameter = sb.WithName("Jonh").WithAge(25).WithBithdayDate(new DateTime()).Build();

            Console.WriteLine($"oneParameter => {oneParameter}");
            Console.WriteLine($"twoParameter => {twoParameter}");
            Console.WriteLine($"threeParameter => {threeParameter}");

        }
    }
}
