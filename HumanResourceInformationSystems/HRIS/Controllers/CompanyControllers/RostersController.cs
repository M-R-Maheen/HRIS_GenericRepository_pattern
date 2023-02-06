using HRIS.Interfaces;
using HRISdatabaseModels.DatabaseModels.CompanyInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class RostersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public RostersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roster = await unitOfWork.rosterRepository.GetAllAsync();
            return Ok(roster);
        }




        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.rosterRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Roster ID: {id} Not Exists");
            }
            return Ok(data);
        }



        [HttpPost]
        public async Task<IActionResult> Create(Roster roster)
        {
            var result = await unitOfWork.rosterRepository.AddEntity(roster);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(roster);
            }
            return BadRequest("Roster Created Failed...");
        }



        [HttpPut]
        public async Task<IActionResult> Update(Roster roster)
        {
            var result = await unitOfWork.rosterRepository.UpdateEntity(roster);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(roster);
            }
            return NotFound("Id Not Found");

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.rosterRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Roster ID: {id} Not Exists");
            }
            await unitOfWork.rosterRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Roster {id} Deleted Successfully");
        }
    }
}
