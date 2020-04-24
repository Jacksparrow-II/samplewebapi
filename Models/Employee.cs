using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samplewebapi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
