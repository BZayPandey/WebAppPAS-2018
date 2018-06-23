using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Models
{
    public class BLLEmployee
    {
        GMSEntities2 gme = new GMSEntities2();
        public int CreateEmployee(EmployeeViewModel uv)
        {
            Employee em = new Employee();
            em.EmployeeID = uv.EmployeeID;
            em.Name = uv.Name;
            em.Position = uv.Position;
            em.Office = uv.Office;
            em.Salary = uv.Salary;

            gme.Employees.Add(em);
            int i = gme.SaveChanges();
            return i;
        }
        public List<EmployeeViewModel> GetAllEmployees()
        {
            List<EmployeeViewModel> lst = new List<EmployeeViewModel>();
            var employeelist = gme.Employees.ToList();
            foreach (Employee item in employeelist)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeID = item.EmployeeID;
                evm.Name = item.Name;
                evm.Position = item.Position;
                evm.Office = item.Office;
                evm.Salary = item.Salary;

                lst.Add(evm);
            }
            return lst;

        }
        public int UpdateEmployee(EmployeeViewModel ev)
        {
            Employee emp = gme.Employees.Where(u => u.EmployeeID == ev.EmployeeID).FirstOrDefault();
            emp.EmployeeID = ev.EmployeeID;
            emp.Name = ev.Name;
            emp.Position = ev.Position;
            emp.Office = ev.Office;
            emp.Salary = ev.Salary;
            return gme.SaveChanges();
        }

        public int DeleteUser(int id)
        {
            Employee em = gme.Employees.Where(u => u.EmployeeID == id).FirstOrDefault();
            gme.Employees.Remove(em);
            int i = gme.SaveChanges();
            return i;

        }
    }
}