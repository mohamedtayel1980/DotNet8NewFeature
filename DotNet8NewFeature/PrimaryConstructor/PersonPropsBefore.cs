using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor
{
    public class PersonPropsBefore
    {
        public string  Name { get; }
        public int  Age { get; }
        

        public PersonPropsBefore(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
