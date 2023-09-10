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
            // no tern�rio estamos tratando para isso n�o acontecer
            //string? lang = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) 
            //               ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") 
            //               : "";
            //ajusta o idioma/regi�o
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
            // no tern�rio estamos tratando para isso n�o acontecer
            string? lang = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/regi�o
            // o operador ! (null-forgiving) afirma que o valor j� foi tratado e n�o ser� nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang!);
        }
    }
}