namespace MEFGi_Path_Finder
{
    partial class Sign_Up
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendB = new System.Windows.Forms.Button();
            this.otp = new System.Windows.Forms.TextBox();
            this.Mno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Invalid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Resend = new System.Windows.Forms.LinkLabel();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendB
            // 
            this.SendB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SendB.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SendB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendB.Location = new System.Drawing.Point(182, 235);
            this.SendB.Name = "SendB";
            this.SendB.Size = new System.Drawing.Size(120, 35);
            this.SendB.TabIndex = 4;
            this.SendB.Text = "Send";
            this.SendB.UseVisualStyleBackColor = false;
            this.SendB.Click += new System.EventHandler(this.SendB_Click);
            // 
            // otp
            // 
            this.otp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.otp.Location = new System.Drawing.Point(199, 275);
            this.otp.Name = "otp";
            this.otp.PasswordChar = '*';
            this.otp.Size = new System.Drawing.Size(220, 22);
            this.otp.TabIndex = 5;
            // 
            // Mno
            // 
            this.Mno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Mno.Location = new System.Drawing.Point(270, 106);
            this.Mno.Name = "Mno";
            this.Mno.Size = new System.Drawing.Size(220, 22);
            this.Mno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(111, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "OTP";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(22, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(155, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sign Up";
            // 
            // Invalid
            // 
            this.Invalid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Invalid.AutoSize = true;
            this.Invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(91, 309);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(70, 25);
            this.Invalid.TabIndex = 4;
            this.Invalid.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Resend
            // 
            this.Resend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Resend.AutoSize = true;
            this.Resend.Location = new System.Drawing.Point(283, 316);
            this.Resend.Name = "Resend";
            this.Resend.Size = new System.Drawing.Size(57, 17);
            this.Resend.TabIndex = 5;
            this.Resend.TabStop = true;
            this.Resend.Text = "Resend";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Password.Location = new System.Drawing.Point(270, 193);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(220, 22);
            this.Password.TabIndex = 3;
            // 
            // UserID
            // 
            this.UserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserID.Location = new System.Drawing.Point(270, 152);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(220, 22);
            this.UserID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(22, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Password ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(22, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "UserId ";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resend);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.SendB);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.Mno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Sign_Up";
            this.Size = new System.Drawing.Size(521, 399);
            this.Load += new System.EventHandler(this.Sign_Up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendB;
        private System.Windows.Forms.TextBox otp;
        private System.Windows.Forms.TextBox Mno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Invalid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel Resend;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
