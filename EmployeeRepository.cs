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
            //Console.WriteLine("Connections is established successfully.....");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    model.Id = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                    model.Name = reader["Name"] == DBNull.Value ? default : reader["Name"].ToString();
                    model.BasicPay = Convert.ToInt64(reader["BasicPay"] == DBNull.Value ? default : reader["BasicPay"]);
                    model.StartDate = (DateTime)(reader["StartDate"] == DBNull.Value ? default(DateTime) : reader["StartDate"]);

                    model.Gender = reader["Gender"] == DBNull.Value ? default : reader["Gender"].ToString();
                    model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"] == DBNull.Value ? default : reader["PhoneNumber"]);
                    model.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                    model.Department = reader["Department"] == DBNull.Value ? default : reader["Department"].ToString();
                    model.Deductions = Convert.ToInt64(reader["Deductions"] == DBNull.Value ? default : reader["Deductions"]);
                    model.TaxablePay = Convert.ToInt64(reader["TaxablePay"] == DBNull.Value ? default : reader["TaxablePay"]);
                    model.IncomeTax = Convert.ToInt64(reader["IncomeTax"] == DBNull.Value ? default : reader["IncomeTax"]);
                    model.NetPay = Convert.ToInt64(reader["Net_Pay"] == DBNull.Value ? default : reader["NetPay"]);
                    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}", model.Id, model.Name, model.BasicPay, model.StartDate, model.Gender, model.PhoneNumber, model.Address, model.Department, model.Deductions, model.TaxablePay, model.IncomeTax, model.NetPay);
                     }
                 }

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
