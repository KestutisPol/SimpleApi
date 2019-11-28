using CluedInAssignment.WsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CluedInAssignment
{
    public static class Mapper
    {
        /// <summary>
        /// Mapping unified Company object
        /// </summary>
        /// <param name="companyDetails"></param>
        /// <param name="customers"></param>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static Company MapCompany(
            CompanyDetails companyDetails,
            List<Customers> customers,
            List<Employees> employees
            )
        {

            Company retVal = new Company();

            retVal.customers = customers;
            retVal.details = companyDetails;
            retVal.employees = employees;

            return retVal;
        }

    }
}
