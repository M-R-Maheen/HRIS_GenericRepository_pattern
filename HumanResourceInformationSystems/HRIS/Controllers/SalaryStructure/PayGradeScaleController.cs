using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryStructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryStructure
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayGradeScaleController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PayGradeScaleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pay = await unitOfWork.payGradeScaleRepo.GetAllAsync();

            return Ok(pay);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.payGradeScaleRepo.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Pay Grade Scale ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(PayGradeScale pay)
        {
            var result = await unitOfWork.payGradeScaleRepo.AddEntity(pay);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(pay);
            }
            return BadRequest("Pay Grade Scale Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(PayGradeScale pay)
        {
            var result = await unitOfWork.payGradeScaleRepo.UpdateEntity(pay);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(pay);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.payGradeScaleRepo.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Pay Grade Scale ID: {id} Not Exists");
            }
            await unitOfWork.payGradeScaleRepo.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Pay Grade Scale {id} Deleted Successfully");
        }
    }
}
