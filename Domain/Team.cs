﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Team
    {
        public int TeamId { get; set; }
        public person teamLeader { get; set; }
        public IEnumerable< Project> projet { get; set; }
    }
}
