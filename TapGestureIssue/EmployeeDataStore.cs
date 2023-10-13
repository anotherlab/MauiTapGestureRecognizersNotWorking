using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapGestureIssue;

public class EmployeeDataStore
{
    readonly List<Employee> employees;

    public EmployeeDataStore()
    {
        employees = GetEmployees();
    }

    public List<Employee> GetAll()
    {
        return employees;
    }

    private static List<Employee> GetEmployees()
    {
        List<Employee> list =
            [
                new Employee
                {
                    Name = "Jane Linsey",
                    JobTitle = "HR Manager",
                },
                new Employee
                {
                    Name = "Maria Ross",
                    JobTitle = "Dynamic Assurance Associate",
                },
                new Employee
                {
                    Name = "Esther Reeves",
                    JobTitle = "Future Team Assistant",
                },
                new Employee
                {
                    Name = "Liz Torres",
                    JobTitle = "Director of Deep Thinking",
                },
                new Employee
                {
                    Name = "Victor Conner",
                    JobTitle = "Senior Assurance Guru",
                },
                new Employee
                {
                    Name = "Rob Chaney",
                    JobTitle = "Legacy Program Administrator",
                },
                new Employee
                {
                    Name = "David Guo",
                    JobTitle = "Corporate Accounts Manager",
                },
                new Employee
                {
                    Name = "Robert Marcos",
                    JobTitle = "Customer Happiness Director",
                },
                new Employee
                {
                    Name = "Sabrina Gomez-Gardner",
                    JobTitle = "Chief Tactics Associate",
                },
                new Employee
                {
                    Name = "John Smyth",
                    JobTitle = "Director of Fun",
                },
            ];
        return list;

    }
}
