using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiger.Api.Models
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int employeeId);
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public void DeleteEmployee(int employeeId);
        IEnumerable<Employee> GetLongEmployeeList();
        IEnumerable<Employee> GetTakeLongEmployeeList(int request, int count);
    }
}
