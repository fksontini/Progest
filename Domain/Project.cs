using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public person Responsable { get; set; }
        public string Description { get; set; }
        public DateTime Start_Date_Real { get; set; }
        public DateTime Start_Date_Estimated { get; set; }
        public DateTime End_Date_Real { get; set; }
        public DateTime End_Date_Estimated { get; set; }
        public string Remarks { get; set; }
        public IEnumerable<Features> Feature { get; set; }
        public string Status { get; set; }
        public Team Team { get; set; }
    }
}
