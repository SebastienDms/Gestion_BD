using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gestion_BD
{
    class BD_Connect
    {
        string cConnexion = @"Server=192.168.0.24; Port=3306; Database=db_test; Uid=root2; Pwd=Cedrus@2604";
        private MySqlConnection _connection;

        public BD_Connect()
        {
            _connection = new MySqlConnection(cConnexion);

            //SqlCommand _command = new SqlCommand("SHOW DATABASES", _connection);
            try
            {
                _connection.Open();

                MessageBox.Show("Connexion réussie!\n" + _connection.ServerVersion, "Infos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connexion échouée!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Console.WriteLine(e);
                throw;
            }
        }

        public void closeConnection()
        {
            try
            {
                _connection.Close();
                MessageBox.Show("Déconnexion effectuée!", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<string> showDatabases()
        {
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = "SHOW DATABASES;";
            MySqlDataReader Reader = command.ExecuteReader();
            List<string> lDB = new List<string>();
            while (Reader.Read())
            {
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    lDB.Add(Reader.GetValue(i).ToString());
                }
            }

            return lDB;
        }
    }
}
