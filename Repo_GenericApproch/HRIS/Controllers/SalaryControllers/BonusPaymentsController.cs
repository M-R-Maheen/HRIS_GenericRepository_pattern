using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.SalaryInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.SalaryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonusPaymentsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public BonusPaymentsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bonusPayment = await unitOfWork.bonusPaymentRepository.GetAllAsync();

            return Ok(bonusPayment);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.bonusPaymentRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Bonus Payment ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var data = await unitOfWork.bonusPaymentRepository.GetAsync(name);

            if (data == null)
            {
                return NotFound($"Sorry!!! Salary Details : {name} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(BonusPayment bonusPayment)
        {
            var result = await unitOfWork.bonusPaymentRepository.AddEntity(bonusPayment);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(bonusPayment);
            }
            return BadRequest("salary Details Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(BonusPayment bonusPayment)
        {
            var result = await unitOfWork.bonusPaymentRepository.UpdateEntity(bonusPayment);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(bonusPayment);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.bonusPaymentRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Bonus Payment ID: {id} Not Exists");
            }
            await unitOfWork.bonusPaymentRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Bonus Payment {id} Deleted Successfully");
        }
    }
}
