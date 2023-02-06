using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryStructure
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeSalaryStructureDetailController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeSalaryStructureDetailController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ess = await unitOfWork.employeeSalaryStructureDetailRepo.GetAllAsync();

            return Ok(ess);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.employeeSalaryStructureDetailRepo.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Employee Salary Structure ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(EmployeeSalaryStructureDetails ess)
        {
            var result = await unitOfWork.employeeSalaryStructureDetailRepo.AddEntity(ess);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(ess);
            }
            return BadRequest("Employee Salary Structure detail Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(EmployeeSalaryStructureDetails ess)
        {
            var result = await unitOfWork.employeeSalaryStructureDetailRepo.UpdateEntity(ess);
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
            var data = await unitOfWork.employeeSalaryStructureDetailRepo.GetAsync(id);
            if (data == null)
            {
                return NotFound($"employee Salary Structure Detail ID: {id} Not Exists");
            }
            await unitOfWork.employeeSalaryStructureDetailRepo.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Employee Salary Structure  Detail{id} Deleted Successfully");
        }
    }
}
