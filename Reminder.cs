using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace TaskPet
{
    public partial class Reminder : Form
    {
        //variables:

        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string ANTICIPATEDTIME { get; set; }

        public bool isDone { get; set; }

        public string currentTime;

        public bool executeONCE = true;





        public Reminder()
        {
            InitializeComponent();



        }

        private void Reminder_Load(object sender, EventArgs e)
        {

        }

        public void UpdateTimer_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            Debug.WriteLine(currentTime);
            Debug.WriteLine(ANTICIPATEDTIME);

            if (currentTime == ANTICIPATEDTIME && executeONCE == true)
            {
                executeONCE = false;
                Alert();
                Debug.WriteLine("ALERT ALERT ALERT ALERT");
            }



        }

        private void Alert()
        {
            SoundPlayer player = new SoundPlayer(@"./assets/sounds/notification.wav");

            player.Play();

            if (string.IsNullOrEmpty(TITLE))
                TITLE = "Unspecified Timer";

            if (string.IsNullOrEmpty(DESCRIPTION))
            {
                notify.BalloonTipText = TITLE;
            }
            else
            {
                notify.BalloonTipTitle = TITLE;
                notify.BalloonTipText = DESCRIPTION;
            }


            notify.Text = "Notification";
            notify.Visible = true;
            notify.ShowBalloonTip(5000);
            notify.Dispose();
            MessageBox.Show(DESCRIPTION, TITLE);
            isDone = true;
            Form1.RLT_bool = true;


        }


    }
}
