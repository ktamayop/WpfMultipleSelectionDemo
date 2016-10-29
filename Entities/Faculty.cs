using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class Faculty : Entity
    {
        #region POCO Fields

        public string Acronym { get; set; }

        public string FacultyNameEn { get; set; }

        public string FacultyNameRu { get; set; }

        public string FacultyDescriptionEn { get; set; }

        public string FacultyDescriptionRu { get; set; }

        #endregion

        #region Navigations

        public ICollection<Department> Departments { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Subject> Subjects { get; set; }

        public ICollection<Specialty> Specialties { get; set; }

        #endregion

        #region Constructors

        public Faculty(string facultyAcronym, string facultyNameEn, string facultyNameRu,
            string facultyDescriptionEn, string facultyDescriptionRu)
            : this()
        {
            Acronym = facultyAcronym;
            FacultyNameEn = facultyNameEn;
            FacultyNameRu = facultyNameRu;
            FacultyDescriptionEn = facultyDescriptionEn;
            FacultyDescriptionRu = facultyDescriptionRu;
        }

        public Faculty()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
            Students = new List<Student>();
            Subjects = new List<Subject>();
            Specialties = new List<Specialty>();
            Teachers = new List<Teacher>();
        }

        #endregion

    }
}