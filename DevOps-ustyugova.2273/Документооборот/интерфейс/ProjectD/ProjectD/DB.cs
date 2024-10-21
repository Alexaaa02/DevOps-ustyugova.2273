using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectD
{
    class DB
    {
        //подключение к удаленной бд MySql
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;database=db_baza");

        // функция открывает соединение с бд
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        //функция, которая закрывает соединение с бд
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        //функция, которая возращает соединение MySqlConnection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
