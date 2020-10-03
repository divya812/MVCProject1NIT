using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1NIT.Models;
namespace MVCProject1NIT.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();
            List<DepartmentModel> deptList = new List<DepartmentModel>();

            EmployeeModel empObj = new EmployeeModel();
            empObj.EmpId = 123;
            empObj.EmpName = "Rachana";
            empObj.EmpSalary = 45000;

            EmployeeModel empObj1 = new EmployeeModel();
            empObj1.EmpId = 124;
            empObj1.EmpName = "Manish";
            empObj1.EmpSalary = 35000;

            EmployeeModel empObj2 = new EmployeeModel();
            empObj2.EmpId = 125;
            empObj2.EmpName = "Sirisha";
            empObj2.EmpSalary = 40000;

            empList.Add(empObj);
            empList.Add(empObj1);
            empList.Add(empObj2);

            DepartmentModel deptObj = new DepartmentModel();
            deptObj.DeptId = 1;
            deptObj.DeptName = "IT";

            DepartmentModel deptObj1 = new DepartmentModel();
            deptObj1.DeptId = 2;
            deptObj1.DeptName = "Sales";

            DepartmentModel deptObj2 = new DepartmentModel();
            deptObj2.DeptId = 1;
            deptObj2.DeptName = "Commerce";

            deptList.Add(deptObj);
            deptList.Add(deptObj1);
            deptList.Add(deptObj2);

            EmpDept empdeptObj = new EmpDept();
            empdeptObj.emp = empList;
            empdeptObj.dept = deptList;

            return View(empdeptObj);
        }

        public ActionResult GetObject(int? id, string value, string cssClass)
        {

            List<EmployeeModel> empList = new List<EmployeeModel>();

            EmployeeModel empObj = new EmployeeModel();
            empObj.EmpId = 123;
            empObj.EmpName = "Rachana";
            empObj.EmpSalary = 45000;

            EmployeeModel empObj1 = new EmployeeModel();
            empObj1.EmpId = 124;
            empObj1.EmpName = "Manish";
            empObj1.EmpSalary = 35000;

            EmployeeModel empObj2 = new EmployeeModel();
            empObj2.EmpId = 125;
            empObj2.EmpName = "Sirisha";
            empObj2.EmpSalary = 40000;

            empList.Add(empObj);
            empList.Add(empObj1);
            empList.Add(empObj2);

            EmpDept empdept = new EmpDept();
            empdept.empmodel = empObj;
            empdept.emp = empList;

            empdept.choice = id;
            empdept.textboxValue = value;
            empdept.cssClass = cssClass;

            Session["empList_Session"] = empList;
            Session["empObj_Session"] = empObj;

            return View(empdept);

            //if (Id == 1)
            //{
            //    return View(empdept);
            //}
            //else
            //{
            //    return View(empdept);
            //}

        }

        public ActionResult getPersonDetails(string empName)
        {
            EmpDept empdept1 = new EmpDept();
            empdept1.name = empName;
            empdept1.empmodel = (EmployeeModel) Session["empObj_Session"];
            empdept1.emp = (List<EmployeeModel>) Session["empList_Session"];

            return View(empdept1);
        }



    }


}