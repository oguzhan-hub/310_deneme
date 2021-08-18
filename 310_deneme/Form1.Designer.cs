
namespace _310_deneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginWarning = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoginNickName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControlRegister = new System.Windows.Forms.TabControl();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.btnNextLogin = new System.Windows.Forms.Button();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterWarningLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterNick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNickName = new System.Windows.Forms.Label();
            this.tabUserInfo = new System.Windows.Forms.TabPage();
            this.btnNextUser = new System.Windows.Forms.Button();
            this.lblRegisterWarningUser = new System.Windows.Forms.Label();
            this.txtRegisterAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegisterLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegisterFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabApprove = new System.Windows.Forms.TabPage();
            this.lblRegisterResult = new System.Windows.Forms.Label();
            this.btnSubmitRegister = new System.Windows.Forms.Button();
            this.groupLogin.SuspendLayout();
            this.tabControlRegister.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            this.tabUserInfo.SuspendLayout();
            this.tabApprove.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLogin
            // 
            this.groupLogin.Controls.Add(this.lblLoginWarning);
            this.groupLogin.Controls.Add(this.btnRegister);
            this.groupLogin.Controls.Add(this.btnLogin);
            this.groupLogin.Controls.Add(this.txtLoginPassword);
            this.groupLogin.Controls.Add(this.label10);
            this.groupLogin.Controls.Add(this.txtLoginNickName);
            this.groupLogin.Controls.Add(this.label11);
            this.groupLogin.Location = new System.Drawing.Point(426, 132);
            this.groupLogin.Name = "groupLogin";
            this.groupLogin.Size = new System.Drawing.Size(346, 259);
            this.groupLogin.TabIndex = 5;
            this.groupLogin.TabStop = false;
            this.groupLogin.Text = "Login";
            // 
            // lblLoginWarning
            // 
            this.lblLoginWarning.AutoSize = true;
            this.lblLoginWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginWarning.Location = new System.Drawing.Point(41, 188);
            this.lblLoginWarning.MaximumSize = new System.Drawing.Size(260, 50);
            this.lblLoginWarning.MinimumSize = new System.Drawing.Size(260, 50);
            this.lblLoginWarning.Name = "lblLoginWarning";
            this.lblLoginWarning.Size = new System.Drawing.Size(260, 50);
            this.lblLoginWarning.TabIndex = 13;
            this.lblLoginWarning.Text = "Warning area";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(146, 141);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 31);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(239, 141);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(122, 91);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(192, 23);
            this.txtLoginPassword.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password :";
            // 
            // txtLoginNickName
            // 
            this.txtLoginNickName.Location = new System.Drawing.Point(122, 50);
            this.txtLoginNickName.Name = "txtLoginNickName";
            this.txtLoginNickName.Size = new System.Drawing.Size(192, 23);
            this.txtLoginNickName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Nick Name :";
            // 
            // tabControlRegister
            // 
            this.tabControlRegister.Controls.Add(this.tabLoginInfo);
            this.tabControlRegister.Controls.Add(this.tabUserInfo);
            this.tabControlRegister.Controls.Add(this.tabApprove);
            this.tabControlRegister.Location = new System.Drawing.Point(28, 119);
            this.tabControlRegister.Name = "tabControlRegister";
            this.tabControlRegister.SelectedIndex = 0;
            this.tabControlRegister.Size = new System.Drawing.Size(381, 272);
            this.tabControlRegister.TabIndex = 4;
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.btnNextLogin);
            this.tabLoginInfo.Controls.Add(this.txtRegisterEmail);
            this.tabLoginInfo.Controls.Add(this.lblRegisterWarningLogin);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.txtRegisterPassword);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.txtRegisterNick);
            this.tabLoginInfo.Controls.Add(this.label5);
            this.tabLoginInfo.Controls.Add(this.lblNickName);
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 24);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(373, 244);
            this.tabLoginInfo.TabIndex = 0;
            this.tabLoginInfo.Text = "Login Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextLogin
            // 
            this.btnNextLogin.Location = new System.Drawing.Point(251, 186);
            this.btnNextLogin.Name = "btnNextLogin";
            this.btnNextLogin.Size = new System.Drawing.Size(75, 31);
            this.btnNextLogin.TabIndex = 2;
            this.btnNextLogin.Text = "Next";
            this.btnNextLogin.UseVisualStyleBackColor = true;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(134, 131);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterEmail.TabIndex = 1;
            // 
            // lblRegisterWarningLogin
            // 
            this.lblRegisterWarningLogin.AutoSize = true;
            this.lblRegisterWarningLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterWarningLogin.Location = new System.Drawing.Point(27, 170);
            this.lblRegisterWarningLogin.MaximumSize = new System.Drawing.Size(220, 50);
            this.lblRegisterWarningLogin.MinimumSize = new System.Drawing.Size(220, 50);
            this.lblRegisterWarningLogin.Name = "lblRegisterWarningLogin";
            this.lblRegisterWarningLogin.Size = new System.Drawing.Size(220, 50);
            this.lblRegisterWarningLogin.TabIndex = 0;
            this.lblRegisterWarningLogin.Text = "warning message will be displayed here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail :";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(134, 93);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // txtRegisterNick
            // 
            this.txtRegisterNick.Location = new System.Drawing.Point(134, 52);
            this.txtRegisterNick.Name = "txtRegisterNick";
            this.txtRegisterNick.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterNick.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nick and e-mail should be unique";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNickName.Location = new System.Drawing.Point(27, 54);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(93, 20);
            this.lblNickName.TabIndex = 0;
            this.lblNickName.Text = "Nick Name :";
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.Controls.Add(this.btnNextUser);
            this.tabUserInfo.Controls.Add(this.lblRegisterWarningUser);
            this.tabUserInfo.Controls.Add(this.txtRegisterAge);
            this.tabUserInfo.Controls.Add(this.label6);
            this.tabUserInfo.Controls.Add(this.txtRegisterLastName);
            this.tabUserInfo.Controls.Add(this.label7);
            this.tabUserInfo.Controls.Add(this.txtRegisterFirstName);
            this.tabUserInfo.Controls.Add(this.label8);
            this.tabUserInfo.Location = new System.Drawing.Point(4, 24);
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserInfo.Size = new System.Drawing.Size(373, 244);
            this.tabUserInfo.TabIndex = 1;
            this.tabUserInfo.Text = "UserInfo";
            this.tabUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextUser
            // 
            this.btnNextUser.Location = new System.Drawing.Point(245, 186);
            this.btnNextUser.Name = "btnNextUser";
            this.btnNextUser.Size = new System.Drawing.Size(75, 31);
            this.btnNextUser.TabIndex = 9;
            this.btnNextUser.Text = "Next";
            this.btnNextUser.UseVisualStyleBackColor = true;
            // 
            // lblRegisterWarningUser
            // 
            this.lblRegisterWarningUser.AutoSize = true;
            this.lblRegisterWarningUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterWarningUser.Location = new System.Drawing.Point(28, 180);
            this.lblRegisterWarningUser.MaximumSize = new System.Drawing.Size(200, 50);
            this.lblRegisterWarningUser.MinimumSize = new System.Drawing.Size(200, 50);
            this.lblRegisterWarningUser.Name = "lblRegisterWarningUser";
            this.lblRegisterWarningUser.Size = new System.Drawing.Size(200, 50);
            this.lblRegisterWarningUser.TabIndex = 8;
            this.lblRegisterWarningUser.Text = "Warning area";
            // 
            // txtRegisterAge
            // 
            this.txtRegisterAge.Location = new System.Drawing.Point(128, 121);
            this.txtRegisterAge.Name = "txtRegisterAge";
            this.txtRegisterAge.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterAge.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Age :";
            // 
            // txtRegisterLastName
            // 
            this.txtRegisterLastName.Location = new System.Drawing.Point(128, 83);
            this.txtRegisterLastName.Name = "txtRegisterLastName";
            this.txtRegisterLastName.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterLastName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Name :";
            // 
            // txtRegisterFirstName
            // 
            this.txtRegisterFirstName.Location = new System.Drawing.Point(128, 42);
            this.txtRegisterFirstName.Name = "txtRegisterFirstName";
            this.txtRegisterFirstName.Size = new System.Drawing.Size(192, 23);
            this.txtRegisterFirstName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "First Name :";
            // 
            // tabApprove
            // 
            this.tabApprove.Controls.Add(this.lblRegisterResult);
            this.tabApprove.Controls.Add(this.btnSubmitRegister);
            this.tabApprove.Location = new System.Drawing.Point(4, 24);
            this.tabApprove.Name = "tabApprove";
            this.tabApprove.Padding = new System.Windows.Forms.Padding(3);
            this.tabApprove.Size = new System.Drawing.Size(373, 244);
            this.tabApprove.TabIndex = 2;
            this.tabApprove.Text = "Approve";
            this.tabApprove.UseVisualStyleBackColor = true;
            // 
            // lblRegisterResult
            // 
            this.lblRegisterResult.AutoSize = true;
            this.lblRegisterResult.Location = new System.Drawing.Point(35, 42);
            this.lblRegisterResult.Name = "lblRegisterResult";
            this.lblRegisterResult.Size = new System.Drawing.Size(148, 15);
            this.lblRegisterResult.TabIndex = 11;
            this.lblRegisterResult.Text = "Results will be shown here!";
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.Location = new System.Drawing.Point(253, 177);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(75, 31);
            this.btnSubmitRegister.TabIndex = 10;
            this.btnSubmitRegister.Text = "Submit";
            this.btnSubmitRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupLogin);
            this.Controls.Add(this.tabControlRegister);
            this.Name = "Form1";
            this.Text = "s";
            this.groupLogin.ResumeLayout(false);
            this.groupLogin.PerformLayout();
            this.tabControlRegister.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            this.tabUserInfo.ResumeLayout(false);
            this.tabUserInfo.PerformLayout();
            this.tabApprove.ResumeLayout(false);
            this.tabApprove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLogin;
        private System.Windows.Forms.Label lblLoginWarning;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoginNickName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControlRegister;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.Button btnNextLogin;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblRegisterWarningLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterNick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TabPage tabUserInfo;
        private System.Windows.Forms.Button btnNextUser;
        private System.Windows.Forms.Label lblRegisterWarningUser;
        private System.Windows.Forms.TextBox txtRegisterAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegisterLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegisterFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabApprove;
        private System.Windows.Forms.Label lblRegisterResult;
        private System.Windows.Forms.Button btnSubmitRegister;
    }
}

