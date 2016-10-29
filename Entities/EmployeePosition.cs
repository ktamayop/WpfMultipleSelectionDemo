using System.Collections.Generic;

namespace DomainSample.Entities
{
    public class EmployeePosition
    {
        public ICollection<Employee> TakingEmployees { get; set; }
    }
}