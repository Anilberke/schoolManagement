using System;
using System.Windows.Forms;

namespace schoolManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initialize the time label with the current local time
            UpdateTimeLabel();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time label every second
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            // Update the label text with the current local time
            labelTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }
        
    }
}