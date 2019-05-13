using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CommonTest.CommonTest
{
    public class CommonQuery
    {
        public static string DBSelectAValue(string Query, int ResultQuery)
        {
            string Value;

            object Result;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                conn.Open();

                using (SqlCommand command = new SqlCommand(Query, conn))
                {
                    Result = command.ExecuteScalar();

                    switch (ResultQuery)
                    {
                        case 1:
                            Assert.AreNotEqual(null, Result);
                            Console.WriteLine("Requisito de base de datos correcto");
                            break;

                        case 0:
                            Assert.AreEqual(null, Result);
                            Console.WriteLine("Requisito de base de datos correcto");
                            break;
                    }
                }
            }

            Value = Convert.ToString(Result);

            return Value;
        }
    }
}