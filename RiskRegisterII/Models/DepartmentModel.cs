﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RiskRegister.CustomEnum.Enum;

namespace RiskRegister.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public InstanceStatus Status { get; set; }
        public int CompanyId { get; set; }
    }
}
