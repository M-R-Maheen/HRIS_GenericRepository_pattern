using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.AttendenceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyAttendencesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public DailyAttendencesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dailyAttendence = await unitOfWork.dailyAttendenceRepositary.GetAllAsync();

            return Ok(dailyAttendence);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.dailyAttendenceRepositary.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Daily Attendence ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(DailyAttendence dailyAttendence)
        {
            var result = await unitOfWork.dailyAttendenceRepositary.AddEntity(dailyAttendence);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(dailyAttendence);
            }
            return BadRequest("Attendence Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(DailyAttendence dailyAttendence)
        {
            var result = await unitOfWork.dailyAttendenceRepositary.UpdateEntity(dailyAttendence);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(dailyAttendence);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.dailyAttendenceRepositary.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Attendence ID: {id} Not Exists");
            }
            await unitOfWork.dailyAttendenceRepositary.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Attendence {id} Deleted Successfully");
        }
    }
}
