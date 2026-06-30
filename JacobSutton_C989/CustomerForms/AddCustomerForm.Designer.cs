namespace JacobSutton_C989.CustomerForms
{
    partial class AddCustomerForm
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
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Address1_txt = new System.Windows.Forms.TextBox();
            this.Address2_txt = new System.Windows.Forms.TextBox();
            this.PostalCode_txt = new System.Windows.Forms.TextBox();
            this.Country_txt = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.City_cb = new System.Windows.Forms.ComboBox();
            this.PhoneNum_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(163, 57);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(100, 20);
            this.Name_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Postal Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Country";
            // 
            // Address1_txt
            // 
            this.Address1_txt.Location = new System.Drawing.Point(163, 134);
            this.Address1_txt.Name = "Address1_txt";
            this.Address1_txt.Size = new System.Drawing.Size(100, 20);
            this.Address1_txt.TabIndex = 9;
            // 
            // Address2_txt
            // 
            this.Address2_txt.Location = new System.Drawing.Point(163, 178);
            this.Address2_txt.Name = "Address2_txt";
            this.Address2_txt.Size = new System.Drawing.Size(100, 20);
            this.Address2_txt.TabIndex = 10;
            // 
            // PostalCode_txt
            // 
            this.PostalCode_txt.Location = new System.Drawing.Point(163, 260);
            this.PostalCode_txt.Name = "PostalCode_txt";
            this.PostalCode_txt.Size = new System.Drawing.Size(100, 20);
            this.PostalCode_txt.TabIndex = 12;
            // 
            // Country_txt
            // 
            this.Country_txt.Location = new System.Drawing.Point(163, 298);
            this.Country_txt.Name = "Country_txt";
            this.Country_txt.Size = new System.Drawing.Size(100, 20);
            this.Country_txt.TabIndex = 13;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(117, 343);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 14;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(198, 343);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 15;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // City_cb
            // 
            this.City_cb.FormattingEnabled = true;
            this.City_cb.Location = new System.Drawing.Point(163, 220);
            this.City_cb.Name = "City_cb";
            this.City_cb.Size = new System.Drawing.Size(110, 21);
            this.City_cb.TabIndex = 16;
            // 
            // PhoneNum_txt
            // 
            this.PhoneNum_txt.Location = new System.Drawing.Point(163, 95);
            this.PhoneNum_txt.Name = "PhoneNum_txt";
            this.PhoneNum_txt.Size = new System.Drawing.Size(100, 20);
            this.PhoneNum_txt.TabIndex = 18;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 430);
            this.Controls.Add(this.PhoneNum_txt);
            this.Controls.Add(this.City_cb);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Country_txt);
            this.Controls.Add(this.PostalCode_txt);
            this.Controls.Add(this.Address2_txt);
            this.Controls.Add(this.Address1_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_txt);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Address1_txt;
        private System.Windows.Forms.TextBox Address2_txt;
        private System.Windows.Forms.TextBox PostalCode_txt;
        private System.Windows.Forms.TextBox Country_txt;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.ComboBox City_cb;
        private System.Windows.Forms.TextBox PhoneNum_txt;
    }
}