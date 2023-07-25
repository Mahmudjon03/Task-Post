using Domain.Models;
using Intrastructure.Services;

var empService = new EmployeeService();
var emp = new Employee();
 emp.FirstName = "Igor";
 emp.LastName = "Denis";
 emp.Salary = 200;
 emp.BirthData = new DateTime(2003, 11, 28);
 emp.Department = new Department();
 emp.Department.Name = "Maga";
 empService.AddEmployee(emp);
foreach (var item in empService.GetEmployees())
{
  System.Console.WriteLine($"{item.FirstName} <-> {item.LastName} <-> {item.BirthData} <->  {item.Salary}  <-> {item.Department.Name}");
}

