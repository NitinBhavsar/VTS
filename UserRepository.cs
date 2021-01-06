using Microsoft.EntityFrameworkCore;
using VTSAPI.DBContexts;
using VTSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VTSAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly VITSContext _dbContext;

        public UserRepository(VITSContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteUser(int vehicleId)
        {
            var vehicle = _dbContext.Users.Find(vehicleId);
            _dbContext.Users.Remove(vehicle);
            Save();
        }

        public User GetUserByID(int vehicleId)
        {
            return _dbContext.Users.Find(vehicleId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void InsertUser(User vehicle)
        {
            _dbContext.Add(vehicle);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User vehicle)
        {
            _dbContext.Entry(vehicle).State = EntityState.Modified;
            Save();
        }
    }
}