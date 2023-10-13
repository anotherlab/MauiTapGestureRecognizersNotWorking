using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapGestureIssue;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string JobTitle { get; set; }
    public string ImageUrl { get; set; }

    public Employee()
    {
        Id = Guid.NewGuid().ToString();
    }

}
