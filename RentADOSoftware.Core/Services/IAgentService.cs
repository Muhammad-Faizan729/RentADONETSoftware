using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.Services
{
    public interface IAgentService
    {
        Task<IEnumerable<AgentDTO>> GetAllAgentAsync();

        Task<AgentDTO> GetAgentByIdAsync(int id);

        Task AddAgentAsync(AgentDTO agentDto);

        Task UpdateAgentAsync(AgentDTO agentDto);

        Task DeleteAgentAsync(int id);
    }
}
