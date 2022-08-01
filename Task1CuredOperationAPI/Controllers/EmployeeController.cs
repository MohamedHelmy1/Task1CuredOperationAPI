using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Task1CuredOperationAPI.Data.Model;
using Task1CuredOperationAPI.Repository;

namespace Task1CuredOperationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRep employeeRep;

        public EmployeeController(IEmployeeRep employeeRep)
        {
            this.employeeRep = employeeRep;
        }
        //Add Employee
        [HttpPost]
        public IActionResult AddEmployee(EmployeeViewModel Employee)
        {
            var data = employeeRep.Add(Employee);
            if (data == true)
            {
                return Ok(data);

            }
            return Ok(data);
        }
        //GetAll Employee
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var data = employeeRep.GetAll();

            return Ok(data);
        }
        //Get Employee
        [HttpGet]
        [Route("{Id:Guid}")]
        public IActionResult GetEmployee([FromRoute] Guid Id)
        {
            var data = employeeRep.GetById(Id);

            return Ok(data);
        }
        //Remove Employee
        [HttpDelete]
        [Route("{Id:Guid}")]
        public IActionResult RemoveEmployee([FromRoute] Guid Id)
        {
            var data = employeeRep.GetById(Id);
            if (data != null)
            {
                var data1 = employeeRep.Delete(Id);

                return Ok(data1);

            }
            return NotFound();
        }
        //Update Employee
        [HttpPut]
        [Route("{Id:Guid}")]
        public IActionResult UpdateEmployee([FromRoute] Guid Id,EmployeeViewModel Employee)
        {
            var data = employeeRep.GetById(Id);
            if (data != null)
            {
               
                var data1 = employeeRep.Update(Id,Employee);

                return Ok(data1);

            }
            return NotFound();
        }
    }
}
