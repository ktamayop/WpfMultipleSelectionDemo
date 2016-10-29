using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class Subject
    {
        public ICollection<Teacher> ReadeableTeachers { get; set; }

        public Faculty Faculty { get; set; }

        public int FacultyId { get; set; }
    }
}