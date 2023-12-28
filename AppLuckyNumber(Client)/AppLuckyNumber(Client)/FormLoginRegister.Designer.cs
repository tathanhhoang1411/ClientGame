namespace AppLuckyNumber_Client_
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtr1 = new System.Windows.Forms.TabControl();
            this.tabDN = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.tabDK = new System.Windows.Forms.TabPage();
            this.dtPicNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.txtPasswordDK = new System.Windows.Forms.TextBox();
            this.txtAccountDK = new System.Windows.Forms.TextBox();
            this.txtHVT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabCtr1.SuspendLayout();
            this.tabDN.SuspendLayout();
            this.tabDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xổ Số Con Gà Trống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabCtr1
            // 
            this.tabCtr1.Controls.Add(this.tabDN);
            this.tabCtr1.Controls.Add(this.tabDK);
            this.tabCtr1.Location = new System.Drawing.Point(77, 69);
            this.tabCtr1.Name = "tabCtr1";
            this.tabCtr1.SelectedIndex = 0;
            this.tabCtr1.Size = new System.Drawing.Size(325, 423);
            this.tabCtr1.TabIndex = 1;
            // 
            // tabDN
            // 
            this.tabDN.Controls.Add(this.lblStatus);
            this.tabDN.Controls.Add(this.label5);
            this.tabDN.Controls.Add(this.btnDN);
            this.tabDN.Controls.Add(this.txtAccount);
            this.tabDN.Controls.Add(this.label2);
            this.tabDN.Controls.Add(this.label3);
            this.tabDN.Controls.Add(this.txtPassWord);
            this.tabDN.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabDN.Location = new System.Drawing.Point(4, 25);
            this.tabDN.Name = "tabDN";
            this.tabDN.Padding = new System.Windows.Forms.Padding(3);
            this.tabDN.Size = new System.Drawing.Size(317, 394);
            this.tabDN.TabIndex = 0;
            this.tabDN.Text = "Đăng Nhập";
            this.tabDN.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(79, 274);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(175, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Sai Thông tin đăng nhập";
            this.lblStatus.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(195, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quên mật khẩu?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnDN
            // 
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.Location = new System.Drawing.Point(82, 327);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(135, 61);
            this.btnDN.TabIndex = 6;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(14, 109);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(284, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tài khoản (SDT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu ";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(14, 204);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(284, 22);
            this.txtPassWord.TabIndex = 2;
            // 
            // tabDK
            // 
            this.tabDK.Controls.Add(this.dtPicNgaySinh);
            this.tabDK.Controls.Add(this.label8);
            this.tabDK.Controls.Add(this.label7);
            this.tabDK.Controls.Add(this.label6);
            this.tabDK.Controls.Add(this.label4);
            this.tabDK.Controls.Add(this.btnDK);
            this.tabDK.Controls.Add(this.txtPasswordDK);
            this.tabDK.Controls.Add(this.txtAccountDK);
            this.tabDK.Controls.Add(this.txtHVT);
            this.tabDK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabDK.Location = new System.Drawing.Point(4, 25);
            this.tabDK.Name = "tabDK";
            this.tabDK.Padding = new System.Windows.Forms.Padding(3);
            this.tabDK.Size = new System.Drawing.Size(317, 394);
            this.tabDK.TabIndex = 1;
            this.tabDK.Text = "Đăng Kí";
            // 
            // dtPicNgaySinh
            // 
            this.dtPicNgaySinh.Location = new System.Drawing.Point(28, 258);
            this.dtPicNgaySinh.Name = "dtPicNgaySinh";
            this.dtPicNgaySinh.Size = new System.Drawing.Size(256, 22);
            this.dtPicNgaySinh.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 31);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày tháng năm sinh( dd-mm-YYYY)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tài khoản (SDT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Họ và Tên";
            // 
            // btnDK
            // 
            this.btnDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Location = new System.Drawing.Point(78, 327);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(135, 61);
            this.btnDK.TabIndex = 7;
            this.btnDK.Text = "Đăng Ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtPasswordDK
            // 
            this.txtPasswordDK.Location = new System.Drawing.Point(17, 193);
            this.txtPasswordDK.Name = "txtPasswordDK";
            this.txtPasswordDK.Size = new System.Drawing.Size(284, 22);
            this.txtPasswordDK.TabIndex = 4;
            // 
            // txtAccountDK
            // 
            this.txtAccountDK.Location = new System.Drawing.Point(17, 119);
            this.txtAccountDK.Name = "txtAccountDK";
            this.txtAccountDK.Size = new System.Drawing.Size(284, 22);
            this.txtAccountDK.TabIndex = 3;
            // 
            // txtHVT
            // 
            this.txtHVT.Location = new System.Drawing.Point(17, 51);
            this.txtHVT.Name = "txtHVT";
            this.txtHVT.Size = new System.Drawing.Size(284, 22);
            this.txtHVT.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label11.Location = new System.Drawing.Point(193, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "By: tathanhhoang.work@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(476, 552);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tabCtr1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ĐĂNG NHẬP/ĐĂNG KÝ XỔ SỐ CON GÀ TRỐNG";
            this.tabCtr1.ResumeLayout(false);
            this.tabDN.ResumeLayout(false);
            this.tabDN.PerformLayout();
            this.tabDK.ResumeLayout(false);
            this.tabDK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCtr1;
        private System.Windows.Forms.TabPage tabDN;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TabPage tabDK;
        private System.Windows.Forms.TextBox txtPasswordDK;
        private System.Windows.Forms.TextBox txtAccountDK;
        private System.Windows.Forms.TextBox txtHVT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dtPicNgaySinh;
    }
}

