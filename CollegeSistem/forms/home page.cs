using ShabatGuest.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeSistem.forms
{
    internal partial class home_page : Form
    {
        public NavigationService _navigationService { get; set; }

        public home_page(NavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }

        private void button_addcurse_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("CreateCurse");
        }

        private void button_addtopic_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("CreateTopic");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _navigationService.ShowForm("InformationForm");
        }
    }
}
