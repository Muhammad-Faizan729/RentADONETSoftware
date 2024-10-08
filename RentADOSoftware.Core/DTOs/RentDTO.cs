﻿using RentADOSoftware.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentADOSoftware.Core.DTOs
{
    public class RentDTO
    {
        public int RentId { get; set; }

        public DateTime RentDate { get; set; }

        public AgentDTO Agent { get; set; }

        public int AgentId { get; set; }
    }
}
