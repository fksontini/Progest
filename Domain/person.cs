using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class person
    {
        public int personId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Statut { get; set; }
       public IEnumerable<Team> Myteam { get; set; }
    }
}
