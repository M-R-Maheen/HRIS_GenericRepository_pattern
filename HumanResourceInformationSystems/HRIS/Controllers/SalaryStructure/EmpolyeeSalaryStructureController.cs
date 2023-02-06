using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryStructure
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeSalaryStructureController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EmpolyeeSalaryStructureController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ess = await unitOfWork.employeeSalaryStructureRepo.GetAllAsync();

            return Ok(ess);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.employeeSalaryStructureRepo.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Employee Salary Structure ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(EmployeeSalaryStructure ess)
        {
            var result = await unitOfWork.employeeSalaryStructureRepo.AddEntity(ess);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(ess);
            }
            return BadRequest("Employee SalaryS tructure Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(EmployeeSalaryStructure ess)
        {
            var result = await unitOfWork.employeeSalaryStructureRepo.UpdateEntity(ess);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(ess);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.employeeSalaryStructureRepo.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Employee Salary Structure ID: {id} Not Exists");
            }
            await unitOfWork.employeeSalaryStructureRepo.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Employee Salary Structure {id} Deleted Successfully");
        }
    }
}
