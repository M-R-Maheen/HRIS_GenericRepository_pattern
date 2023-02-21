using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryStructure
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryComponentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public SalaryComponentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pay = await unitOfWork.salaryComponentRepo.GetAllAsync();

            return Ok(pay);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.salaryComponentRepo.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! salary Component Repo ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(SalaryComponent sc)
        {
            var result = await unitOfWork.salaryComponentRepo.AddEntity(sc);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(sc);
            }
            return BadRequest("salary Component Repo Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(SalaryComponent sc)
        {
            var result = await unitOfWork.salaryComponentRepo.UpdateEntity(sc);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(sc);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.salaryComponentRepo.GetAsync(id);
            if (data == null)
            {
                return NotFound($"salary Component ID: {id} Not Exists");
            }
            await unitOfWork.salaryComponentRepo.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"salary Component {id} Deleted Successfully");
        }
    }
}
