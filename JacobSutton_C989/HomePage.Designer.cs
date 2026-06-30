namespace JacobSutton_C989
{
    partial class HomePage
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
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Customer_btn = new System.Windows.Forms.Button();
            this.Appointment_btn = new System.Windows.Forms.Button();
            this.Reports_btn = new System.Windows.Forms.Button();
            this.Upcoming_lbl = new System.Windows.Forms.Label();
            this.Upcoming_appt = new System.Windows.Forms.DataGridView();
            this.Appointment_cal = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming_appt)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.Location = new System.Drawing.Point(12, 25);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(75, 20);
            this.Welcome_lbl.TabIndex = 0;
            this.Welcome_lbl.Text = "Welcome";
            // 
            // Customer_btn
            // 
            this.Customer_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Customer_btn.Location = new System.Drawing.Point(12, 60);
            this.Customer_btn.Name = "Customer_btn";
            this.Customer_btn.Size = new System.Drawing.Size(92, 50);
            this.Customer_btn.TabIndex = 1;
            this.Customer_btn.Text = "Customers";
            this.Customer_btn.UseVisualStyleBackColor = false;
            this.Customer_btn.Click += new System.EventHandler(this.Customer_btn_Click);
            // 
            // Appointment_btn
            // 
            this.Appointment_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Appointment_btn.Location = new System.Drawing.Point(12, 116);
            this.Appointment_btn.Name = "Appointment_btn";
            this.Appointment_btn.Size = new System.Drawing.Size(92, 52);
            this.Appointment_btn.TabIndex = 2;
            this.Appointment_btn.Text = "Appointments";
            this.Appointment_btn.UseVisualStyleBackColor = false;
            this.Appointment_btn.Click += new System.EventHandler(this.Appointment_btn_Click);
            // 
            // Reports_btn
            // 
            this.Reports_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reports_btn.Location = new System.Drawing.Point(12, 174);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.Size = new System.Drawing.Size(92, 50);
            this.Reports_btn.TabIndex = 3;
            this.Reports_btn.Text = "Reports";
            this.Reports_btn.UseVisualStyleBackColor = false;
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_Click);
            // 
            // Upcoming_lbl
            // 
            this.Upcoming_lbl.AutoSize = true;
            this.Upcoming_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upcoming_lbl.Location = new System.Drawing.Point(332, 25);
            this.Upcoming_lbl.Name = "Upcoming_lbl";
            this.Upcoming_lbl.Size = new System.Drawing.Size(184, 20);
            this.Upcoming_lbl.TabIndex = 6;
            this.Upcoming_lbl.Text = "Upcoming Appointments";
            // 
            // Upcoming_appt
            // 
            this.Upcoming_appt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Upcoming_appt.Location = new System.Drawing.Point(391, 60);
            this.Upcoming_appt.Name = "Upcoming_appt";
            this.Upcoming_appt.Size = new System.Drawing.Size(444, 251);
            this.Upcoming_appt.TabIndex = 7;
            // 
            // Appointment_cal
            // 
            this.Appointment_cal.Location = new System.Drawing.Point(142, 60);
            this.Appointment_cal.Name = "Appointment_cal";
            this.Appointment_cal.TabIndex = 8;
            this.Appointment_cal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Appointment_cal_DateChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 563);
            this.Controls.Add(this.Appointment_cal);
            this.Controls.Add(this.Upcoming_appt);
            this.Controls.Add(this.Upcoming_lbl);
            this.Controls.Add(this.Reports_btn);
            this.Controls.Add(this.Appointment_btn);
            this.Controls.Add(this.Customer_btn);
            this.Controls.Add(this.Welcome_lbl);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.Upcoming_appt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Button Customer_btn;
        private System.Windows.Forms.Button Appointment_btn;
        private System.Windows.Forms.Button Reports_btn;
        private System.Windows.Forms.Label Upcoming_lbl;
        private System.Windows.Forms.DataGridView Upcoming_appt;
        private System.Windows.Forms.MonthCalendar Appointment_cal;
    }
}