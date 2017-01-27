using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Backlog
    {
        public int BacklogId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public float Duree { get; set; }
        [Display(Name = "Date de debut (Réel)")]
        public DateTime Start_Date_Real { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de debut (éstimé)")]
        public DateTime Start_Date_Estimated { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de Fin (Réel)")]
        public DateTime End_Date_Real { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de Fin (éstimé)")]
        public DateTime End_Date_Estimated { get; set; }
        public Features Feature { get; set; }
        public string Status { get; set; }
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
        public IEnumerable<Tasks> Tasks { get; set; }
    }
}
