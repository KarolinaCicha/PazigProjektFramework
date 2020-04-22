using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjektPazigFramework.Model;

namespace ProjektPazigFramework.Services
{
    class ApplicationDbInitializer: DropCreateDatabaseAlways<ApplicationDb>
    {
        protected override void Seed(ApplicationDb context)
        {
            IList<Person> defaultStandards = new List<Person>();
            Group g = new Group() { GroupName = "Pierwsza" };
            defaultStandards.Add(new Person() { Name = "Kasia", Group=g});


            context.Groups.Add(g);
            context.People.AddRange(defaultStandards);

            base.Seed(context);
        }
    }
}
