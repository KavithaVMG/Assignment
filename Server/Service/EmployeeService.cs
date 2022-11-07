using Common;
using DAL;

namespace Service
{
    public class EmployeeService
    {
        public EmployeeDTO SaveEmployee(EmployeeDTO employee)
        {
            return new EmployeeDAL().SaveEmployee(employee);
        }

    }
}