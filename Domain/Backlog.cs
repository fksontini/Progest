using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Backlog
    {
        public int BacklogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Duree { get; set; }
        public DateTime Start_Date_Real { get; set; }
        public DateTime Start_Date_Estimated { get; set; }
        public DateTime End_Date_Real { get; set; }
        public DateTime End_Date_Estimated { get; set; }
        public Features Feature { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
    }
}
