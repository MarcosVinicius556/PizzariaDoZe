using PizzariaDoZe.views;

namespace PizzariaDoZe
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new FormLogin());

        }
    }
}