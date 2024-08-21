using RentADOSoftware.Core.DTOs;
using RentADOSoftware.Core.Entities;
using RentADOSoftware.Core.Repositories;
using RentADOSoftware.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Service
{
    public class AgentService : IAgentService
    {
        private readonly IAgentRepository _agentRepository;

        public AgentService(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        public async Task AddAgentAsync(AgentDTO agentDto)
        {
            await _agentRepository.AddAgentAsync(agentDto);
        }

        public async Task DeleteAgentAsync(int id)
        {
            await _agentRepository.DeleteAgentAsync(id);
        }

        public async Task<AgentDTO> GetAgentByIdAsync(int id)
        {
            return await _agentRepository.GetAgentByIdAsync(id);
        }

        public async Task<IEnumerable<AgentDTO>> GetAllAgentAsync()
        {
            return await _agentRepository.GetAllAgentAsync();
        }

        public Task UpdateAgentAsync(AgentDTO agentDto)
        {
            throw new NotImplementedException();
        }
    }
}
