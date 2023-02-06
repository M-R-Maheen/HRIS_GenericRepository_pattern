using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.Loan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.EmployeeTaxAndLoanInfoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanScheduleController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public LoanScheduleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var loanSchedule = await unitOfWork.loanScheduleRepository.GetAllAsync();

            return Ok(loanSchedule);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.loanScheduleRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Loan Schedule ID: {id} Not Exists");
            }

            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(LoanSchedule loanSchedule)
        {
            var result = await unitOfWork.loanScheduleRepository.AddEntity(loanSchedule);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanSchedule);
            }
            return BadRequest("Loan Schedule Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LoanSchedule loanSchedule)
        {
            var result = await unitOfWork.loanScheduleRepository.UpdateEntity(loanSchedule);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanSchedule);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.loanScheduleRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Loan Schedule ID: {id} Not Exists");
            }
            await unitOfWork.loanScheduleRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Loan Schedule {id} Deleted Successfully");
        }
    }
}
