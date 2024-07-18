using College.DAL.Repositries;
using Microsoft.Extensions.Configuration;
using ShabatGuest.BL;
using ShabatGuest.DAL;

namespace CollegeSistem
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var config = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
                .Build();
            string Conn = config["connectionstring"];
            DBconnections dBconnections = new DBconnections(Conn);
            CoursRepository coursRepository = new CoursRepository(dBconnections);
            StudentRepository studentRepository = new StudentRepository(dBconnections);
            NavigationService navigationService = new NavigationService(dBconnections, studentRepository, coursRepository);
            navigationService.ShowForm("home_page");
            Application.Run();
        }
    }
}