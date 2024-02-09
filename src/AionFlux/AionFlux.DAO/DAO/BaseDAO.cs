//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using AionFlux.DAO.Regras;
//using AionFlux.DAO.Settings;
//using Microsoft.Data.Sqlite;
//using Microsoft.Extensions.Options;

//namespace AionFlux.DAO.DAO
//{
//    //public abstract class BaseDAO<T> : IDAO<T>
//    //{
//    //    protected string CONNECTION_STRING;
//    //    public string TabelaCreateQuery { get; set; }
//    //    public string SelectQuery { get; set; }
//    //    public string SelectQueryByID { get; set; }
//    //    public string InsertQuery { get; set; }
//    //    public string UpdateQuery { get; set; }
//    //    public string DeleteQuery { get; set; }
//    //    public string TabelaName { get; set; }

//    //    protected BaseDAO(
//    //        string tabelaQuery,
//    //        string selectQuery,
//    //        string insertQuery,
//    //        string tabelaName,
//    //        string updateQuery,
//    //        string deleteQuery,
//    //        string selectQueryByID,
//    //        IOptions<ConnectionStrings> connectionStringOptions)
//    //    {
//    //        TabelaCreateQuery = tabelaQuery;
//    //        SelectQuery = selectQuery;
//    //        InsertQuery = insertQuery;
//    //        TabelaName = tabelaName;
//    //        UpdateQuery = updateQuery;
//    //        DeleteQuery = deleteQuery;
//    //        SelectQueryByID = selectQueryByID;
//    //        CONNECTION_STRING = connectionStringOptions.Value.Master;
//    //        CriarBancoDeDados();
//    //    }

//    //    public void CriarBancoDeDados()
//    //    {
//    //        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //        {
//    //            sqlConnection.Open();

//    //            using (var cmd = sqlConnection.CreateCommand())
//    //            {
//    //                cmd.CommandText = TabelaCreateQuery;
//    //                cmd.ExecuteNonQuery();
//    //            }
//    //        }
//    //    }

//    //    public List<T> ObterRegistros()
//    //    {
//    //        List<T> registros = new List<T>();

//    //        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //        {
//    //            sqlConnection.Open();

//    //            using (var command = sqlConnection.CreateCommand())
//    //            {
//    //                command.CommandText = SelectQuery;

//    //                using (var reader = command.ExecuteReader())
//    //                {
//    //                    while (reader.Read())
//    //                    {
//    //                        T registro = CriarInstancia(reader);
//    //                        registros.Add(registro);
//    //                    }
//    //                }
//    //            }
//    //        }

//    //        return registros;
//    //    }

//    //    public int CriarRegistro(T objetoVo)
//    //    {
//    //        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //        {
//    //            sqlConnection.Open();

//    //            using (var command = sqlConnection.CreateCommand())
//    //            {
//    //                command.CommandText = InsertQuery;

//    //                // Assume que as propriedades do objetoVo correspondem aos parâmetros do comando SQL
//    //                foreach (var propriedade in typeof(T).GetProperties())
//    //                {
//    //                    command.Parameters.AddWithValue($"@{propriedade.Name}", propriedade.GetValue(objetoVo) ?? DBNull.Value);
//    //                }

//    //                command.ExecuteNonQuery();
//    //            }
//    //            using (var command = sqlConnection.CreateCommand())
//    //            {
//    //                command.CommandText = $"SELECT last_insert_rowid() FROM {TabelaName};";
//    //                var resultado = command.ExecuteScalar();
//    //                return Convert.ToInt32(resultado);
//    //            }
//    //        }
//    //    }

//    //    protected abstract T CriarInstancia(SqliteDataReader sqliteDataReader);

//    //    public Task AtualizarRegistro(T objetoParaAtualizar)
//    //    {
//    //        return Task.Run(() =>
//    //        {
//    //            using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //            {
//    //                sqlConnection.Open();

//    //                using (var command = sqlConnection.CreateCommand())
//    //                {
//    //                    command.CommandText = UpdateQuery;

//    //                    // Assume que as propriedades do objetoVo correspondem aos parâmetros do comando SQL
//    //                    foreach (var propriedade in typeof(T).GetProperties())
//    //                    {
//    //                        command.Parameters.AddWithValue($"@{propriedade.Name}", propriedade.GetValue(objetoParaAtualizar) ?? DBNull.Value);
//    //                    }

//    //                    command.ExecuteNonQuery();
//    //                }
//    //            }
//    //        });
//    //    }

//    //    public async Task<T> ObterRegistro(int ID)
//    //    {
//    //        List<T> registros = new List<T>();

//    //        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //        {
//    //            sqlConnection.Open();

//    //            using (var command = sqlConnection.CreateCommand())
//    //            {
//    //                command.CommandText = SelectQueryByID;
//    //                command.Parameters.AddWithValue($"ID", ID);
//    //                using (var reader = command.ExecuteReader())
//    //                {
//    //                    while (reader.Read())
//    //                    {
//    //                        T registro = CriarInstancia(reader);
//    //                        registros.Add(registro);
//    //                    }
//    //                }
//    //            }
//    //        }

//    //        return registros.FirstOrDefault();
//    //    }

//    //    public Task DeletarRegistro(int ID)
//    //    {
//    //        return Task.Run(() =>
//    //        {
//    //            using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //            {
//    //                sqlConnection.Open();

//    //                using (var command = sqlConnection.CreateCommand())
//    //                {
//    //                    command.CommandText = DeleteQuery;
//    //                    command.Parameters.AddWithValue($"ID", ID);
//    //                    command.ExecuteNonQuery();
//    //                }
//    //            }
//    //        });
//    //    }

//    //    public List<T> ObterRegistros(int ID)
//    //    {
//    //        List<T> registros = new List<T>();

//    //        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
//    //        {
//    //            sqlConnection.Open();

//    //            using (var command = sqlConnection.CreateCommand())
//    //            {
//    //                command.CommandText = SelectQueryByID;
//    //                command.Parameters.AddWithValue($"ID", ID);

//    //                using (var reader = command.ExecuteReader())
//    //                {
//    //                    while (reader.Read())
//    //                    {
//    //                        T registro = CriarInstancia(reader);
//    //                        registros.Add(registro);
//    //                    }
//    //                }
//    //            }
//    //        }

//    //        return registros;
//    //    }
//    }
//}
