using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject1NIT.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class EmpDept {
        public List<DepartmentModel> dept { get; set; }
        public List<EmployeeModel> emp { get; set; }
        public EmployeeModel empmodel { get; set; }

        public int? choice { get; set; }
        public string textboxValue { get; set; }
        public string cssClass { get; set; }
        public string name { get; set; }
    }

}