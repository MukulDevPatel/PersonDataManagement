using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operation
    {
        public void AllRecords(List<Person>persons) 
        {
            var data = persons.Where(x => x.Age < 60).ToList();
            foreach ( var result in data )
            {
                Console.WriteLine("Person:" + result.Name + " " + "Address:" + result.Address + " " + "SSN:" + result.SSN);
            }
        }
    }
}
