using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TaskPet
{
    public partial class CustomReminder : Form 
    {
        //variables

        public bool reminderSpecific;
        public bool reminderTimer;
        public bool Daily;
        public bool Weekly;
        public bool Monthly;
        public bool OneTime;
        public static bool ThinkBubbleClosed;

        

        public CustomReminder(bool isRS, bool isRT)
        {
            InitializeComponent();
            LoadLayout();
            
            reminderSpecific = isRS;
            reminderTimer = isRT;
        }

        //NOTES: Center X = 143 

        private void CustomReminder_Load(object sender, EventArgs e)
        {
            if (reminderSpecific)
            {

            }else if (reminderTimer)
            {
                HideReminderMenu();
                ShowTimerMenu();                              
            }
            else
            {
                HideTimerMenu();
                ShowReminderMenu();               
            }
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

        }

        private void buttonCancelTimer_Click(object sender, EventArgs e)
        {
            reminderTimer = false;
            HideTimerMenu();
            ShowReminderMenu();           
        }


        public void CustomReminder_FormClosed(object sender, FormClosedEventArgs e)
        {           
            ThinkBubbleClosed = true;           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            reminderTimer = true;
            HideReminderMenu();
            ShowTimerMenu();
        }
            
        private void LoadLayout()
        {
            buttonSpecific.Location = new Point(143, 60);
            buttonTimer.Location = new Point(143, 120);
            labelTimer.Location = new Point(162, 31);
            labelHours.Location = new Point(249, 75);
            labelMinutes.Location = new Point(176, 75);
            labelSeconds.Location = new Point(110, 75);
            inputHours.Location = new Point(266, 109);
            inputMinutes.Location = new Point(199, 109);
            inputSeconds.Location = new Point(133, 109);
            buttonCancelTimer.Location = new Point(133, 146);
            buttonNextTimer.Location = new Point(213, 146);
        }

        private void HideTimerMenu()
        {
            labelTimer.Hide();
            labelHours.Hide();
            labelMinutes.Hide();
            labelSeconds.Hide();
            inputHours.Hide();
            inputMinutes.Hide();
            inputSeconds.Hide();
            buttonCancelTimer.Hide();
            buttonNextTimer.Hide();
        }

        private void ShowTimerMenu()
        {
            labelTimer.Show();
            labelHours.Show();
            labelMinutes.Show();
            labelSeconds.Show();
            inputHours.Show();
            inputMinutes.Show();
            inputSeconds.Show();
            buttonCancelTimer.Show();
            buttonNextTimer.Show();
        }
        private void HideReminderMenu()
        {
            buttonSpecific.Hide();
            buttonTimer.Hide();
        }

        private void ShowReminderMenu()
        {
            buttonSpecific.Show();
            buttonTimer.Show();
        }

    }
}
