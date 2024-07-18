using College.DAL.Repositries;
using CollegeSistem.forms;
using ShabatGuest.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatGuest.BL
{
    
    internal class NavigationService
    {   
        
        public CoursRepository CoursRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public bool _isNavigate { get; set; }
        public DBconnections _dbconnections { get; init; }

        public NavigationService(DBconnections dBconnections, StudentRepository studentRepository, CoursRepository coursRepository)
        {
            _dbconnections = dBconnections;
            _isNavigate = false;
            StudentRepository = studentRepository;
            CoursRepository = coursRepository;
        }
        private void CloseAllForms()
        {
            _isNavigate = true;
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            _isNavigate = false;
        }
        public void ShowForm(string formName, string name = "e")
        {
            CloseAllForms();
            Form form = formName switch
            {
                "home_page" => new home_page(this),
                "CreateTopic" => new CreateTopic(this, CoursRepository),
                "CreateCurse" => new CreateCurse(this, CoursRepository),
                "InformationForm" => new InformationForm(this, CoursRepository),
                _ => throw new ArgumentException("invalid form name.", nameof(formName)),
            };
            form.Show();
        }

    }
}
