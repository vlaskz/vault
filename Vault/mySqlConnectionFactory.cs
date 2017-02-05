
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vault
{
    class MySqlDataManager
    {

        public MySqlConnection genCon()
        {
            return new MySqlConnection("server = localhost; user id = root; password=root;persistsecurityinfo=True;database=vault;port=8080;allowuservariables=True");
        }

        public string testConnection()
        {
            try
            {
                con.Open();
                return con.State.ToString();
            }
            catch (System.Exception)
            {

                throw;
            }


        }


        public DataTable select(string table, string command)
        {
            DataTable result = new DataTable(table);
            using (MySqlCommand comm = new MySqlCommand(command, con))
            {
                con.Open();
                result.Load(comm.ExecuteReader());
                con.Close();
            }
            return result;



        }


    }
}
