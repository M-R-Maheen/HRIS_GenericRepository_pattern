using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class DesignationsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public DesignationsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var designation = await unitOfWork.designationRepository.GetAllAsync();

            return Ok(designation);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.designationRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Designation ID: {id} Not Exists");
            }

            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(Designation designation)
        {
            var result = await unitOfWork.designationRepository.AddEntity(designation);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(designation);
            }
            return BadRequest("Designation Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(Designation designation)
        {
            var result = await unitOfWork.designationRepository.UpdateEntity(designation);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(designation);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.designationRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Designation ID: {id} Not Exists");
            }
            await unitOfWork.designationRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Designation {id} Deleted Successfully");
        }
    }
}
