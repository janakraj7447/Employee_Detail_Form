using System;
using System.Collections.Generic;

namespace Assignment.Entities;

public partial class Dept
{
    public int DeptId { get; set; }

    public string DeptName { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
