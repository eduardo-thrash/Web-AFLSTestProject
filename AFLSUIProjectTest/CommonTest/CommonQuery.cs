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
                            try
                            {
                                Assert.AreNotEqual(null, Result);
                            }
                            catch
                            {
                                Assert.Fail("Error en consulta: " + Query);
                            }
                            break;

                        case 0:
                            try
                            {
                                Assert.AreEqual(null, Result);
                            }
                            catch
                            {
                                Assert.Fail("Error en consulta: " + Query);
                            }

                            break;
                    }
                }
            }

            Value = Convert.ToString(Result);

            return Value;
        }
    }
}