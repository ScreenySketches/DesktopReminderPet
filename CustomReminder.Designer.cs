namespace TaskPet
{
    partial class CustomReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomReminder));
            this.reminderpb = new System.Windows.Forms.PictureBox();
            this.thoughtdot_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSpecific = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.inputHours = new System.Windows.Forms.MaskedTextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.inputMinutes = new System.Windows.Forms.MaskedTextBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.inputSeconds = new System.Windows.Forms.MaskedTextBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonNextTimer = new System.Windows.Forms.Button();
            this.buttonCancelTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reminderpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoughtdot_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reminderpb
            // 
            this.reminderpb.BackColor = System.Drawing.Color.Transparent;
            this.reminderpb.Image = ((System.Drawing.Image)(resources.GetObject("reminderpb.Image")));
            this.reminderpb.Location = new System.Drawing.Point(62, -1);
            this.reminderpb.Name = "reminderpb";
            this.reminderpb.Size = new System.Drawing.Size(281, 197);
            this.reminderpb.TabIndex = 0;
            this.reminderpb.TabStop = false;
            // 
            // thoughtdot_1
            // 
            this.thoughtdot_1.Image = ((System.Drawing.Image)(resources.GetObject("thoughtdot_1.Image")));
            this.thoughtdot_1.Location = new System.Drawing.Point(26, 190);
            this.thoughtdot_1.Name = "thoughtdot_1";
            this.thoughtdot_1.Size = new System.Drawing.Size(33, 38);
            this.thoughtdot_1.TabIndex = 1;
            this.thoughtdot_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSpecific
            // 
            this.buttonSpecific.BackColor = System.Drawing.Color.White;
            this.buttonSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpecific.Location = new System.Drawing.Point(95, 225);
            this.buttonSpecific.Name = "buttonSpecific";
            this.buttonSpecific.Size = new System.Drawing.Size(121, 23);
            this.buttonSpecific.TabIndex = 3;
            this.buttonSpecific.Text = "Specific Date or Time";
            this.buttonSpecific.UseVisualStyleBackColor = false;
            // 
            // buttonTimer
            // 
            this.buttonTimer.BackColor = System.Drawing.Color.White;
            this.buttonTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimer.Location = new System.Drawing.Point(222, 225);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(121, 23);
            this.buttonTimer.TabIndex = 4;
            this.buttonTimer.Text = "Timer";
            this.buttonTimer.UseVisualStyleBackColor = false;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(293, 16);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 34);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // inputHours
            // 
            this.inputHours.Location = new System.Drawing.Point(321, 227);
            this.inputHours.Mask = "00";
            this.inputHours.Name = "inputHours";
            this.inputHours.PromptChar = '0';
            this.inputHours.Size = new System.Drawing.Size(19, 20);
            this.inputHours.TabIndex = 10;
            this.inputHours.ValidatingType = typeof(int);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.Color.White;
            this.labelHours.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(282, 228);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(47, 17);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Hours";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.BackColor = System.Drawing.Color.White;
            this.labelMinutes.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.Location = new System.Drawing.Point(272, 227);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(62, 17);
            this.labelMinutes.TabIndex = 9;
            this.labelMinutes.Text = "Minutes";
            // 
            // inputMinutes
            // 
            this.inputMinutes.Location = new System.Drawing.Point(324, 222);
            this.inputMinutes.Mask = "00";
            this.inputMinutes.Name = "inputMinutes";
            this.inputMinutes.PromptChar = '0';
            this.inputMinutes.Size = new System.Drawing.Size(19, 20);
            this.inputMinutes.TabIndex = 9;
            this.inputMinutes.ValidatingType = typeof(int);
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.BackColor = System.Drawing.Color.White;
            this.labelSeconds.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Location = new System.Drawing.Point(279, 224);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(61, 17);
            this.labelSeconds.TabIndex = 11;
            this.labelSeconds.Text = "Seconds";
            // 
            // inputSeconds
            // 
            this.inputSeconds.Location = new System.Drawing.Point(321, 224);
            this.inputSeconds.Mask = "00";
            this.inputSeconds.Name = "inputSeconds";
            this.inputSeconds.PromptChar = '0';
            this.inputSeconds.Size = new System.Drawing.Size(19, 20);
            this.inputSeconds.TabIndex = 8;
            this.inputSeconds.ValidatingType = typeof(int);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.White;
            this.labelTimer.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(263, 211);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(80, 37);
            this.labelTimer.TabIndex = 12;
            this.labelTimer.Text = "Timer";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // buttonNextTimer
            // 
            this.buttonNextTimer.BackColor = System.Drawing.Color.White;
            this.buttonNextTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextTimer.Location = new System.Drawing.Point(270, 222);
            this.buttonNextTimer.Name = "buttonNextTimer";
            this.buttonNextTimer.Size = new System.Drawing.Size(70, 23);
            this.buttonNextTimer.TabIndex = 11;
            this.buttonNextTimer.Text = "Next";
            this.buttonNextTimer.UseVisualStyleBackColor = false;
            // 
            // buttonCancelTimer
            // 
            this.buttonCancelTimer.BackColor = System.Drawing.Color.White;
            this.buttonCancelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelTimer.Location = new System.Drawing.Point(266, 222);
            this.buttonCancelTimer.Name = "buttonCancelTimer";
            this.buttonCancelTimer.Size = new System.Drawing.Size(70, 23);
            this.buttonCancelTimer.TabIndex = 12;
            this.buttonCancelTimer.Text = "Cancel";
            this.buttonCancelTimer.UseVisualStyleBackColor = false;
            this.buttonCancelTimer.Click += new System.EventHandler(this.buttonCancelTimer_Click);
            // 
            // CustomReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(346, 246);
            this.Controls.Add(this.buttonCancelTimer);
            this.Controls.Add(this.buttonNextTimer);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.inputSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.inputMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.inputHours);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonSpecific);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thoughtdot_1);
            this.Controls.Add(this.reminderpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomReminder";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomReminder_FormClosed);
            this.Load += new System.EventHandler(this.CustomReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reminderpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoughtdot_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reminderpb;
        private System.Windows.Forms.PictureBox thoughtdot_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSpecific;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MaskedTextBox inputHours;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.MaskedTextBox inputMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.MaskedTextBox inputSeconds;
        private System.Windows.Forms.Label labelTimer;
        public System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button buttonNextTimer;
        private System.Windows.Forms.Button buttonCancelTimer;
    }
}