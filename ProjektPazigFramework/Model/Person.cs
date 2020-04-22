using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPazigFramework.Model
{
    class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string Name { get; set; }
        public int NrIndexInGroup { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
