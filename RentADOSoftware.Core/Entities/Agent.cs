using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.Entities
{
    public class Agent
    {
        public int AgentId { get; set; }

        public string Name { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
