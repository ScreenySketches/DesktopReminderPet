using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//temp v
using System.Diagnostics;

namespace TaskPet
{
    public partial class CustomReminder : Form
    {
        //variables
        

        public string PreMenu;
        public bool reminderSpecific;
        public bool reminderTimer;
        bool Daily;
        bool Weekly;
        bool Monthly;
        bool OneTime;        
        public static bool ThinkBubbleClosed;
        public static bool MadeTimer;
        bool isValid = true;
        ReminderDatabase tempdb = new ReminderDatabase();



        int Seconds = 0;
        int Minutes = 0;
        int Hours = 0;


        

        public CustomReminder(bool isRS, bool isRT)
        {
            InitializeComponent();
            LoadLayout();
            
            reminderSpecific = isRS;
            reminderTimer = isRT;
            UpdateTimer.Interval = 1000;
        }

        //NOTES: Center X = 143 

        private void CustomReminder_Load(object sender, EventArgs e)
        {
            HideConfirmMenu();

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

        private void buttonNextTimer_Click(object sender, EventArgs e)
        {
            
            if(int.TryParse(inputSeconds.Text, out Seconds))
            {
                Seconds = Convert.ToInt32(inputSeconds.Text);
            }
            else
            {
                Seconds = 0;
            }
                       
            if(int.TryParse(inputMinutes.Text, out Minutes))
            {
                Minutes = Convert.ToInt32(inputMinutes.Text);
            }
            else
            {
                Minutes = 0;
            }

            if(int.TryParse(inputHours.Text, out Hours))
            {
                Hours = Convert.ToInt32(inputHours.Text);
            }

            CheckIfValid("Timer");
        }
       
            private void buttonBack_Click(object sender, EventArgs e)
            {
                HideConfirmMenu();
                switch (PreMenu)
                {
                    case "timer":
                        ShowTimerMenu();
                        break;
                }
            }

        private async void buttonConfirm_Click(object sender, EventArgs e)
        {
            
            await tempdb.NewReminderTimer(inputTitle.Text, inputDescription.Text, Seconds.ToString(), Minutes.ToString(), Hours.ToString());
            Seconds = 0;
            MadeTimer = true;
            Close();
        }


        //PreLoad and Functions

        private void LoadLayout()
        {
            invalid.Location = new Point(160, 129);
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
            labelTitle.Location = new Point(180, 14);
            inputTitle.Location = new Point(150, 41);
            labelDescription.Location = new Point(92, 60);
            inputDescription.Location = new Point(94, 86);
            buttonBack.Location = new Point(114, 148);
            buttonConfirm.Location = new Point(220, 148);
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
        
        private void HideConfirmMenu()
        {
            labelTitle.Hide();
            labelDescription.Hide();
            inputTitle.Hide();
            inputDescription.Hide();
            buttonBack.Hide();
            buttonConfirm.Hide();
        }

        private void ShowConfirmMenu()
        {
            labelTitle.Show();
            labelDescription.Show();
            inputTitle.Show();
            inputDescription.Show();
            buttonBack.Show();
            buttonConfirm.Show();
        }

        private void CheckIfValid(string WhatToCheck = "", string notValidState = "", string whatisInvalid = "")
        {
            if(WhatToCheck == "Timer")
            {
                if (Seconds > 59 || Minutes > 59 || Hours > 24 || Seconds < 0 || Minutes < 0 || Hours < 0)
                {
                    isValid = false;
                    if (Seconds > 59 || Seconds < 0)
                    {
                        whatisInvalid = "Seconds";
                    }
                    else if (Minutes > 59 || Minutes < 0)
                    {
                        whatisInvalid = "Minutes";
                    }
                    else if (Hours > 24 || Hours < 0)
                    {
                        whatisInvalid = "Hours";
                    }
                }
                else
                {
                    isValid = true;
                }
                
                
            }

            if (isValid)
            {
                PreMenu = "timer";
                reminderTimer = false;
                reminderSpecific = false;
                invalid.Hide();
                ShowConfirmMenu();
                HideTimerMenu();
            }
            else
            {
                notValidState = whatisInvalid + " is invalid";
                invalid.Text = notValidState;
                invalid.Show();
            }
        }

         

            

            
        

        

        
        
    }
}
