namespace ProiectTetris2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        public static Conturi listaConturi;
        public class Conturi
        {
            public List<Cont> conturi { get; set; }
        }
        public class Cont
        {
            public int id { get; set; }
            public string username { get; set; }
            public string parola { get; set; }
        }

        public class Jucator
        {
            public int id { get; set; }
            public string numePersonal { get; set; }
            public int pozaProfil { get; set; }
            public int bani { get; set; }
            public int xp { get; set; }
            public List <int> produseCumparate { get; set; }

        }
        public class Jucatori
        {
            public List<Jucator> jucatori { get; set; }
        }

        public static Jucatori listaJucatori;

        public class Produs
        {
            int prodID { get; set; }
            string numeProdus { get; set; }
            int pretBani { get; set; }
            int pretXP { get; set; }
        }

        public class Produse
        {
            public List<Produs> produse { get; set; }
        }

        public static Produse listaProduselor;

        public static Cont contActual;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}