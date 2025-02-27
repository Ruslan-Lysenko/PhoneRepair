using System.Collections.Generic;
using System.Dynamic;

public class PhoneOrder
{
    public long Id { get; set; }
    public string PhoneManufacturer { get; set; }
    public string PhoneModel { get; set; }
    public string Breaking { get; set; }
    public string OrderName { get; set; }
    public string OrderPhoneNumber { get; set; }
    public bool IsCompleted { get; set; }

    public List<OrderProcessing> OrderProcessings { get; set; }
}