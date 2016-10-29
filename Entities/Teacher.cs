using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class Teacher : Employee
    {
        public ICollection<Subject> ReadeableSubjects { get; set; }

        public Teacher()
        {
            ReadeableSubjects = new List<Subject>();
        }
    }
}
