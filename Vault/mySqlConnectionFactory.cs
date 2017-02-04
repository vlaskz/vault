
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vault
{
    class MySqlDataManager
    {
        
        MySqlConnection con = new MySqlConnection("server = localhost; user id = root; password=root;persistsecurityinfo=True;database=vault;port=8080;allowuservariables=True");

        public void testConnection()
        {
            con.Open();
            MessageBox.Show(con.State.ToString());
            con.Close();
        }


        public DataTable select(string table, string command)
        {
            DataTable result = new DataTable(table);
            using(MySqlCommand comm = new MySqlCommand(command, con))
            {
                con.Open();
                result.Load(comm.ExecuteReader());
                con.Close();
            }
            return result;

           

        }

        public bool insert(string command)
        {
            using (MySqlCommand comm = new MySqlCommand(command, con))
            {
                con.Open();


                bool status = true;
                return status;
            }
            
        }


    }
}
