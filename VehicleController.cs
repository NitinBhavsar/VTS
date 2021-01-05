using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using VTSAPI.Models;
using VTSAPI.Repository;
using System.Transactions;



namespace VTSAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class VehicleController : ControllerBase
        {

            private readonly IVehicleRepository _vehicleRepository;

            public VehicleController(IVehicleRepository vehicleRepository)
            {
            try
            {
                _vehicleRepository = vehicleRepository;
            }
            catch ( Exception ex)
            {
                string strMsg = ex.Message;
            }
               
            }

            [HttpGet]
            public IActionResult Get()
            {
                var vehicles = _vehicleRepository.GetVehicles();
                return new OkObjectResult(vehicles);
            }

            [HttpGet("{id}", Name = "Get")]
            public IActionResult Get(int id)
            {
                var vehicle = _vehicleRepository.GetVehicleByID(id);
                return new OkObjectResult(vehicle);
            }

            [HttpPost]
            public IActionResult Post([FromBody] Vehicle vehicle)
            {
                using (var scope = new TransactionScope())
                {
                    _vehicleRepository.InsertVehicle(vehicle);
                    scope.Complete();
                    return CreatedAtAction(nameof(Get), new { id = vehicle.VehicleID }, vehicle);
                }
            }

            [HttpPut]
            public IActionResult Put([FromBody] Vehicle vehicle)
            {
                if (vehicle != null)
                {
                    using (var scope = new TransactionScope())
                    {
                        _vehicleRepository.UpdateVehicle(vehicle);
                        scope.Complete();
                        return new OkResult();
                    }
                }
                return new NoContentResult();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _vehicleRepository.DeleteVehicle(id);
                return new OkResult();
            }
        }
    }
