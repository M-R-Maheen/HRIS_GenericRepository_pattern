using HRIS.Interfaces;
using HRIS.Repositories;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.AttendenceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveApplyController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public LeaveApplyController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var leaveApply = await unitOfWork.leaveApplyRepositary.GetAllAsync();

            return Ok(leaveApply);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.leaveApplyRepositary.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!!Leave apply ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(LeaveApply leaveApply)
        {
            var result = await unitOfWork.leaveApplyRepositary.AddEntity(leaveApply);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveApply);
            }
            return BadRequest("Leave apply Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LeaveApply leaveApply)
        {
            var result = await unitOfWork.leaveApplyRepositary.UpdateEntity(leaveApply);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveApply);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.leaveApplyRepositary.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Leave apply ID: {id} Not Exists");
            }
            await unitOfWork.leaveApplyRepositary.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"leave apply {id} Deleted Successfully");
        }
    }
}
