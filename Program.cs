using PizzariaDoZe.views;
using System.Configuration;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não acontecer
            //string? lang = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) 
            //               ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") 
            //               : "";
            //ajusta o idioma/região
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang!);
            //Thread.CurrentThread.CurrentCulture = new CultureInfo(lang!);
            #region Idioma
            AjustaIdiomaRegiao();
            #endregion

            ApplicationConfiguration.Initialize();

            Application.Run(new FormLogin());
        }

        static public void AjustaIdiomaRegiao()
        {
            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não acontecer
            string? lang = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang!);
        }
    }
}