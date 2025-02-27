public class OrderProcessing
{
    public long OrderProcessingId { get; set; }
    public long OrderId { get; set; }
    public long EmployeeId { get; set; }
    public bool IsCompleted { get; set; }

    public PhoneOrder PhoneOrder { get; set; }
    public Employee Employee { get; set; }
}
