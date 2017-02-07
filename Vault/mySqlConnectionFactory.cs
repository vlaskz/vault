
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

        public bool testConnection()
        {
            try
            {
                MySqlConnection con = new MySqlDataManager().genCon();
                con.Open();
                return (con.State == ConnectionState.Open);
            }
            catch (System.Exception)
            {

                throw;
            }


        }


        public DataTable select(string table, string command)
        {
            MySqlConnection con = new MySqlDataManager().genCon();
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
