using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Sql
{
    public class SqlGameDatabase : GameDatabase
    {
        public SqlGameDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        protected override Game AddCore( Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                //Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);

                // (int)cmd.ExecuteScalar();
                // cmd.ExecuteScalar() as int;  //reference types 
                var result = Convert.ToInt32(cmd.ExecuteScalar());

                game.Id = result;
                return game;
            };
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        protected override void DeleteCore( int id )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DeleteGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            var ds = new DataSet();

            using (var conn = GetConnection())
            {
                var cmd = new SqlCommand("GetGames", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                
                da.Fill(ds);

                //If you wanted to update
                //da.Update(ds);
            };

            //Disconnected from DB
            //ds.Tables[0].Rows[0][0] = "Old";
            //ds.Tables[0].Rows[0]["Name"] = "Old";
            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                return from r in table.Rows.OfType<DataRow>()
                       select new Game() {
                           Id = Convert.ToInt32(r[0]),  //Ordinal, convert
                           Name = r["Name"].ToString(), //By name, convert
                           Description = r.IsNull("description") ? "" : r["description"].ToString(), //handle DB nulls
                           Price = r.Field<decimal>("Price"),
                           Owned = r.Field<bool>("Owned"),
                           Completed = r.Field<bool>("Completed"),
                       };
            };

            return Enumerable.Empty<Game>();
        }

        protected override Game GetCore( int id )
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetGames";
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var gameId = reader.GetInt32(0);
                    if (gameId == id)
                    {                        
                        return new Game() 
                        {
                            Id = gameId,
                            Name = GetString(reader, "Name"),
                            Description = GetString(reader, "Description"),
                            Price = reader.GetFieldValue<decimal>(3),
                            Owned = Convert.ToBoolean(reader.GetValue(4)),
                            Completed = Convert.ToBoolean(reader.GetValue(5)),
                        };
                    };
                };
            };

            return null;
        }

        private string GetString ( IDataReader reader, string name )
        {
            var ordinal = reader.GetOrdinal(name);

            if (reader.IsDBNull(ordinal))
                return "";

            return reader.GetString(ordinal);
        }

        protected override Game UpdateCore( int id, Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UpdateGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1 - long way when you need control over parameter
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar);
                parameter.Value = game.Name;
                cmd.Parameters.Add(parameter);

                //Add parameter 2 - quick way when you just need type/value
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);
                cmd.Parameters.AddWithValue("@id", id);

                //No results
                cmd.ExecuteNonQuery();
            };

            return game;
        }
    }
}
