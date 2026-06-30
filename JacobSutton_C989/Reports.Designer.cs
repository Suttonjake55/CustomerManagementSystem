namespace JacobSutton_C989
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.ApptMonth_btn = new System.Windows.Forms.Button();
            this.Reports_dgv = new System.Windows.Forms.DataGridView();
            this.UserSchedule_btn = new System.Windows.Forms.Button();
            this.UserLocation_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reports_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // ApptMonth_btn
            // 
            this.ApptMonth_btn.Location = new System.Drawing.Point(16, 55);
            this.ApptMonth_btn.Name = "ApptMonth_btn";
            this.ApptMonth_btn.Size = new System.Drawing.Size(115, 59);
            this.ApptMonth_btn.TabIndex = 1;
            this.ApptMonth_btn.Text = "Appointment By Month";
            this.ApptMonth_btn.UseVisualStyleBackColor = true;
            this.ApptMonth_btn.Click += new System.EventHandler(this.ApptMonth_btn_Click);
            // 
            // Reports_dgv
            // 
            this.Reports_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reports_dgv.Location = new System.Drawing.Point(202, 55);
            this.Reports_dgv.Name = "Reports_dgv";
            this.Reports_dgv.Size = new System.Drawing.Size(527, 322);
            this.Reports_dgv.TabIndex = 2;
            // 
            // UserSchedule_btn
            // 
            this.UserSchedule_btn.Location = new System.Drawing.Point(16, 138);
            this.UserSchedule_btn.Name = "UserSchedule_btn";
            this.UserSchedule_btn.Size = new System.Drawing.Size(115, 71);
            this.UserSchedule_btn.TabIndex = 3;
            this.UserSchedule_btn.Text = "User Schedule";
            this.UserSchedule_btn.UseVisualStyleBackColor = true;
            this.UserSchedule_btn.Click += new System.EventHandler(this.UserSchedule_btn_Click);
            // 
            // UserLocation_btn
            // 
            this.UserLocation_btn.Location = new System.Drawing.Point(16, 226);
            this.UserLocation_btn.Name = "UserLocation_btn";
            this.UserLocation_btn.Size = new System.Drawing.Size(115, 71);
            this.UserLocation_btn.TabIndex = 4;
            this.UserLocation_btn.Text = "Appointment Location";
            this.UserLocation_btn.UseVisualStyleBackColor = true;
            this.UserLocation_btn.Click += new System.EventHandler(this.UserLocation_btn_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserLocation_btn);
            this.Controls.Add(this.UserSchedule_btn);
            this.Controls.Add(this.Reports_dgv);
            this.Controls.Add(this.ApptMonth_btn);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.Reports_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ApptMonth_btn;
        private System.Windows.Forms.DataGridView Reports_dgv;
        private System.Windows.Forms.Button UserSchedule_btn;
        private System.Windows.Forms.Button UserLocation_btn;
    }
}