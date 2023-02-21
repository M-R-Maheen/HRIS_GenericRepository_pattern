using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation;
using HRISdatabaseModels.DatabaseModels.Loan;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.EmployeeTaxAndLoanInfoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanInfoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public LoanInfoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var loanInfo = await unitOfWork.loanInformationRepository.GetAllAsync();

            return Ok(loanInfo);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.loanInformationRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Loan Info ID: {id} Not Exists");
            }

            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(LoanInformation loanInfo)
        {
            var result = await unitOfWork.loanInformationRepository.AddEntity(loanInfo);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanInfo);
            }
            return BadRequest("Loan Info Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LoanInformation loanInfo)
        {
            var result = await unitOfWork.loanInformationRepository.UpdateEntity(loanInfo);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(loanInfo);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.loanInformationRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Loan Info ID: {id} Not Exists");
            }
            await unitOfWork.loanInformationRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Loan Info {id} Deleted Successfully");
        }
    }
}
