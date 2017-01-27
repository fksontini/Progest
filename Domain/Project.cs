using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [Display(Name= "Date de debut (Réel)")]
        public DateTime Start_Date_Real { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de debut (Estimé)")]
        public DateTime Start_Date_Estimated { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de Fin (Réel)")]
        public DateTime End_Date_Real { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date de Fin (Estimé)")]
        public DateTime End_Date_Estimated { get; set; }
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
        public IEnumerable<Features> Feature { get; set; }
        public string Status { get; set; }
        public Team Team { get; set; }
    }
}
