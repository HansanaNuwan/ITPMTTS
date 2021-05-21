
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementSystem.Classes
{
    class SqliteHelper
    {
        public SqliteHelper()
        {
            /*
             SQLiteConnection.CreateFile("MyDatabase.sqlite");

SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
m_dbConnection.Open();

string sql = "create table highscores (name varchar(20), score int)";

SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
command.ExecuteNonQuery();

sql = "insert into highscores (name, score) values ('Me', 9001)";

command = new SQLiteCommand(sql, m_dbConnection);
command.ExecuteNonQuery();

m_dbConnection.Close();*/


            if (!System.IO.File.Exists("database.sqlite"))
            {
                SQLiteConnection.CreateFile("database.sqlite");

            }

        }

        public SQLiteConnection GetSQLiteConnection()
        {
            return new SQLiteConnection("Data Source=database.sqlite;Version=3;");
        }
    }
}
