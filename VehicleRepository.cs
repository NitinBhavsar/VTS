using Microsoft.EntityFrameworkCore;
using VTSAPI.DBContexts;
using VTSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VTSAPI.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VITSContext _dbContext;

        public VehicleRepository(VITSContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteVehicle(int vehicleId)
        {
            var vehicle = _dbContext.Vehicles.Find(vehicleId);
            _dbContext.Vehicles.Remove(vehicle);
            Save();
        }

        public Vehicle GetVehicleByID(int vehicleId)
        {
            return _dbContext.Vehicles.Find(vehicleId);
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            return _dbContext.Vehicles.ToList();
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            _dbContext.Add(vehicle);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _dbContext.Entry(vehicle).State = EntityState.Modified;
            Save();
        }
    }
}