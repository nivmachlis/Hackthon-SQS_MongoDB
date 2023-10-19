using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;


namespace HacktonSQS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inject AWSConfig into SenderForm
            Application.Run(new SenderForm());
        }
    }
}
