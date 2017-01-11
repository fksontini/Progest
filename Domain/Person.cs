using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        [Key]
        public string CodeId { get; set; }
        public string UserName { get; set; }
        public string Nom { get; set; }
        public string pwd { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance  { get; set; }
        public string Email { get; set; }
    }
}
