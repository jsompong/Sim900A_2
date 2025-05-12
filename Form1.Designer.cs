namespace Sim900A_2
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
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SentBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Rxtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM6";
            // 
            // SentBox
            // 
            this.SentBox.AllowDrop = true;
            this.SentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentBox.Location = new System.Drawing.Point(407, 25);
            this.SentBox.Multiline = true;
            this.SentBox.Name = "SentBox";
            this.SentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SentBox.Size = new System.Drawing.Size(347, 229);
            this.SentBox.TabIndex = 0;
            this.SentBox.TextChanged += new System.EventHandler(this.SentBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Rxtimer
            // 
            this.Rxtimer.Interval = 500;
            this.Rxtimer.Tick += new System.EventHandler(this.Rxtimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SentBox);
            this.Name = "Form1";
            this.Text = "SIm900A Simu. COM8 Tx";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.TextBox SentBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer Rxtimer;
    }
}

