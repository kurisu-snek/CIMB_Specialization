using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _appDbContext;
        #endregion

        #region Constructor
        public EmployeeService(ApiDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        #endregion

        public async Task<string> GetEmployeebyId(int EmpId)
        {
            var name = await _appDbContext.Employees.Where(c => c.Id == EmpId).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpId)
        {
            var emp = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id == EmpId);
            return emp;
        }
    }
}
