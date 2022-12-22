namespace TaskPet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb = new System.Windows.Forms.PictureBox();
            this.imageListIdleL = new System.Windows.Forms.ImageList(this.components);
            this.timerAnimateSprite = new System.Windows.Forms.Timer(this.components);
            this.imageListWalkingL = new System.Windows.Forms.ImageList(this.components);
            this.imageListIdleR = new System.Windows.Forms.ImageList(this.components);
            this.imageListWalkingR = new System.Windows.Forms.ImageList(this.components);
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.imageListDragL = new System.Windows.Forms.ImageList(this.components);
            this.imageListDragR = new System.Windows.Forms.ImageList(this.components);
            this.imageListFalling = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addReminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weeklyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListThinking = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(72, 93);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pb.MouseLeave += new System.EventHandler(this.pb_MouseLeave);
            this.pb.MouseHover += new System.EventHandler(this.pb_Hover);
            this.pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
            this.pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // imageListIdleL
            // 
            this.imageListIdleL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIdleL.ImageStream")));
            this.imageListIdleL.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIdleL.Images.SetKeyName(0, "idle_l_0.png");
            this.imageListIdleL.Images.SetKeyName(1, "idle_l_1.png");
            this.imageListIdleL.Images.SetKeyName(2, "idle_l_2.png");
            this.imageListIdleL.Images.SetKeyName(3, "idle_l_3.png");
            // 
            // timerAnimateSprite
            // 
            this.timerAnimateSprite.Enabled = true;
            this.timerAnimateSprite.Interval = 245;
            this.timerAnimateSprite.Tick += new System.EventHandler(this.timerAnimateSprite_Tick);
            // 
            // imageListWalkingL
            // 
            this.imageListWalkingL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWalkingL.ImageStream")));
            this.imageListWalkingL.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWalkingL.Images.SetKeyName(0, "walk_l_0.png");
            this.imageListWalkingL.Images.SetKeyName(1, "walk_l_1.png");
            this.imageListWalkingL.Images.SetKeyName(2, "walk_l_2.png");
            this.imageListWalkingL.Images.SetKeyName(3, "walk_l_3.png");
            // 
            // imageListIdleR
            // 
            this.imageListIdleR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIdleR.ImageStream")));
            this.imageListIdleR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIdleR.Images.SetKeyName(0, "idle_r_0.png");
            this.imageListIdleR.Images.SetKeyName(1, "idle_r_1.png");
            this.imageListIdleR.Images.SetKeyName(2, "idle_r_2.png");
            this.imageListIdleR.Images.SetKeyName(3, "idle_r_3.png");
            // 
            // imageListWalkingR
            // 
            this.imageListWalkingR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWalkingR.ImageStream")));
            this.imageListWalkingR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWalkingR.Images.SetKeyName(0, "walk_r_0.png");
            this.imageListWalkingR.Images.SetKeyName(1, "walk_r_1.png");
            this.imageListWalkingR.Images.SetKeyName(2, "walk_r_2.png");
            this.imageListWalkingR.Images.SetKeyName(3, "walk_r_3.png");
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 25;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // imageListDragL
            // 
            this.imageListDragL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDragL.ImageStream")));
            this.imageListDragL.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDragL.Images.SetKeyName(0, "drag_l_0.png");
            this.imageListDragL.Images.SetKeyName(1, "drag_l_1.png");
            this.imageListDragL.Images.SetKeyName(2, "drag_l_2.png");
            this.imageListDragL.Images.SetKeyName(3, "drag_l_3.png");
            // 
            // imageListDragR
            // 
            this.imageListDragR.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDragR.ImageStream")));
            this.imageListDragR.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDragR.Images.SetKeyName(0, "drag_r_0.png");
            this.imageListDragR.Images.SetKeyName(1, "drag_r_1.png");
            this.imageListDragR.Images.SetKeyName(2, "drag_r_2.png");
            this.imageListDragR.Images.SetKeyName(3, "drag_r_3.png");
            // 
            // imageListFalling
            // 
            this.imageListFalling.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFalling.ImageStream")));
            this.imageListFalling.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFalling.Images.SetKeyName(0, "fall_l_0.png");
            this.imageListFalling.Images.SetKeyName(1, "fall_l_1.png");
            this.imageListFalling.Images.SetKeyName(2, "fall_l_2.png");
            this.imageListFalling.Images.SetKeyName(3, "fall_l_3.png");
            // 
            // contextMenu
            // 
            this.contextMenu.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReminderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(179, 60);
            // 
            // addReminderToolStripMenuItem
            // 
            this.addReminderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specificDateToolStripMenuItem,
            this.timerToolStripMenuItem});
            this.addReminderToolStripMenuItem.Name = "addReminderToolStripMenuItem";
            this.addReminderToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.addReminderToolStripMenuItem.Text = "Add Reminder";
            this.addReminderToolStripMenuItem.Click += new System.EventHandler(this.addReminderToolStripMenuItem_Click);
            // 
            // specificDateToolStripMenuItem
            // 
            this.specificDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oneTimeToolStripMenuItem,
            this.dailyToolStripMenuItem,
            this.weeklyToolStripMenuItem,
            this.monthlyToolStripMenuItem});
            this.specificDateToolStripMenuItem.Name = "specificDateToolStripMenuItem";
            this.specificDateToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.specificDateToolStripMenuItem.Text = "Specific Date";
            // 
            // oneTimeToolStripMenuItem
            // 
            this.oneTimeToolStripMenuItem.Name = "oneTimeToolStripMenuItem";
            this.oneTimeToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.oneTimeToolStripMenuItem.Text = "One-Time";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.dailyToolStripMenuItem.Text = "Daily";
            // 
            // weeklyToolStripMenuItem
            // 
            this.weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            this.weeklyToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.weeklyToolStripMenuItem.Text = "Weekly";
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.exitToolStripMenuItem.Text = "Kill";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageListThinking
            // 
            this.imageListThinking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListThinking.ImageStream")));
            this.imageListThinking.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListThinking.Images.SetKeyName(0, "think_1.png");
            this.imageListThinking.Images.SetKeyName(1, "think_2.png");
            this.imageListThinking.Images.SetKeyName(2, "think_3.png");
            this.imageListThinking.Images.SetKeyName(3, "think_4.png");
            this.imageListThinking.Images.SetKeyName(4, "think_5.png");
            this.imageListThinking.Images.SetKeyName(5, "think_6.png");
            this.imageListThinking.Images.SetKeyName(6, "think_7.png");
            this.imageListThinking.Images.SetKeyName(7, "think_8.png");
            this.imageListThinking.Images.SetKeyName(8, "think_9.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(72, 93);
            this.Controls.Add(this.pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ImageList imageListIdleL;
        public System.Windows.Forms.PictureBox pb;
        public System.Windows.Forms.Timer timerAnimateSprite;
        public System.Windows.Forms.ImageList imageListWalkingL;
        public System.Windows.Forms.ImageList imageListIdleR;
        public System.Windows.Forms.ImageList imageListWalkingR;
        public System.Windows.Forms.Timer UpdateTimer;
        public System.Windows.Forms.ImageList imageListDragL;
        public System.Windows.Forms.ImageList imageListDragR;
        public System.Windows.Forms.ImageList imageListFalling;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReminderToolStripMenuItem;
        public System.Windows.Forms.ImageList imageListThinking;
        private System.Windows.Forms.ToolStripMenuItem specificDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weeklyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
    }
}

