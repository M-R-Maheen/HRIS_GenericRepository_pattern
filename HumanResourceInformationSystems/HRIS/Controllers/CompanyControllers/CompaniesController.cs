using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRIS.DatabaseModels.CompanyInformation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public CompaniesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var company = await unitOfWork.companyRepository.GetAllAsync();

            return Ok(company);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.companyRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Company ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var data = await unitOfWork.companyRepository.GetAsync(name);

            if (data == null)
            {
                return NotFound($"Sorry!!! Company Name: {name} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Company company)
        {
            var result = await unitOfWork.companyRepository.AddEntity(company);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(company);
            }
            return BadRequest("Company Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Company company)
        {
            var result = await unitOfWork.companyRepository.UpdateEntity(company);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(company);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.companyRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Company ID: {id} Not Exists");
            }
            await unitOfWork.companyRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Company {id} Deleted Successfully");
        }
    }
}
