using System;
using System.Data.SqlClient;

namespace SqlDB
{
    public static class DB
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DLNKEHH\SQLEXPRESS;" +
            "Initial Catalog=LibraryDB;Integrated Security=True");

        public static (int, string, string, string, string, int, int)
            Search(string commandExpr, string firstParam, string firstParamExpr, 
            int secondParam, string secondParamExpr)
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

                (int, string, string, string, string, int, int) result = (0, null, null, null, null, 0, 0);

                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        result.Item1 = DBreader.GetInt32(0);
                        result.Item2 = DBreader.GetString(1);
                        result.Item3 = DBreader.GetString(2);
                        result.Item4 = DBreader.GetString(3);
                        result.Item5 = DBreader.GetString(4);
                        result.Item6 = DBreader.GetInt32(5);
                        result.Item7 = DBreader.GetInt32(6);
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

        public static (int, string, int, int, float, float, int)
            SearchBook(string commandExpr, string firstParam, string firstParamExpr,
            int secondParam, string secondParamExpr)
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

                (int, string, int, int, float, float, int) result = (0, null, 0, 0, 0, 0, 0);

                if (DBreader.HasRows)
                {
                    while (DBreader.Read())
                    {
                        result.Item1 = DBreader.GetInt32(0);
                        result.Item2 = DBreader.GetString(1);
                        result.Item3 = DBreader.GetInt32(2);
                        result.Item4 = DBreader.GetInt32(3);
                        result.Item5 = (float)DBreader.GetDouble(4);
                        result.Item6 = (float)DBreader.GetDouble(5);
                        result.Item7 = DBreader.GetInt32(6);
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

        public static int SearchForID(string commandExpr, string firstParam, string firstParamExpr,
            string secondParam, string secondParamExpr)
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
        public static bool AddEntity(string commandExpr,
            (string, string, string, string, int, int) entity, string[] paramName)
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
        public static bool AddEntity(string commandExpr, (int, int, string, DateTime) entity, string[] paramName)
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
        public static bool AddEntity(string commandExpr, (int, int, DateTime, DateTime) entity, string[] paramName)
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
        public static bool DelEntity(string commandExpr, (string, int) entity, string[] paramName)
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

        public static bool ChangeAmount(string commandExpr, (int, int) parametrs, string[] paramName)
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
