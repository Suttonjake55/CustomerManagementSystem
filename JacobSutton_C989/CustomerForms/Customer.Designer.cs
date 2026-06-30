namespace JacobSutton_C989
{
    partial class Customer
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
            this.Customer_data = new System.Windows.Forms.DataGridView();
            this.Add_Customer = new System.Windows.Forms.Button();
            this.Update_Customer = new System.Windows.Forms.Button();
            this.Delete_Customer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // Customer_data
            // 
            this.Customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_data.Location = new System.Drawing.Point(16, 55);
            this.Customer_data.Name = "Customer_data";
            this.Customer_data.ReadOnly = true;
            this.Customer_data.Size = new System.Drawing.Size(840, 340);
            this.Customer_data.TabIndex = 1;
            // 
            // Add_Customer
            // 
            this.Add_Customer.Location = new System.Drawing.Point(602, 414);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(70, 23);
            this.Add_Customer.TabIndex = 4;
            this.Add_Customer.Text = "Add";
            this.Add_Customer.UseVisualStyleBackColor = true;
            this.Add_Customer.Click += new System.EventHandler(this.Add_Customer_Click);
            // 
            // Update_Customer
            // 
            this.Update_Customer.Location = new System.Drawing.Point(678, 414);
            this.Update_Customer.Name = "Update_Customer";
            this.Update_Customer.Size = new System.Drawing.Size(75, 23);
            this.Update_Customer.TabIndex = 5;
            this.Update_Customer.Text = "Update";
            this.Update_Customer.UseVisualStyleBackColor = true;
            this.Update_Customer.Click += new System.EventHandler(this.Update_Customer_Click);
            // 
            // Delete_Customer
            // 
            this.Delete_Customer.Location = new System.Drawing.Point(759, 414);
            this.Delete_Customer.Name = "Delete_Customer";
            this.Delete_Customer.Size = new System.Drawing.Size(75, 23);
            this.Delete_Customer.TabIndex = 6;
            this.Delete_Customer.Text = "Delete";
            this.Delete_Customer.UseVisualStyleBackColor = true;
            this.Delete_Customer.Click += new System.EventHandler(this.Delete_Customer_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 592);
            this.Controls.Add(this.Delete_Customer);
            this.Controls.Add(this.Update_Customer);
            this.Controls.Add(this.Add_Customer);
            this.Controls.Add(this.Customer_data);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Customer_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Customer_data;
        private System.Windows.Forms.Button Add_Customer;
        private System.Windows.Forms.Button Update_Customer;
        private System.Windows.Forms.Button Delete_Customer;
    }
}