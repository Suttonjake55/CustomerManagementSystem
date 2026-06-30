namespace JacobSutton_C989
{
    partial class LoginForm
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.LoginUN_lbl = new System.Windows.Forms.Label();
            this.LoginPW_lbl = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.UN_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.Error_lbl = new System.Windows.Forms.Label();
            this.Location_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(69, 186);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(13, 13);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(48, 20);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // LoginUN_lbl
            // 
            this.LoginUN_lbl.AutoSize = true;
            this.LoginUN_lbl.Location = new System.Drawing.Point(34, 89);
            this.LoginUN_lbl.Name = "LoginUN_lbl";
            this.LoginUN_lbl.Size = new System.Drawing.Size(55, 13);
            this.LoginUN_lbl.TabIndex = 2;
            this.LoginUN_lbl.Text = "Username";
            // 
            // LoginPW_lbl
            // 
            this.LoginPW_lbl.AutoSize = true;
            this.LoginPW_lbl.Location = new System.Drawing.Point(34, 133);
            this.LoginPW_lbl.Name = "LoginPW_lbl";
            this.LoginPW_lbl.Size = new System.Drawing.Size(53, 13);
            this.LoginPW_lbl.TabIndex = 3;
            this.LoginPW_lbl.Text = "Password";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(161, 186);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 4;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // UN_txt
            // 
            this.UN_txt.Location = new System.Drawing.Point(125, 89);
            this.UN_txt.Name = "UN_txt";
            this.UN_txt.Size = new System.Drawing.Size(100, 20);
            this.UN_txt.TabIndex = 5;
            // 
            // PW_txt
            // 
            this.PW_txt.Location = new System.Drawing.Point(125, 133);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.Size = new System.Drawing.Size(100, 20);
            this.PW_txt.TabIndex = 6;
            this.PW_txt.UseSystemPasswordChar = true;
            // 
            // Error_lbl
            // 
            this.Error_lbl.AutoSize = true;
            this.Error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_lbl.ForeColor = System.Drawing.Color.Red;
            this.Error_lbl.Location = new System.Drawing.Point(132, 156);
            this.Error_lbl.Name = "Error_lbl";
            this.Error_lbl.Size = new System.Drawing.Size(0, 13);
            this.Error_lbl.TabIndex = 7;
            // 
            // Location_lbl
            // 
            this.Location_lbl.AutoSize = true;
            this.Location_lbl.Location = new System.Drawing.Point(34, 52);
            this.Location_lbl.Name = "Location_lbl";
            this.Location_lbl.Size = new System.Drawing.Size(48, 13);
            this.Location_lbl.TabIndex = 8;
            this.Location_lbl.Text = "Location";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 329);
            this.Controls.Add(this.Location_lbl);
            this.Controls.Add(this.Error_lbl);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.UN_txt);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.LoginPW_lbl);
            this.Controls.Add(this.LoginUN_lbl);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Login_btn);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label LoginUN_lbl;
        private System.Windows.Forms.Label LoginPW_lbl;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.TextBox UN_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.Label Error_lbl;
        private System.Windows.Forms.Label Location_lbl;
    }
}

