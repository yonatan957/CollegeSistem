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
    internal partial class CreateCurse : Form
    {
        public NavigationService _navigationService { get; set; }
        public CoursRepository _coursRepository { get; set; }

        public CreateCurse(NavigationService navigationService, CoursRepository coursRepository)
        {
            InitializeComponent();
            _navigationService = navigationService;
            _coursRepository = coursRepository;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!_navigationService._isNavigate)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameCurse = textBox_curseName.Text;
            string Date = textBox_startDate.Text;
            string hourS = textBox_startHour.Text;
            string hourE = textBox__endHour.Text;
            string price = textBox_price.Text;
            string sunday = textBox_Sunday.Text;
            string Monday = textBox_Monday.Text;
            string Tuesday = textBox_Tuesday.Text;
            string Wednesday = textBox_Wednesday.Text;
            string Thursday = textBox_Thursday.Text;
            string Friday = textBox_Friday.Text;
            if (string.IsNullOrEmpty(NameCurse) || string.IsNullOrEmpty(Date) || string.IsNullOrEmpty(hourS) || string.IsNullOrEmpty(hourE) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("נא למלאות הכל");
            }
            List<string> list = new List<string>() { sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
            foreach (string day in list)
            {
                if (day != "0" && day != "1")
                {
                    MessageBox.Show("נא לסמן את הימים כמו בהוראות");
                    return;
                }
            }
            bool ressult = _coursRepository.Insert(NameCurse, hourE, price, Date, hourS, sunday, Monday, Thursday, Tuesday, Wednesday, Friday);
            if (!ressult)
            {
                MessageBox.Show("שגיאה! בדוק אם לא קיים כבר קורס זה");
                return;
            }
            textBox_curseName.Clear();
            textBox_startDate.Clear();
            textBox_startHour.Clear();
            textBox__endHour.Clear();
            textBox_price.Clear();
            textBox_Sunday.Clear();
            textBox_Monday.Clear();
            textBox_Tuesday.Clear();
            textBox_Wednesday.Clear();
            textBox_Thursday.Clear();
            textBox_Friday.Clear();
            MessageBox.Show("add succsesfully");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navigationService.ShowForm("home_page");
        }
    }
}
