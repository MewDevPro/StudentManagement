using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    internal class Student
    {
        public Student(string id, string name, string birthday, decimal fScore, decimal sScore)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            FScore = fScore;
            SScore = sScore;
            AScore = (new List<decimal> { fScore, sScore }).Average();
        }

        public string Id { get; }

        public string Name { get; }

        public string Birthday { get; }

        public decimal FScore { get; }

        public decimal SScore { get; }

        public decimal AScore { get; }
    }
}
