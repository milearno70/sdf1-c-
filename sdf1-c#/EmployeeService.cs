using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdf1_c_
{
    public class EmployeeService : EmployeeServiceBase
    {
        public static List<Employee> Employees = new List<Employee>();

        public override bool AddEmployee(Employee employee)
        {
            if (employee == null) return false;

            if (FindEmployee(employee.Code) != null) return false;

            Employees.Add(employee);
            return true;
        }

        public override Employee FindEmployee(string code)
        {
            foreach (Employee emp in Employees)
            {
                if (emp.Code == code) return emp;
            }
            return null;   
        }

        public override bool AddPayment(
            string employeeCode, string title, double amount)
        {
            Employee emp = FindEmployee(employeeCode);

            if (emp == null || amount <= 0) return false;

            Payment payment = new Payment();
            payment.Title = title;
            payment.Amount = amount;
            emp.Payments.Add(payment);
            return true;
        }

        public override List<Payment> GetEmployeePayments(string employeeCode)
        {
            Employee emp = FindEmployee(employeeCode);
            if (emp == null) return null;  
            return emp.Payments;            
        }

        public override List<Employee> GetAllEmployees()
        {
            return Employees;
        }
    }

}
