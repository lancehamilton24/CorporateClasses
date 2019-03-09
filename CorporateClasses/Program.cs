using System;
using System.Collections.Generic;

namespace CorporateClasses

{
    class Employee
    {
        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startDate { get; set; }
    }

    class Company
    {
        public string companyName { get; }
        public string companyAddress { get; }

        //Employees are added to the company. 
        public List<Employee> employees { get; set; }

        static void Main(string[] args)
        {
            //Creating a company
            Company GreatCompany = new Company();

            //Creating an employee
            Employee lance = new Employee();
            lance.firstName = "Lance";
            lance.lastName = "Hamilton";
            lance.startDate = DateTime.Parse("12/23/43");

            //Adding employee to a list of employees
            List<Employee> GreatCompanyEmployees = new List<Employee>();
            GreatCompanyEmployees.Add(lance);

            //Adding another employee 
            GreatCompanyEmployees.Add(
                new Employee()
                {
                    firstName = "Pablo",
                    lastName = "Sanchez",
                    startDate = DateTime.Parse("2/3/32")
                }
                );
            GreatCompanyEmployees.Add(
               new Employee()
               {
                   firstName = "Spongebob",
                   lastName = "Squarepants",
                   startDate = DateTime.Parse("4/5/34")
               }
               );
            GreatCompanyEmployees.Add(
               new Employee()
               {
                   firstName = "Pete",
                   lastName = "Wheeler",
                   startDate = DateTime.Parse("9/6/23")
               }
               );

            // Setting Company employee property equal to created list
            GreatCompany.employees = GreatCompanyEmployees;

            //Iterating of list of all employees. 
            foreach (Employee employees in GreatCompanyEmployees)
            {
                Console.WriteLine(employees.firstName);
                Console.WriteLine(employees.lastName);
                Console.WriteLine(employees.startDate);
            }
            Console.ReadLine();
        }
    }
}