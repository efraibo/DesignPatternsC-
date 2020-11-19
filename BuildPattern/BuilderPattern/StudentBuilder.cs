using System;

namespace BuildPattern.BuilderPattern
{
    public class StudentBuilder
    {
        private Student _student = new Student();

        public Student Build() => _student;

        public StudentBuilder WithName(string name)
        {
            _student.Name = name;
            return this;
        }

        public StudentBuilder WithAge(int age)
        {
            _student.Age = age;
            return this;
        }

        public StudentBuilder WithBithdayDate(DateTime BirthdayDate)
        {
            _student.BirthDate = BirthdayDate;
            return this;
        }
    }
}
