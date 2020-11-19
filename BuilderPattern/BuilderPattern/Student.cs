using System;

namespace BuildPattern.BuilderPattern
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)} = {Name} , {nameof(Age)} = {Age} , {nameof(BirthDate)} = {BirthDate}";
        }

    }
}
