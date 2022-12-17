using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace TaskPet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MovementDelay();
            TurnDelay();
            RectInitialize();
            
            

        }

        //variables
        
        int imageNumb = 0;
        public bool isIdle = true;
        public bool isWalking = false;
        public bool isFacingLeft = true;
        public bool isBeingDragged;
        public bool isFalling = true;
        public bool isThinking;
        public bool Override;
        int Force;
        int movementSpeed;
        int walkDuration;
        int idleDuration;
        int turnDuration;
        Random randomGenerator = new Random();
        Rectangle windowRectangle = new Rectangle();
        Rectangle desktopRectangle = new Rectangle();
        private Point lastLocation;
        







        public async void TurnDelay()
        {
            
            for(int i = 0; i < 3; i++)
            {
                while(!isBeingDragged)
                {
                    turnDuration = randomGenerator.Next(3000, 13000);
                    isFacingLeft = false;
                    await Task.Delay(turnDuration);
                    isFacingLeft = true;
                    turnDuration = randomGenerator.Next(3000, 18000);
                    await Task.Delay(turnDuration);
                    
                }
                
            }
        }


        



        public async void MovementDelay()
        {
            for(int i = 0; i < 3; i++)
            {
                
                idleDuration = randomGenerator.Next(2000, 10000);
                walkDuration = randomGenerator.Next(2000, 4000);
                movementSpeed = randomGenerator.Next(9, 15);

                isIdle = true;
                isWalking = false;
                await Task.Delay(idleDuration);
                isIdle = false;
                isWalking = true;
                await Task.Delay(walkDuration);
                i = 0;
            }           
        }

        public void RectInitialize()
        {
            windowRectangle.Size = Size;
            windowRectangle.Location = Location;
            desktopRectangle = Screen.GetBounds(windowRectangle);
            
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void timerAnimateSprite_Tick(object sender, EventArgs e)
        {
            if (!Override)
            {
                if (isFalling)
                {
                    timerAnimateSprite.Interval = 100;

                    pb.Image = imageListFalling.Images[imageNumb];

                    if (imageNumb == imageListFalling.Images.Count - 1)
                    {
                        imageNumb = 0;
                    }
                    else
                    {
                        imageNumb++;
                    }

                }
                else if (isBeingDragged)
                {
                    timerAnimateSprite.Interval = 100;


                    if (isFacingLeft)
                    {
                        pb.Image = imageListDragL.Images[imageNumb];

                        if (imageNumb == imageListDragL.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }
                    }
                    else
                    {
                        pb.Image = imageListDragR.Images[imageNumb];

                        if (imageNumb == imageListDragR.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }
                    }


                }
                else if (isIdle)
                {
                    timerAnimateSprite.Interval = 165;

                    if (isFacingLeft)
                    {
                        pb.Image = imageListIdleL.Images[imageNumb];

                        if (imageNumb == imageListIdleL.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }
                    }
                    else
                    {
                        pb.Image = imageListIdleR.Images[imageNumb];

                        if (imageNumb == imageListIdleR.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }
                    }


                }
                else if (isWalking)
                {
                    timerAnimateSprite.Interval = 190 - (10 * movementSpeed);

                    if (isFacingLeft)
                    {
                        pb.Image = imageListWalkingL.Images[imageNumb];

                        if (imageNumb == imageListWalkingL.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }






                    }
                    else
                    {
                        pb.Image = imageListWalkingR.Images[imageNumb];

                        if (imageNumb == imageListWalkingR.Images.Count - 1)
                        {
                            imageNumb = 0;
                        }
                        else
                        {
                            imageNumb++;
                        }



                    }

                }
            }
            else if(isThinking && Override)
            {
                timerAnimateSprite.Interval = 100;

                pb.Image = imageListThinking.Images[imageNumb];

                if (imageNumb == imageListThinking.Images.Count - 1)
                {
                    imageNumb = 0;
                }
                else
                {
                    imageNumb++;
                }
            }
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {           
            if(CustomReminder.ThinkBubbleClosed && isThinking)
            {
                isThinking = false;
                Override = false;
                imageNumb = 0;
                CustomReminder.ThinkBubbleClosed = false;
            }

            //     v Bounds Check v

            windowRectangle.Location = Location;

            //     v Movement v

            if (!Override)
            {
                if (isBeingDragged)
                {

                }
                else if (!isFalling)
                {
                    if (isWalking)
                    {
                        if (isFacingLeft)
                        {

                            Left -= movementSpeed - 7;



                        }
                        else
                        {
                            Left += movementSpeed - 7;

                        }

                        // v Collision Detection v

                        if (!desktopRectangle.Contains(windowRectangle))
                        {
                            if (windowRectangle.Left < desktopRectangle.Left)
                            {
                                isFacingLeft = false;
                            }
                            if (windowRectangle.Right > desktopRectangle.Right)
                            {
                                isFacingLeft = true;
                            }
                        }

                    }
                }
                if (isFalling == true)
                {
                    Top -= Force;
                    Force -= 1;
                }
                if (windowRectangle.Top + windowRectangle.Height >= desktopRectangle.Height)
                {
                    Top = desktopRectangle.Height - windowRectangle.Height;
                    isFalling = false;
                    Force = 0;
                }
                else if (!isBeingDragged)
                {
                    isFalling = true;
                    Top += 1;
                }
                else if (isBeingDragged && isFalling)
                {
                    isFalling = false;
                    Force = 0;
                }
            }else if(isBeingDragged && Override)
            {
                isBeingDragged = false;
            }
            
        }       
        private void pb_Hover(object sender, EventArgs e)
        {
             
        }

        private void pb_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            isBeingDragged = true;
            lastLocation = e.Location;
            if (!isThinking)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenu.Show(this, new Point(e.X + ((Control)sender).Left + 20, e.Y + ((Control)sender).Top + 20));
                }
            }
            
        }
        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            isBeingDragged = false;
            TurnDelay();
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBeingDragged)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }       

        public void InitiateThinkBubble()
        {           
            Override = true;
            isThinking = true;            
        }

        private void addReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitiateThinkBubble();
            CustomReminder customReminder = new CustomReminder(false, false);
            customReminder.Show();
            customReminder.Location = new Point(windowRectangle.X + 80, windowRectangle.Y - 250);
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitiateThinkBubble();
            CustomReminder customReminder = new CustomReminder(false, true);
            customReminder.Show();
            customReminder.Location = new Point(windowRectangle.X + 80, windowRectangle.Y - 250);

            
        }

        
    }
}
