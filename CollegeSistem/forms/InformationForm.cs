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

    internal partial class InformationForm : Form
    {
        public NavigationService _navigationService { get; set; }
        public CoursRepository _coursRepository { get; set; }
        public InformationForm(NavigationService navigationService, CoursRepository coursRepository)
        {
            InitializeComponent();
            _navigationService = navigationService;
            _coursRepository = coursRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cursenum = textBox_num.Text;
            if (string.IsNullOrEmpty(cursenum)) { return; }
            if (!_coursRepository.IfCurseExist(cursenum))
            {
                MessageBox.Show("invalid curse id!");
                return;
            }
            int ressultPrice = _coursRepository.PriceCurse(cursenum);
            label_cursPrice.Text = $"{ressultPrice}";

            int ressultGet = _coursRepository.Studentpade(cursenum);
            label_getFromS.Text = ressultGet.ToString();

            label_profet.Text = $"{ressultGet /(ressultPrice / 100)  }";
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
