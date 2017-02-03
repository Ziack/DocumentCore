using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DocumentManager.UI.Controls.Helpers
{
    public class Data
    {
        public static SqlConnection Current
        {
            get
            {
                var connectionString = String.Empty;
                var connectionStringName = System.Configuration.ConfigurationManager.AppSettings["CurrentDatabase"];
                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
                return new SqlConnection(connectionString);
            }
        }
    }

    public static class DynamicToStatic
    {
        public static DataTable ToStatic(IList<dynamic> expando)
        {
            var result = new DataTable();

            foreach (dynamic item in expando)
            {
                var properties = item as IDictionary<string, object>;
                var row = result.NewRow();

                foreach (var entry in properties)
                {
                    if (!result.Columns.Contains(entry.Key))
                        result.Columns.Add(entry.Key);
                    row[entry.Key] = entry.Value;
                }

                result.Rows.Add(row);
            }

            return result;
        }

        public static DataRow ToStaticRow(IList<dynamic> expando)
        {
            DataTable result = ToStatic(expando);
            if (result.Rows.Count > 0)
                return result.Rows[0];
            else
                return null;
        }
    }
}