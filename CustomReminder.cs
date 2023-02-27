using System;
using System.Drawing;
using System.Windows.Forms;
//temp v

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
        string SpecificMode;
        bool executeOnce;
        ReminderDatabase tempdb = new ReminderDatabase();



        int Seconds = 0;
        int Minutes = 0;
        int Hours = 0;




        public CustomReminder(bool isRS, bool isRT, bool onetime, bool daily, bool weekly, bool monthly)
        {
            InitializeComponent();
            LoadLayout();

            reminderSpecific = isRS;
            reminderTimer = isRT;
            OneTime = onetime;
            Daily = daily;
            Weekly = weekly;
            Monthly = monthly;
            executeOnce = true;
            UpdateTimer.Interval = 100;
        }

        //NOTES: Center X = 143 

        private void CustomReminder_Load(object sender, EventArgs e)
        {
            HideConfirmMenu();
            HideSpecificTypeMenu();

            if (reminderSpecific)
            {
                HideTimerMenu();
                HideReminderMenu();
                ShowSpecificMenu();
            }
            else if (reminderTimer)
            {
                HideReminderMenu();
                ShowTimerMenu();
                HideSpecificMenu(false);
            }
            else
            {
                HideTimerMenu();
                ShowReminderMenu();
                HideSpecificMenu(false);
            }
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {


            if (OneTime || Daily || Weekly || Monthly)
            {
                if (executeOnce)
                {
                    if (OneTime)
                    {
                        SpecificMode = "onetime";
                        labelSpecificType.Text = "One-Time Reminder";
                        //labelSpecificType.Location = new Point(135, labelSpecificType.Location.Y);
                    }
                    if (Daily)
                    {
                        SpecificMode = "daily";
                        labelSpecificType.Text = "Daily Reminder";
                        // labelSpecificType.Location = new Point(155, labelSpecificType.Location.Y);
                    }
                    if (Weekly)
                    {
                        SpecificMode = "weekly";
                        labelSpecificType.Text = "Weekly Reminder";
                        //labelSpecificType.Location = new Point(150, labelSpecificType.Location.Y);
                    }
                    if (Monthly)
                    {
                        SpecificMode = "monthly";
                        labelSpecificType.Text = "Monthly Reminder";
                        //labelSpecificType.Location = new Point(150, labelSpecificType.Location.Y);
                    }

                    ShowSpecificTypeMenu();
                    HideSpecificMenu(true);
                    executeOnce = false;
                }
            }

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

        private void buttonSpecific_Click(object sender, EventArgs e)
        {
            reminderSpecific = true;
            HideReminderMenu();
            ShowSpecificMenu();
        }

        private void buttonNextTimer_Click(object sender, EventArgs e)
        {

            if (int.TryParse(inputSeconds.Text, out Seconds))
            {
                Seconds = Convert.ToInt32(inputSeconds.Text);
            }
            else
            {
                Seconds = 0;
            }

            if (int.TryParse(inputMinutes.Text, out Minutes))
            {
                Minutes = Convert.ToInt32(inputMinutes.Text);
            }
            else
            {
                Minutes = 0;
            }

            if (int.TryParse(inputHours.Text, out Hours))
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

        private void buttonBackArrow_Click(object sender, EventArgs e)
        {
            HideSpecificMenu(false);
            HideSpecificTypeMenu();
            ShowReminderMenu();
            OneTime = false;
            Daily = false;
            Weekly = false;
            Monthly = false;
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
            labelSpecificType.Location = new Point(140, 28);
            buttonBackArrow.Location = new Point(107, 38);
            buttonOneTime.Location = new Point(131, 38);
            buttonDaily.Location = new Point(131, 77);
            buttonWeekly.Location = new Point(131, 106);
            buttonMonthly.Location = new Point(131, 135);
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

        private void HideSpecificTypeMenu()
        {
            buttonBackArrow.Text = "<";
            labelSpecificType.Hide();
        }

        private void ShowSpecificTypeMenu()
        {
            buttonBackArrow.Text = "<<<";
            labelSpecificType.Show();
        }

        private void HideSpecificMenu(bool keepArrow)
        {
            buttonOneTime.Hide();
            buttonDaily.Hide();
            buttonWeekly.Hide();
            buttonMonthly.Hide();
            if (!keepArrow)
            {
                buttonBackArrow.Hide();
            }

        }

        private void ShowSpecificMenu()
        {
            buttonOneTime.Show();
            buttonDaily.Show();
            buttonWeekly.Show();
            buttonMonthly.Show();
            buttonBackArrow.Show();
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
            if (WhatToCheck == "Timer")
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
                    else if (Hours > 25 || Hours < 0)
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

        private void buttonOneTime_Click(object sender, EventArgs e)
        {
            OneTime = true;
            executeOnce = true;
        }

        private void buttonDaily_Click(object sender, EventArgs e)
        {
            Daily = true;
            executeOnce = true;
        }

        private void buttonWeekly_Click(object sender, EventArgs e)
        {
            Weekly = true;
            executeOnce = true;
        }

        private void buttonMonthly_Click(object sender, EventArgs e)
        {
            Monthly = true;
            executeOnce = true;
        }


    }
}
