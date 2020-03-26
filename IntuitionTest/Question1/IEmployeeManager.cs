using System;
namespace IntuitionTest.Question1
{
    public interface IEmployeeManager
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int employeeID);
        Employee[] GetOrderedEmployeeArray();
    }
}
