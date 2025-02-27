using Microsoft.Data.SqlClient;
using PhoneRepair.Exseptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
public class OrderRepository
{
    string _connectionString;
    public OrderRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void CreatOrder(PhoneOrder order)
    {
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"insert into PhoneOrder(
                PhoneManufacturer, PhoneModel, Breaking, OrderName, OrderPhoneNumber) 
                values(@PhoneManufacturer, @PhoneModel, @Breaking, @OrderName, @OrderPhoneNumber); select @@identity", connection);
            command.Parameters.Add(new SqlParameter("PhoneManufacturer", order.PhoneManufacturer));
            command.Parameters.Add(new SqlParameter("PhoneModel", order.PhoneModel));
            command.Parameters.Add(new SqlParameter("Breaking", order.Breaking));
            command.Parameters.Add(new SqlParameter("OrderName", order.OrderName));
            command.Parameters.Add(new SqlParameter("OrderPhoneNumber", order.OrderPhoneNumber));
            command.ExecuteNonQuery();
            //var id = (decimal)command.ExecuteScalar();
        }
        catch (Exception ex)
        {

            throw new OrderRepositoryException(order, ex);
        }
        finally
        {
            connection.Close();
        }
    }
    public void UpdateOrder(PhoneOrder order)
    {
        if (order.Breaking == null)
        {
            throw new OrderRepositoryException(order, new ArgumentNullException(nameof(order.Breaking), "Breaking cannot be null."));
        }

        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"UPDATE PhoneOrder SET Breaking = @Breaking WHERE Id = @Id", connection);
            command.Parameters.Add(new SqlParameter("Breaking", order.Breaking));
            command.Parameters.Add(new SqlParameter("Id", order.Id));
            command.ExecuteNonQuery();
        }
        catch(Exception ex) 
        {
           
            throw new OrderRepositoryException(order, ex);
        }
        finally
        {
            connection.Close();
        }
    }
    public PhoneOrder GetOrder(long id)
    {
        var orders = GetAllOrders(id);
        if (orders.Count < 1)
            throw new System.Exception("Order is not found");
        return orders[0];
    }
    public List<PhoneOrder> GetAllOrders(long? id=null)
    {
        var result = new List<PhoneOrder>();
        var connection = new SqlConnection(_connectionString);
        try
        {
            connection.Open();
            var command = new SqlCommand(@"
            SELECT 
                po.Id, 
                po.PhoneManufacturer, 
                po.PhoneModel, 
                po.Breaking, 
                po.OrderName, 
                po.OrderPhoneNumber,
                op.IsCompleted
            FROM 
                PhoneOrder po
            LEFT JOIN 
                OrderProcessing op 
            ON 
                po.Id = op.OrderId", connection);
            if (id != null) {
                command.CommandText += " where Id = @id";
                var param = new SqlParameter("id", id);
                command.Parameters.Add(param);
            }
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                PhoneOrder order = ReadOrder(reader); // Handle null for IsCompleted
                result.Add(order);
            }
        }
        catch (SqlException ex)
        {
            System.Diagnostics.Trace.WriteLine(ex.ToString());
            throw new System.Exception("Failed to retrieve orders");
        }
        finally
        {
            connection.Close();
        }
        return result;
    }

    private static PhoneOrder ReadOrder(SqlDataReader reader)
    {
        var order = new PhoneOrder();
        order.Id = (long)reader.GetInt64(0);
        order.PhoneManufacturer = (string)reader.GetString(1);
        order.PhoneModel = (string)reader.GetString(2);
        order.Breaking = (string)reader.GetString(3);
        order.OrderName = (string)reader.GetString(4);
        order.OrderPhoneNumber = (string)reader.GetString(5);
        order.IsCompleted = !reader.IsDBNull(6) && reader.GetBoolean(6);
        return order;
    }
}