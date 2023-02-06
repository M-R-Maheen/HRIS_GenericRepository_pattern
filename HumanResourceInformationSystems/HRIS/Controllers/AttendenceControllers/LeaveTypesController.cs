using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.AttendenceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public LeaveTypesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var leaveType = await unitOfWork.leaveTypeRepositary.GetAllAsync();

            return Ok(leaveType);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.leaveTypeRepositary.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!!Leave type ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(LeaveType leaveType)
        {
            var result = await unitOfWork.leaveTypeRepositary.AddEntity(leaveType);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveType);
            }
            return BadRequest("Type Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LeaveType leaveType)
        {
            var result = await unitOfWork.leaveTypeRepositary.UpdateEntity(leaveType);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveType);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.leaveTypeRepositary.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Leave type ID: {id} Not Exists");
            }
            await unitOfWork.leaveTypeRepositary.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"leave type {id} Deleted Successfully");
        }
    }
}
