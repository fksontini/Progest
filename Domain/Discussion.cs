using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Discussion
    {
        [Key]
        public int DiscID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
      
    }
}
