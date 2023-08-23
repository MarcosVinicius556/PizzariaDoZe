using PizzariaDoZe.views;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string lang = "en-US";
            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);


            ApplicationConfiguration.Initialize();

            Application.Run(new FormLogin());

        }
    }
}