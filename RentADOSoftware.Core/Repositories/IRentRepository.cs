using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.Repositories
{
    public interface IRentRepository
    {
        Task<IEnumerable<RentDTO>> GetAllRentAsync();

        Task<RentDTO> GetRentByIdAsync(int id);

        Task AddRentAsync(RentDTO rentDto);

        Task UpdateRentAsync(RentDTO rentDto);

        Task DeleteRentAsync(int id);
    }
}
