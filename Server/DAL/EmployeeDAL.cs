using Common;
using Newtonsoft.Json;

namespace DAL
{
    public class EmployeeDAL
    {
        public EmployeeDTO SaveEmployee(EmployeeDTO employee)
        {
            try
            {
                string docPath = Environment.CurrentDirectory;
                string path = Path.Combine(docPath, Constants.EmployeeFileName);
                List<EmployeeDTO> list = new List<EmployeeDTO>();
                if (File.Exists(path))
                {
                    var employeeRead = File.ReadAllText(path);

                    if (employeeRead != null)
                    {
                        list = JsonConvert.DeserializeObject<List<EmployeeDTO>>(employeeRead);

                    }
                }

                if (employee != null)
                    list.Add(employee);

                File.WriteAllText(path, JsonConvert.SerializeObject(list));
                return employee;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}