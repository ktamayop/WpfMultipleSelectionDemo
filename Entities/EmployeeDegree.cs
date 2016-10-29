using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class EmployeeDegree
    {
        public ICollection<Employee> TakingEmployees { get; set; }
    }
}