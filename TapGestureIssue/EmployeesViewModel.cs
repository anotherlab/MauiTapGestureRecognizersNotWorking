using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TapGestureIssue;

public class EmployeesViewModel : BaseViewModel
{
    public ObservableCollection<Employee> Employees { get; private set; } = [];

    public ICommand DeleteCommand => new Command<Employee>(RemoveEmployee);

    void RemoveEmployee(Employee employee)
    {
        Employees.Remove(employee);
    }


    public ICommand RefreshCommand => new Command(async () => await RefreshItemsAsync());

    async Task RefreshItemsAsync()
    {
        IsRefreshing = true;
        Employees.Clear();
        await Task.Delay(TimeSpan.FromSeconds(2));
        AddEmployees();
        IsRefreshing = false;
    }

    public static Command<Employee> EmployeeTapped => new(async (employee) =>
    {
        if (employee == null)
            return;

        await Shell.Current.GoToAsync($"employee?id={employee.Id}");
    });

    public EmployeesViewModel()
    {
        AddEmployees();
    }

    void AddEmployees()
    {
        var DataStore = (Application.Current as App).EmployeeDataStore;

        foreach (var employee in DataStore.GetAll())
        {
            Employees.Add(employee);
        }
    }


}
