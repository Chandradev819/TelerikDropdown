using System;
using System.Threading.Tasks;
using TelerikDropdown.Data;

public class EmployeeService
{
    private Emp employee = new Emp(); // Replace Emp with your actual Employee model

    public Emp GetEmployee()
    {
        return employee;
    }

    public void UpdateEmployee(Emp updatedEmployee)
    {
        employee = updatedEmployee;
    }

    public async Task SaveEmployee()
    {
        // Implement the logic to save the employee data to the database or in-memory storage
        // For example:
        // await DbService.SaveEmployee(employee);
        Console.WriteLine(employee);
    }
}
