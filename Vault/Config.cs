namespace Vault
{
   using System.IO;
    class Config
    {
        public static string confcaixa = @"C:\confcaixa.dat";
        public static string operador = @"C:\operador.dat";
        public static string checkout = @"C:\checkout.dat";
        public static string log = @"C:\log.dat";

        public void CreateDatabase()
        {
            if (!File.Exists(confcaixa))
                File.Create(confcaixa);

            if (!File.Exists(operador))
                File.Create(operador);

            if (!File.Exists(checkout))
                File.Create(checkout);

            if (!File.Exists(log))
                File.Create(log);
            
        }
    }
}
