using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operation
    {
        public void RetreiveTopRecordOfAge(List<Person>persons) 
        {
            var data = persons.Where(x => x.Age < 60).ToList().Take(2);
            foreach ( var result in data )
            {
                Console.WriteLine("Person:" + result.Name + " " + "Address:" + result.Address + " " + "SSN:" + result.SSN);
            }
        }
        public void RetreiveAllRecordOfAge(List<Person> persons)
        {
            var data = persons.Where(x => x.Age > 13 && x.Age < 18).ToList();
            foreach (var result in data)
            {
                Console.WriteLine("Person:" + result.Name + " " + "Address:" + result.Address + " " + "SSN:" + result.SSN);
            }
        }
        public void AverageAge(List<Person> persons)
        {
            var data = persons.Average(x => x.Age);
            Console.WriteLine(data);
        }
    }
}
