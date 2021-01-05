using System.Collections.Generic;
using VTSAPI.Models;

namespace VTSAPI.Repository
{
    public interface IVehicleRepository
    {
         void DeleteVehicle(int vehicleId);
         Vehicle GetVehicleByID(int vehicleId);
         IEnumerable<Vehicle> GetVehicles();
         void InsertVehicle(Vehicle vehicle);
         void Save();
         void UpdateVehicle(Vehicle vehicle);

    }
}