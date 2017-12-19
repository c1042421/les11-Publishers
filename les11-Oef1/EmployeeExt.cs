using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les11_Oef1
{
    partial class Employee
    {
        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   emp_id == employee.emp_id;
        }
    }
}
