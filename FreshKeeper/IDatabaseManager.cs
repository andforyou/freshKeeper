using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FreshKeeper
{
    public interface IDatabaseManager
    {
        object ExecuteScalar(string query, Action<MySqlCommand> parameterSetter);
        List<Dictionary<string, object>> ExecuteReader(string query, Action<MySqlCommand> parameterSetter);
        int ExecuteNonQuery(string query, Action<MySqlCommand> parameterSetter);
    }
}
