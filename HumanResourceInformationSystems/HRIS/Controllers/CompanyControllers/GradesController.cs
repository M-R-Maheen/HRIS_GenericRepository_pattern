using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public GradesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]      
        public async Task<IActionResult> GetAll()
        {
            var grade = await unitOfWork.gradeRepository.GetAllAsync();
            
               return Ok(grade);        
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.gradeRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Grade ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Grade grade)
        {
            var result = await unitOfWork.gradeRepository.AddEntity(grade);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(grade);
            }
            return BadRequest("Grade Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Grade grade)
        {
            var result = await unitOfWork.gradeRepository.UpdateEntity(grade);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(grade);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.gradeRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Grade ID: {id} Not Exists");
            }
            await unitOfWork.gradeRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Grade {id} Deleted Successfully");
        }
    }
}
