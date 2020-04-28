using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samplewebapi.Models;

namespace samplewebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]
    
    public class empController : ControllerBase
    {
        //api        
        [HttpGet("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmployeeId=1,FirstName="Nisarg",LastName="Prajapati",DOB="14/08/1997",Department=".NET",Salary=20000},
                new Employee(){EmployeeId=2,FirstName="Hiren",LastName="Prajapati",DOB="3/02/1997",Department=".NET",Salary=10000},
                new Employee(){EmployeeId=3,FirstName="Jaimin",LastName="shah",DOB="21/04/1997",Department="CRM",Salary=100000},
                new Employee(){EmployeeId=4,FirstName="pranjal",LastName="Prajapati",DOB="14/02/1997",Department="Xamrine",Salary=30000},
                new Employee(){EmployeeId=5,FirstName="Zankar",LastName="joshi",DOB="23/08/1997",Department="BI",Salary=50000}
            };

            return employees;
        }

    }
}