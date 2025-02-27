using Microsoft.Data.SqlClient;
public class OrderProcessingRepository
{
    string _connectionString;
    public OrderProcessingRepository(string connectionString)
    {
        _connectionString = connectionString;
    }
    public void CreateOrderProcessing(OrderProcessing orderProcessing)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"INSERT INTO OrderProcessing (OrderId, EmployeeId, IsCompleted)
                                         VALUES(@OrderId, @EmployeeId, @IsCompleted)", connection);
            command.Parameters.Add(new SqlParameter("OrderId", orderProcessing.OrderId));
            command.Parameters.Add(new SqlParameter("EmployeeId", orderProcessing.EmployeeId));
            command.Parameters.Add(new SqlParameter("IsCompleted", orderProcessing.IsCompleted));
            command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            System.Diagnostics.Trace.WriteLine(ex.ToString());
            throw new System.Exception("OOPS");
        }
        finally
        {
            connection.Close();
        }
        try
        {
            connection.Close();
        }
        catch { }
    }
    public void UpdateOrderProcessingStatus(long orderProcessingId, bool isCompleted)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"UPDATE OrderProcessing SET IsCompleted = @IsCompleted WHERE OrderProcessingId = @OrderProcessingId", connection);
            command.Parameters.Add(new SqlParameter("@IsCompleted", isCompleted));
            command.Parameters.Add(new SqlParameter("@OrderProcessingId", orderProcessingId));
            command.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            System.Diagnostics.Trace.WriteLine(ex.ToString());
            throw new System.Exception("OOPS");
        }
        finally
        {
            connection.Close();
        }
        try
        {
            connection.Close();
        }
        catch { }
    }
}