using System;
using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class Employee : Entity
    {
        #region POCO Fields 

        public string EmployeeId { get; set; }
        
        //Complex Types
        public PrimaryPersonalData PrimaryPersonalData { get; set; }

        public ContactPersonalData ContactPersonalData { get; set; }

        #endregion

        #region Navigations
        public ICollection<EmployeePosition> EmployeeCurrentPositions { get; set; }
        public ICollection<EmployeeDegree> EmployeeCurrentDegrees { get; set; }
        public ICollection<EmployeeRole> EmployeeCurrentRoles { get; set; }
        public ICollection<Department> AdministrationDepartments { get; set; }

        public Guid? FacultyId { get; set; }

        public Faculty Faculty { get; set; }

        public Guid? SectorId { get; set; }

        public Sector Sector { get; set; }

        public Guid? AcademicDepartmentId { get; set; }

        public Department AcademicDepartment { get; set; }


        #endregion

        #region Constructors
        public Employee()
        {
            EmployeeCurrentPositions = new List<EmployeePosition>();
            EmployeeCurrentDegrees = new List<EmployeeDegree>();
            EmployeeCurrentRoles = new List<EmployeeRole>();
            AdministrationDepartments = new List<Department>();
            PrimaryPersonalData = new PrimaryPersonalData();
            ContactPersonalData = new ContactPersonalData();

        }

        #endregion

    }
}