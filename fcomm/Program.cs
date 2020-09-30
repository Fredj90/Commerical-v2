using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fcomm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String Societe = "";
      public static String  LibSociete ="";
      public static String Magasin = "";
      public static String LibMagasin = "";
      public static String LibEnteteMagasin = "";
      public static String Exercice = "";
      public static String User = "";
      public static String LibUser = "";
      public static String TypUser = "";
      public static String IsDecimalQte = "";
      public static String IsDecimalCR = "";
      public static String IsDecimalCRa = "";
      public static String IsMonnaie1 = "";
      public static String IsMonnaie2 = "";
      public static String IsMonnaiea1 = "";
      public static String IsMonnaiea2 = "";
      public static String IsDecimal = "";
      public static String IsDecimala = "";
      public static Boolean TFunction = true;
      public static Boolean ISaDmin = false;
      public static Boolean ISSaDmin = false;
      public static Boolean ISFodec = false;
      public static Boolean ISDemo = false;
      public static Boolean ISAret = false;
     
     public static String v1 = "", v2 = "", v3 = "", v4 = "", v5 = "", v6 = "", a1 = "", a2 = "", a3 = "", a4 = "", f1 = "", f2 = "", f3 = "", f4 = "", f5 = "", b1 = "", b2 = "", b3 = "", b4 = "", b5 = "", b6 = "";
      public static String creation = "", modification = "", suppression = "";

     public static metier met = new metier();
        public static String Str_con;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connect());
        }

    }
}
