using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CluedInAssignment.WsEntities
{
    public class Employees
    {
        public int id { get; set; }
        public int companyId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string title { get; set; }

    }
}
