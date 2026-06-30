namespace JacobSutton_C989.AppointmentForms
{
    partial class AddAppointment
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
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Customer_CB = new System.Windows.Forms.ComboBox();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.Description_txt = new System.Windows.Forms.TextBox();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.Contact_txt = new System.Windows.Forms.TextBox();
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.URL_txt = new System.Windows.Forms.TextBox();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(91, 373);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 0;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(172, 373);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(59, 45);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.CustomerLabel.TabIndex = 2;
            this.CustomerLabel.Text = "Customer";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(59, 81);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(59, 109);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 4;
            this.DescriptionLbl.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "StartTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "EndTime";
            // 
            // Customer_CB
            // 
            this.Customer_CB.FormattingEnabled = true;
            this.Customer_CB.Location = new System.Drawing.Point(126, 42);
            this.Customer_CB.Name = "Customer_CB";
            this.Customer_CB.Size = new System.Drawing.Size(121, 21);
            this.Customer_CB.TabIndex = 12;
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(126, 73);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(100, 20);
            this.Title_txt.TabIndex = 13;
            // 
            // Description_txt
            // 
            this.Description_txt.Location = new System.Drawing.Point(126, 109);
            this.Description_txt.Name = "Description_txt";
            this.Description_txt.Size = new System.Drawing.Size(100, 20);
            this.Description_txt.TabIndex = 14;
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(126, 142);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(100, 20);
            this.Location_txt.TabIndex = 15;
            // 
            // Contact_txt
            // 
            this.Contact_txt.Location = new System.Drawing.Point(126, 173);
            this.Contact_txt.Name = "Contact_txt";
            this.Contact_txt.Size = new System.Drawing.Size(100, 20);
            this.Contact_txt.TabIndex = 16;
            // 
            // Type_CB
            // 
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.Location = new System.Drawing.Point(126, 202);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(121, 21);
            this.Type_CB.TabIndex = 17;
            // 
            // URL_txt
            // 
            this.URL_txt.Location = new System.Drawing.Point(126, 233);
            this.URL_txt.Name = "URL_txt";
            this.URL_txt.Size = new System.Drawing.Size(100, 20);
            this.URL_txt.TabIndex = 18;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "MM/dd/yyy hh:mm tt";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(126, 271);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartTimePicker.TabIndex = 19;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "MM/dd/yyy hh:mm tt";
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(126, 304);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndTimePicker.TabIndex = 20;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 452);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.URL_txt);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.Contact_txt);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.Description_txt);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.Customer_CB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Customer_CB;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox Description_txt;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.TextBox Contact_txt;
        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.TextBox URL_txt;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
    }
}