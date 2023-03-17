using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeePay
{
    public class EmployeeRepository
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
    public static SqlConnection sqlConnection = null;
    public static void GetAllEmployees()
    {
        try
        {
            EmployeePayRoll model = new EmployeePayRoll();
            sqlConnection = new SqlConnection(connectionString);
            string query = "select * from employeep";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Connections is established successfully.....");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sqlConnection.Close();
        }
    }
    }
}
