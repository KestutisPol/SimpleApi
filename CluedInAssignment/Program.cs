using CluedInAssignment.WsEntities;
using System;
using System.Collections.Generic;

namespace CluedInAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            IClient ws = new WsClient("https://cluedintestapi.herokuapp.com/api/");

            List<CompanyDetails> companiesDetails = ws.GetAllCompanies();

            foreach (CompanyDetails companyDetails in companiesDetails)
            {
                List<Customers> customers = ws.GetCustomers(companyDetails.id);
                List<Employees> employees = ws.GetEmployees(companyDetails.id);

                Company cmp = Mapper.MapCompany(companyDetails, customers, employees);


                Console.WriteLine("{0}", "Company Details");
                Console.WriteLine();
                Console.WriteLine("Name {0,-30} Email {1,5:N1} Phone {2,5:N1}", cmp.details.name, cmp.details.email, cmp.details.phoneNumber);
                Console.WriteLine();

                Console.WriteLine("{0}", "Company Employees");
                foreach (var employee in cmp.employees)
                {
                    Console.WriteLine("Name {0,0} {1,0:N1} Email {2,10:N1} Title {3,10:N1}", employee.firstName, employee.lastName, employee.email, employee.title);
                }

                Console.WriteLine();

                Console.WriteLine("{0}", "Company Customers");
                foreach (var customer in cmp.customers)
                {
                    Console.WriteLine("Name {0,0} Value {1,0:N1}", customer.customerName, customer.customerValue);
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
            }

        }

        #region Private Helpers

        #endregion

    }
}
