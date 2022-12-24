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
using System.Diagnostics;
using System.Media;

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

        
        
        

        public Reminder()
        {
            InitializeComponent();

            

        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            Debug.WriteLine(currentTime);
            Debug.WriteLine(ANTICIPATEDTIME);

            if (currentTime == ANTICIPATEDTIME)
            {
                Alert();
                Debug.WriteLine("ALERT ALERT ALERT ALERT");                
            }
            

            
        }

        private void Alert()
        {
            SoundPlayer player = new SoundPlayer(@"./assets/sounds/notification.wav");
            
            player.Play();

            if(TITLE == "")
            {
                TITLE = "Unspecified Timer";
            }

            if(DESCRIPTION == "")
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
            isDone = true;
            Form1.RLT_bool = true;
            
            
        }

        
    }
}
