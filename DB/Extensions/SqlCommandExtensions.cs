using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SqlDB.Extensions
{
    public static class SqlCommandExtensions
    {
        public static IEnumerable<T> Read<T>(this SqlCommand command) where T : new()
        {
            var result = ReadInternal<T>(command);
            return result;
        }

        private static IEnumerable<T> ReadInternal<T>(this SqlCommand command) where T : new()
        {
            var reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                return Enumerable.Empty<T>();
            }

            var entities = reader.ParseFromReaderInternal<T>();

            reader.Close();

            return entities;
        }

        private static IEnumerable<T> ParseFromReaderInternal<T>(this SqlDataReader reader) where T : new()
        {
            try
            {

                var entityType = typeof(T);
                var entityProps = entityType.GetProperties();

                var entities = new List<T>();

                while (reader.Read())
                {
                    var entity = new T();

                    foreach (var entityPropInfo in entityProps)
                    {
                        var valueFromReader = reader[entityPropInfo.Name];

                        if (valueFromReader is DBNull)
                        {
                            valueFromReader = null;
                        }
                        entityPropInfo.SetValue(entity, valueFromReader);
                    }

                    entities.Add(entity);

                }

                return entities;
            }
            catch 
            {
                return Enumerable.Empty<T>();
            }

        }
    }
}
