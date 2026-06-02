using CompanyDbApp.Models;

var db = new CompanyDbContext();

var employees = db.Employees.ToList();

foreach (var emp in employees)
{
    Console.WriteLine(emp.Id);
    Console.WriteLine(emp.Name);
    Console.WriteLine(emp.Salary);
    Console.WriteLine("------------");
}