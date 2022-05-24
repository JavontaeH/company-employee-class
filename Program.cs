using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime createdon)
        {
            Name = name;
            CreatedOn = createdon;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {this.Name} as {employee.Title} since {employee.StartDate}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company theBar = new Company("Paddy's Pub", new DateTime(2002, 2, 28));

            // Create three employees
            Employee mac = new Employee("Ronald", "Macdonald", "Guns", new DateTime(2005, 08, 4));
            Employee dennis = new Employee("Dennis", "Reynolds", "Brains", new DateTime(2005, 08, 4));
            Employee charlie = new Employee("Charlie", "Kelly", "Wildcard", new DateTime(2005, 08, 4));

            // Assign the employees to the company
            theBar.Employees.Add(mac);
            theBar.Employees.Add(dennis);
            theBar.Employees.Add(charlie);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            theBar.ListEmployees();
        }
    }
}
