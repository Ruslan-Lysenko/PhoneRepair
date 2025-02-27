using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
public class EmployeeRepository
{
    string _connectionString;
    public EmployeeRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void CreateEmployee(Employee employee)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"insert into Employee(EmployeeName) 
                values(@EmployeeName)", connection);
            command.Parameters.Add(new SqlParameter("EmployeeName", employee.EmployeeName));

            command.ExecuteNonQuery(); 
        }
        finally
        {
            connection.Close(); 
        }

        
    }
    public void DeleteEmployee(Employee employee) 
    { 
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"delete from Employee
                                            where EmployeeId = @EmployeeId", connection);
            command.Parameters.Add(new SqlParameter("EmployeeId", employee.EmployeeId));
            command.ExecuteNonQuery();
            
        }
        finally
        {
            connection.Close();
        }

    }
    public void UpdateEmployy(Employee employee)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"UPDATE Employees SET EmployeeName = @EmployeeName WHERE EmployeeId = @EmployeeId", connection);
            command.Parameters.Add(new SqlParameter("@EmployeeName", employee.EmployeeName));
            command.Parameters.Add(new SqlParameter("@EmployeeId", employee.EmployeeId));
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


public Employee GetEmployeeById(long employeeId)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"SELECT EmployeeId, EmployeeName 
                                       FROM Employees
                                       WHERE EmployeeId = @EmployeeId", connection);
            command.Parameters.Add(new SqlParameter("EmployeeId", employeeId));

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Employee
                {
                    EmployeeId = (long)reader["EmployeeId"],
                    EmployeeName = reader["EmployeeName"].ToString()
                };
            }
            else
            {
                return null; 
            }
        }
        finally
        {
            connection.Close();
        }
    }

}

