using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpId);
        Task<Employee> GetEmployeeDetails(int EmpId);
    }
}
