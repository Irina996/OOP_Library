using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using SqlDB.Extensions;

namespace SqlDB
{
    public static class DB
    {
        private static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DLNKEHH\SQLEXPRESS;" +
            "Initial Catalog=LibraryDB;Integrated Security=True");

        
        // Search information in DB
        public static IEnumerable<T>
            Search<T, T1, T2>(string commandExpr, T1 firstParam, string firstParamExpr, 
            T2 secondParam, string secondParamExpr) where T : new()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter
                {
                    ParameterName = firstParamExpr,
                    Value = firstParam
                };
                SqlParameter Param2 = new SqlParameter
                {
                    ParameterName = secondParamExpr,
                    Value = secondParam
                };

                command.Parameters.Add(Param1);
                command.Parameters.Add(Param2);

                var entity = command.Read<T>();

                return entity;
            }
            finally
            {
                connection.Close();
            }
        }

        public static IEnumerable<T>
            Search<T, T1>(string commandExpr, T1 firstParam, string firstParamExpr) where T : new()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter
                {
                    ParameterName = firstParamExpr,
                    Value = firstParam
                };

                command.Parameters.Add(Param1);

                var entity = command.Read<T>();

                return entity;
            }
            finally
            {
                connection.Close();
            }
        }


        public static IEnumerable<T>
            Search<T, T1, T2, T3>(string commandExpr, T1 firstParam, string firstParamExpr, T2 secondParam, 
            string secondParamExpr, T3 thirdParam, string thirdParamExpr) where T : new()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter
                {
                    ParameterName = firstParamExpr,
                    Value = firstParam
                };
                SqlParameter Param2 = new SqlParameter
                {
                    ParameterName = secondParamExpr,
                    Value = secondParam
                };
                SqlParameter Param3 = new SqlParameter
                {
                    ParameterName = thirdParamExpr,
                    Value = thirdParam
                };

                command.Parameters.Add(Param1);
                command.Parameters.Add(Param2);
                command.Parameters.Add(Param3);

                var entity = command.Read<T>();

                return entity;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int SearchForID(string commandExpr)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var DBreader = command.ExecuteReader();

                int result = 0;

                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        result = (int)DBreader.GetDecimal(0);
                    }
                }
                DBreader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int SearchForID<T>(string commandExpr, T firstParam, string firstParamExpr,
            T secondParam, string secondParamExpr)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter
                {
                    ParameterName = firstParamExpr,
                    Value = firstParam
                };
                SqlParameter Param2 = new SqlParameter
                {
                    ParameterName = secondParamExpr,
                    Value = secondParam
                };

                command.Parameters.Add(Param1);
                command.Parameters.Add(Param2);

                var DBreader = command.ExecuteReader();

                int result = 0;

                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        result = DBreader.GetInt32(0);
                    }
                }
                DBreader.Close();
                return result;
            }
            finally
            {
                connection.Close();
            }
        }

        // Add line in DB
        public static bool AddEntity(string commandExpr,
            (string, string, string, string, int) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);
                SqlParameter Param3 = new SqlParameter(paramName[2], entity.Item3);
                command.Parameters.Add(Param3);
                SqlParameter Param4 = new SqlParameter(paramName[3], entity.Item4);
                command.Parameters.Add(Param4);
                SqlParameter Param5 = new SqlParameter(paramName[4], entity.Item5);
                command.Parameters.Add(Param5);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddEntity<T1, T2, T3, T4>(string commandExpr, (T1, T1, T3, T4) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);
                SqlParameter Param3 = new SqlParameter(paramName[2], entity.Item3);
                command.Parameters.Add(Param3);
                SqlParameter Param4 = new SqlParameter(paramName[3], entity.Item4);
                command.Parameters.Add(Param4);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddEntity<T1, T2, T3, T4, T5>(string commandExpr,
            (T1, T2, T3, T4, T5) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);
                SqlParameter Param3 = new SqlParameter(paramName[2], entity.Item3);
                command.Parameters.Add(Param3);
                SqlParameter Param4 = new SqlParameter(paramName[3], entity.Item4);
                command.Parameters.Add(Param4);
                SqlParameter Param5 = new SqlParameter(paramName[4], entity.Item5);
                command.Parameters.Add(Param5);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddEntity<T1, T2, T3, T4, T5, T6>(string commandExpr, 
            (T1, T2, T3, T4, T5, T6) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);
                SqlParameter Param3 = new SqlParameter(paramName[2], entity.Item3);
                command.Parameters.Add(Param3);
                SqlParameter Param4 = new SqlParameter(paramName[3], entity.Item4);
                command.Parameters.Add(Param4);
                SqlParameter Param5 = new SqlParameter(paramName[4], entity.Item5);
                command.Parameters.Add(Param5);
                SqlParameter Param6 = new SqlParameter(paramName[5], entity.Item6);
                command.Parameters.Add(Param6);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddEntity<T>(string commandExpr, (T, T) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        //  Delete line in DB
        public static bool DelEntity<T1, T2>(string commandExpr, (T1, T2) entity, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], entity.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], entity.Item2);
                command.Parameters.Add(Param2);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        // change cell value 
        public static bool ChangeAmount<T1, T2>(string commandExpr, (T1, T2) parametrs, string[] paramName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(commandExpr, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Param1 = new SqlParameter(paramName[0], parametrs.Item1);
                command.Parameters.Add(Param1);
                SqlParameter Param2 = new SqlParameter(paramName[1], parametrs.Item2);
                command.Parameters.Add(Param2);

                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
