using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tasks
    {
        public int TasksId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Duree { get; set; }
        public DateTime Start_Date_Real { get; set; }
        public DateTime Start_Date_Estimated { get; set; }
        public DateTime End_Date_Real { get; set; }
        public DateTime End_Date_Estimated { get; set; }
        public Project project { get; set; }
        public string Remarks { get; set; }
        public Backlog Backlog { get; set; }

        public string Status { get; set; }
    }
}
