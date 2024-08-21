using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using RentADOSoftware.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Service
{
    public class RentService : IRentRepository
    {
        public Task AddRentAsync(RentDTO rentDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RentDTO>> GetAllRentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RentDTO> GetRentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRentAsync(RentDTO rentDto)
        {
            throw new NotImplementedException();
        }
    }
}
