using DesignPatterns.Application.Vehicles.GetVehicles;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Api.Controllers.Vehicles
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly ISender _sender;

        public VehicleController(
            ISender sender)
        {
            _sender = sender;
        }

        /// <summary>
        /// Gets all vehicles.
        /// </summary>
        /// <returns>
        /// All vehicles.
        /// </returns>
        [HttpGet]
        [ProducesResponseType(typeof(VehiclesResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVehicles()
        {
            var vehicles = await _sender.Send(new GetVehiclesQuery());

            var response = new VehiclesResponse(vehicles.Value);

            return Ok(response);
        }
    }
}
