using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryDetailsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public SalaryDetailsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var salaryDetail = await unitOfWork.salaryDetailRepository.GetAllAsync();

            return Ok(salaryDetail);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.salaryDetailRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! salary Details ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var data = await unitOfWork.salaryDetailRepository.GetAsync(name);

            if (data == null)
            {
                return NotFound($"Sorry!!! Salary Details : {name} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(SalaryDetail salaryDetail)
        {
            var result = await unitOfWork.salaryDetailRepository.AddEntity(salaryDetail);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(salaryDetail);
            }
            return BadRequest("salary Details Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(SalaryDetail salaryDetail)
        {
            var result = await unitOfWork.salaryDetailRepository.UpdateEntity(salaryDetail);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(salaryDetail);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.salaryDetailRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Salary Details ID: {id} Not Exists");
            }
            await unitOfWork.salaryDetailRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"salary Detail {id} Deleted Successfully");
        }
    }
}
