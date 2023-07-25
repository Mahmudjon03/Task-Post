using Domain.Models;
namespace Intrastructure.Services;


public class EmployeeService
{
        List<Employee>  _employees;
   
   
    
   
   public EmployeeService()
   {
    _employees=new List<Employee>();
   }
    public List<Employee> GetEmployees(){
        return _employees;
    }
    public void AddEmployee(Employee employee){
        _employees.Add(employee);
    }
    public int ContEmployee(){
  return _employees.Count;
    }

}
