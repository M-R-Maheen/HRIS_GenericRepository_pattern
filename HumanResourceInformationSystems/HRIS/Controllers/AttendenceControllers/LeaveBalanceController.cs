using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.AttendenceInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.AttendenceControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveBalanceController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public LeaveBalanceController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var leaveBalances = await unitOfWork.leaveBalanceRepositary.GetAllAsync();

            return Ok(leaveBalances);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.leaveBalanceRepositary.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!!Leave balance ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(LeaveBalance leaveBalance)
        {
            var result = await unitOfWork.leaveBalanceRepositary.AddEntity(leaveBalance);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveBalance);
            }
            return BadRequest("Leave Balance Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(LeaveBalance leaveBalance)
        {
            var result = await unitOfWork.leaveBalanceRepositary.UpdateEntity(leaveBalance);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(leaveBalance);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.leaveBalanceRepositary.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Leave balance ID: {id} Not Exists");
            }
            await unitOfWork.leaveBalanceRepositary.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"leave balance {id} Deleted Successfully");
        }

    }
}
