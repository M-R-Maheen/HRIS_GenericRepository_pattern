using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public DivisionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var divisions = await unitOfWork.divisionRepository.GetAllAsync();

            return Ok(divisions);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.divisionRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Division ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Division division)
        {
            var result = await unitOfWork.divisionRepository.AddEntity(division);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(division);
            }
            return BadRequest("Division Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Division division)
        {
            var result = await unitOfWork.divisionRepository.UpdateEntity(division);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(division);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.divisionRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Company ID: {id} Not Exists");
            }
            await unitOfWork.divisionRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Division {id} Deleted Successfully");
        }
    }
}
