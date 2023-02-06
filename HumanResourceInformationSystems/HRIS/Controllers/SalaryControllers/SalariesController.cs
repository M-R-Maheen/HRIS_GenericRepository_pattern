using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalariesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public SalariesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var salary = await unitOfWork.salaryRepository.GetAllAsync();

            return Ok(salary);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.salaryRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Salary ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var data = await unitOfWork.salaryRepository.GetAsync(name);

            if (data == null)
            {
                return NotFound($"Sorry!!! Salary : {name} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Salary salary)
        {
            var result = await unitOfWork.salaryRepository.AddEntity(salary);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(salary);
            }
            return BadRequest("Salary Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Salary salary)
        {
            var result = await unitOfWork.salaryRepository.UpdateEntity(salary);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(salary);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.salaryRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Salary ID: {id} Not Exists");
            }
            await unitOfWork.salaryRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Salary {id} Deleted Successfully");
        }
    }
}
