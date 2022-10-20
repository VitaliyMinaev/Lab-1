// See https://aka.ms/new-console-template for more information
using EmployeeLibrary.DomainModels;

var employee = new Employee("Bezugliy Vitaliy Oleksandrovich", "Developer department 1", Position.Engineer);

foreach (string position in employee.GetPositionHistory())
{
    Console.WriteLine(position);
}