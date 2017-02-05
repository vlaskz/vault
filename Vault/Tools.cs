using System;


namespace Vault
{
    static class Tools
    {
       public static string dataParaMySql(DateTime date)
        {
            string[] normal = date.ToString().Substring(0, 10).Split('/');
            Array.Reverse(normal);

            string revert = "";

            foreach (string s in normal)
                revert += s + '/';


            return revert.Substring(0, 10);

        }

        public static string dataParaMySql(string date)
        {
            string[] normal = date.Substring(0, 10).Split('/');
            Array.Reverse(normal);

            string revert = "";

            foreach (string s in normal)
                revert += s + '/';


            return revert.Substring(0, 10);
        }
    }
}
