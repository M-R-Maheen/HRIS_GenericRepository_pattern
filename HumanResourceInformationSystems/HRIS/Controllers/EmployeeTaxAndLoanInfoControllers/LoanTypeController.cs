using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.Loan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.EmployeeTaxAndLoanInfoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanTypeController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public LoanTypeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var loanType = await unitOfWork.loanTypeRepository.GetAllAsync();

            return Ok(loanType);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.loanTypeRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Loan Type ID: {id} Not Exists");
            }

            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(LoanType loanType)
        {
            var result = await unitOfWork.loanTypeRepository.AddEntity(loanType);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanType);
            }
            return BadRequest("Loan Type Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LoanType loanType)
        {
            var result = await unitOfWork.loanTypeRepository.UpdateEntity(loanType);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanType);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.loanTypeRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Loan Type ID: {id} Not Exists");
            }
            await unitOfWork.loanTypeRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Loan Type {id} Deleted Successfully");
        }
    }
}
