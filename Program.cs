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