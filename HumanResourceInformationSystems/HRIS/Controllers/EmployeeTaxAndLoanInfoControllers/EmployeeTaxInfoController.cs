using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.EmployeeTaxInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.EmployeeTaxAndLoanInfoControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTaxInfoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeTaxInfoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employeeTaxInfo = await unitOfWork.employeeTaxInfoRepository.GetAllAsync();

            return Ok(employeeTaxInfo);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.employeeTaxInfoRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Employee Tax Info ID: {id} Not Exists");
            }

            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(EmployeeTaxInfo employeeTaxInfo)
        {
            var result = await unitOfWork.employeeTaxInfoRepository.AddEntity(employeeTaxInfo);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(employeeTaxInfo);
            }
            return BadRequest("Employee Tax Info Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(EmployeeTaxInfo employeeTaxInfo)
        {
            var result = await unitOfWork.employeeTaxInfoRepository.UpdateEntity(employeeTaxInfo);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(employeeTaxInfo);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.employeeTaxInfoRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Employee Tax Info ID: {id} Not Exists");
            }
            await unitOfWork.employeeTaxInfoRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Employee Tax Info {id} Deleted Successfully");
        }
    }
}
