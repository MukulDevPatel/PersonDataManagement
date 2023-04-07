using PersonDataManagement;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { SSN = 1, Name = "a", Address = "x", Age = 11 });
            list.Add(new Person() { SSN = 2, Name = "b", Address = "x", Age = 19 });
            list.Add(new Person() { SSN = 3, Name = "c", Address = "x", Age = 13 });
            list.Add(new Person() { SSN = 4, Name = "d", Address = "x", Age = 15 });
            list.Add(new Person() { SSN = 5, Name = "e", Address = "x", Age = 17 });
            list.Add(new Person() { SSN = 6, Name = "f", Address = "x", Age = 15 });
            list.Add(new Person() { SSN = 7, Name = "g", Address = "x", Age = 15 });
            list.Add(new Person() { SSN = 8, Name = "h", Address = "x", Age = 13 });
            list.Add(new Person() { SSN = 9, Name = "i", Address = "x", Age = 17 });
            list.Add(new Person() { SSN = 10, Name = "j", Address = "x", Age = 15 });
            Operation operation = new Operation();
            operation.AllRecords(list);
        }
    }
}
