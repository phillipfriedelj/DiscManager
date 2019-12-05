using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DiscManager
{
    class DatabaseManager
    {
        private const string DATABASE = @"Data Source=D:\DiscManager\Database\disc_test.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        SQLiteConnection connection;

        public enum DatabaseCategories
        {
            Autor,
            Periodo,
            Obra1, 
            Obra2,
            Subobra,
            Subobra2,
            Duracion,
            Instrum, 
            Interpte,
            Director,
            Orquesta,
            Coro,
            DiscNum, 
            FabricNum, 
            CintaNum,
            Coment,
            Numero
        }

        public enum OperationType
        {
            RetrieveAll,
            RetrieveOne,
            Add,
            Update,
            Delete
        }

        public void CreateConnection()
        {
            connection = new SQLiteConnection(DATABASE);
            connection.Open();
            System.Diagnostics.Debug.WriteLine("Connection Succesfull");
        }

        public void ExecuteQuery(OperationType operation, DatabaseCategories? category, string query)
        {
            switch (operation)
            {
                case OperationType.RetrieveAll:
                    using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM disc", connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                System.Diagnostics.Debug.WriteLine(reader["Autor"].ToString());
                            }
                        }
                    }
                        break;
                case OperationType.RetrieveOne:
                    string retrOneQuery = String.Format("SELECT * FROM disc WHERE {0} = '{1}'", category, query);
                    using (SQLiteCommand command = new SQLiteCommand(retrOneQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string aut = reader["Autor"].ToString();
                                string per = reader["Periodo"].ToString();
                                string obra1 = reader["Obra1"].ToString();
                                string obra2 = reader["Obra2"].ToString();
                                string subobra = reader["Subobra"].ToString();
                                string subobra2 = reader["Subobra2"].ToString();
                                double dur = Double.Parse(reader["Duracion"].ToString());
                                string instrum = reader["Instrum"].ToString();
                                string interprete = reader["Interpte"].ToString();
                                string dir = reader["Director"].ToString();
                                string orqu = reader["Orquesta"].ToString();
                                string coro = reader["Coro"].ToString();
                                string discNum = reader["DiscNum"].ToString();
                                string fabricNum = reader["FabricNum"].ToString();
                                int cintaNum = int.Parse(reader["CintaNum"].ToString());
                                string coment = reader["Coment"].ToString();
                                int numero = int.Parse(reader["Numero"].ToString());

                                Disc disc = new Disc(aut, per,obra1, obra2, subobra, subobra2, dur, instrum, interprete, dir, orqu, coro, discNum, fabricNum, cintaNum, coment, numero);
                                System.Diagnostics.Debug.WriteLine("New Disc: " + disc);
                            }
                        }
                    }
                    break;
                case OperationType.Add:
                    break;
                case OperationType.Update:
                    break;
                case OperationType.Delete:
                    break;
                default:
                    break;
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
