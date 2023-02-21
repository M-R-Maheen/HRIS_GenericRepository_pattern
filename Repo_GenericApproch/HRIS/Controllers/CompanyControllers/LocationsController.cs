using HRIS.DatabaseModels.CompanyInformation;
using HRIS.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.Controllers.CompanyControllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public LocationsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var locations = await unitOfWork.locationRepository.GetAllAsync();

            return Ok(locations);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.locationRepository.GetAsync(id);

            if (data == null)
            {
                return NotFound($"Sorry!!! Location ID: {id} Not Exists");
            }

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            var result = await unitOfWork.locationRepository.AddEntity(location);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(location);
            }
            return BadRequest("Location Created Failed...");
        }


        [HttpPut]
        public async Task<IActionResult> Update(Location location)
        {
            var result = await unitOfWork.locationRepository.UpdateEntity(location);
            if (result)
            {
                await unitOfWork.CompleteAsync();
                return Ok(location);
            }
            return NotFound("Id Not Found");

        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var data = await unitOfWork.locationRepository.GetAsync(id);
            if (data == null)
            {
                return NotFound($"Location ID: {id} Not Exists");
            }
            await unitOfWork.locationRepository.DeleteEntity(id);
            await unitOfWork.CompleteAsync();
            return Ok($"Location {id} Deleted Successfully");
        }
    }
}
