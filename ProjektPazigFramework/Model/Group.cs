using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPazigFramework.Model
{
    public class Group
    {

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public override string ToString()
        {
            //if (PeopleInGroup != null)
            //{
            //    return $"{GroupId}  |   {GroupName}   | Członkowie: {PeopleInGroup.ToList().First().Name}";
            //}
            //else
            {
                return $"{GroupId}  |   {GroupName}";
            }
        }

        public virtual ICollection<Person> PeopleInGroup { get; set; }
    }
}
