using RentADOSoftware.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.DTOs
{
    public class AgentDTO
    {
        public int AgentId { get; set; }

        public string Name { get; set; }

        public ICollection<RentDTO> Rents { get; set; } = new List<RentDTO>();
    }
}
