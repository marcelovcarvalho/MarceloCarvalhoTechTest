using System;
using System.Linq;
using System.Collections.Generic;

namespace IntuitionTest.Question1
{
    public class EmployeeManager : IEmployeeManager
    {
        private SortedDictionary<int, Employee> employees { get; set; }
        public EmployeeManager()
        {
            employees = new SortedDictionary<int, Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null) return;

            employees.Add(employee.EmployeeID, employee);
        }

        public Employee GetEmployee(int employeeID)
        {
            return employees[employeeID];
        }

        public Employee[] GetOrderedEmployeeArray()
        {
            return employees.Select(e => e.Value).ToArray();
        }
    }
}
