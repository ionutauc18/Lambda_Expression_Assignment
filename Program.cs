using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of 10 employess in the Main() Method
            // At least two employees should have their first name as Joe
            List<Employee> amazon = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Ionut", LastName = "Catana" },
                new Employee() { Id = 2, FirstName = "Joe", LastName = "Doe" },
                new Employee() { Id = 3, FirstName = "Adrianna", LastName = "Matuszak" },
                new Employee() { Id = 4, FirstName = "Amparo", LastName = "Torres" },
                new Employee() { Id = 5, FirstName = "Joe", LastName = "Willock" },
                new Employee() { Id = 6, FirstName = "Ali", LastName = "Minhal" },
                new Employee() { Id = 7, FirstName = "Anthony", LastName = "Cleckner" },
                new Employee() { Id = 8, FirstName = "Rogan", LastName = "Otterwell" },
                new Employee() { Id = 9, FirstName = "Joe", LastName = "Rogan" },
                new Employee() { Id = 10, FirstName = "Sinuvasulu", LastName = "Bumayahah" },
            };
            // Creating a list of all employess with the first name "Joe" using a foreach loop
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in amazon)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }


            // Creating a list of all employess with the first name "Joe" using a lambda expression
            List<Employee> joes2 = amazon.Where(x => x.FirstName == "Joe").ToList();
            // Creating a list of all employees with an Id number greater than 5 using a lambda expression
            List<Employee> bigId = amazon.Where(x => x.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
