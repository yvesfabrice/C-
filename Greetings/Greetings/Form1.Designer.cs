namespace GreetingsbyFabrice
{
    partial class frmGreetings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGreetings));
            this.lblGreetings = new System.Windows.Forms.Label();
            this.tmrFlash = new System.Windows.Forms.Timer(this.components);
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdRe_Start = new System.Windows.Forms.Button();
            this.cmdTimeOne = new System.Windows.Forms.Button();
            this.cmdTimetwo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SecondTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGreetings.Location = new System.Drawing.Point(24, 39);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(192, 25);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Greetings Earthlings";
            // 
            // tmrFlash
            // 
            this.tmrFlash.Enabled = true;
            this.tmrFlash.Interval = 2000;
            this.tmrFlash.Tick += new System.EventHandler(this.tmrFlash_Tick);
            // 
            // cmdStop
            // 
            this.cmdStop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStop.ForeColor = System.Drawing.Color.Red;
            this.cmdStop.Location = new System.Drawing.Point(29, 133);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(105, 65);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "Stop\r\nFlashing";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdRe_Start
            // 
            this.cmdRe_Start.Enabled = false;
            this.cmdRe_Start.Location = new System.Drawing.Point(29, 218);
            this.cmdRe_Start.Name = "cmdRe_Start";
            this.cmdRe_Start.Size = new System.Drawing.Size(101, 54);
            this.cmdRe_Start.TabIndex = 3;
            this.cmdRe_Start.Text = "Re-Start";
            this.cmdRe_Start.UseVisualStyleBackColor = true;
            this.cmdRe_Start.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdTimeOne
            // 
            this.cmdTimeOne.Location = new System.Drawing.Point(166, 136);
            this.cmdTimeOne.Name = "cmdTimeOne";
            this.cmdTimeOne.Size = new System.Drawing.Size(75, 65);
            this.cmdTimeOne.TabIndex = 4;
            this.cmdTimeOne.Text = "Time 250";
            this.cmdTimeOne.UseVisualStyleBackColor = true;
            this.cmdTimeOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdTimetwo
            // 
            this.cmdTimetwo.Location = new System.Drawing.Point(166, 218);
            this.cmdTimetwo.Name = "cmdTimetwo";
            this.cmdTimetwo.Size = new System.Drawing.Size(75, 54);
            this.cmdTimetwo.TabIndex = 5;
            this.cmdTimetwo.Text = "Time 2000";
            this.cmdTimetwo.UseVisualStyleBackColor = true;
            this.cmdTimetwo.Click += new System.EventHandler(this.cmdTimertwo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SecondTimer
            // 
            this.SecondTimer.Location = new System.Drawing.Point(29, 79);
            this.SecondTimer.Name = "SecondTimer";
            this.SecondTimer.Size = new System.Drawing.Size(128, 23);
            this.SecondTimer.TabIndex = 6;
            this.SecondTimer.Text = "Second Timer ";
            this.SecondTimer.UseVisualStyleBackColor = true;
            this.SecondTimer.Click += new System.EventHandler(this.SecondTimer_Click);
            // 
            // frmGreetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.SecondTimer);
            this.Controls.Add(this.cmdTimetwo);
            this.Controls.Add(this.cmdTimeOne);
            this.Controls.Add(this.cmdRe_Start);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lblGreetings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGreetings";
            this.Text = "Greetings Create By Fabrice";
            this.Load += new System.EventHandler(this.frmGreetings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Timer tmrFlash;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdRe_Start;
        private System.Windows.Forms.Button cmdTimeOne;
        private System.Windows.Forms.Button cmdTimetwo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SecondTimer;
    }
}

