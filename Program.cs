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
            string? lang = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) 
                           ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") 
                           : "";
            //ajusta o idioma/regi�o
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(lang!);


            ApplicationConfiguration.Initialize();

            Application.Run(new FormLogin());

        }
    }
}