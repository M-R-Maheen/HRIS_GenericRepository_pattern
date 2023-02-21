using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public DepartmentsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await unitOfWork.departmentRepository.GetAllAsync();

            return Ok(departments);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.departmentRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Department ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Department department)
        {
            var result = await unitOfWork.departmentRepository.AddEntity(department);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(department);
            }
            return BadRequest("Department Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(Department department)
        {
            var result = await unitOfWork.departmentRepository.UpdateEntity(department);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(department);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.departmentRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Department ID: {id} Not Exists");
            }
            await unitOfWork.departmentRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Department {id} Deleted Successfully");
        }
    }
}
