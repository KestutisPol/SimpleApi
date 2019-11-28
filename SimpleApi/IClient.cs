using CluedInAssignment.WsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CluedInAssignment
{
    interface IClient
    {
        /// <summary>
        /// Get company details    
        /// </summary>
        /// <returns>List of Companies with details</returns>
        List<CompanyDetails> GetAllCompanies();


        /// <summary>
        /// Get Customers asociated to a company
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of Customer with details</returns>
        List<Customers> GetCustomers(int id);

        /// <summary>
        ///  Get Employees asociated to a company
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of Employees with details</returns>
        List<Employees> GetEmployees(int id);
    }
}
