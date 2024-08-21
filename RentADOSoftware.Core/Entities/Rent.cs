using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.Entities
{
    public class Rent
    {
        public int RentId { get; set; }

        public DateTime RentDate { get; set; }

        public Agent Agent { get; set; }

        public int AgentId { get; set; }
    }
}
