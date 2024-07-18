using College.DAL.Repositries;
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
    internal partial class CreateTopic : Form
    {
        public CoursRepository coursRepository { get; set; }
        public NavigationService _navigationService { get; set; }

        public CreateTopic(NavigationService navigationService, CoursRepository coursRepository)
        {
            InitializeComponent();
            _navigationService = navigationService;
            this.coursRepository = coursRepository; 
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navigationService.ShowForm("home_page");
        }

        private void button_addTopic_Click(object sender, EventArgs e)
        {
            string TID = textBox_TID.Text;
            string CID = textBox_CID.Text;
            string TopicName = textBox_Tname.Text;
            string hours = textBox_hours.Text;
            bool ressult = coursRepository.InsertTopic(CID, TID, TopicName, hours);
            if (!ressult)
            {
                MessageBox.Show("error! check if it's allready exist");
                return;
            }
            textBox_TID.Clear();
            textBox_CID.Clear();
            textBox_Tname.Clear();
            MessageBox.Show("insert succsessfuly");
        }
    }
}
