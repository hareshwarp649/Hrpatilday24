using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24PerDataManagemLambdaEx
{
    public class PersonData
    {

        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public PersonData(string ssn, string name, string addr, int age)
        {
            this.SSN = ssn;
            this.Name = name;
            this.Address = addr;
            this.Age = age;

        }
    }
}
