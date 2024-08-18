using log4net;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Text;

namespace TicketHelper
{
    internal static class Program
    {
        public static  IConfigurationRoot configuration;
        public static  ILog log = LogManager.GetLogger(string.Empty);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsetting.json");
            configuration = configurationBuilder.Build();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Application.Run(new MainForm());
        }
    }
}