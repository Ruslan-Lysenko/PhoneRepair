using System.Collections.Generic;

public class Employee
{
    public long EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    public List<OrderProcessing> OrderProcessings { get; set; }

}
