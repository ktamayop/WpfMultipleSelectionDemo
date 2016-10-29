using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class EmployeeRole
    {
        public ICollection<Employee> TakingEmployees { get; set; }
    }
}