using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.AttendenceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceMonthEndController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public AttendenceMonthEndController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var attendenceMonthEnd = await unitOfWork.attendenceMonthEndRepositary.GetAllAsync();

            return Ok(attendenceMonthEnd);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.attendenceMonthEndRepositary.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!!Attendence month end ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(AttendenceMonthEnd attendenceMonthEnd)
        {
            var result = await unitOfWork.attendenceMonthEndRepositary.AddEntity(attendenceMonthEnd);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(attendenceMonthEnd);
            }
            return BadRequest("Monthy attendence Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(AttendenceMonthEnd attendenceMonthEnd)
        {
            var result = await unitOfWork.attendenceMonthEndRepositary.UpdateEntity(attendenceMonthEnd);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(attendenceMonthEnd);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.attendenceMonthEndRepositary.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Attendence month end ID: {id} Not Exists");
            }
            await unitOfWork.attendenceMonthEndRepositary.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Attendence month end {id} Deleted Successfully");
        }

    }
}

