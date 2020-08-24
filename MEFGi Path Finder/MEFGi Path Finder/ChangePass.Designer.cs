namespace MEFGi_Path_Finder
{
    partial class ChangePass
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
            this.changepa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SeSu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resend = new System.Windows.Forms.LinkLabel();
            this.Invalid = new System.Windows.Forms.Label();
            this.Mno = new System.Windows.Forms.TextBox();
            this.Cpass = new System.Windows.Forms.TextBox();
            this.otp = new System.Windows.Forms.TextBox();
            this.Npass = new System.Windows.Forms.TextBox();
            this.Rpass = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // changepa
            // 
            this.changepa.AutoSize = true;
            this.changepa.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepa.ForeColor = System.Drawing.Color.Blue;
            this.changepa.Location = new System.Drawing.Point(3, 18);
            this.changepa.Name = "changepa";
            this.changepa.Size = new System.Drawing.Size(434, 55);
            this.changepa.TabIndex = 0;
            this.changepa.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(119, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(119, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(293, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "OTP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(119, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(119, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Retype Password";
            // 
            // SeSu
            // 
            this.SeSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SeSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeSu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SeSu.Location = new System.Drawing.Point(381, 423);
            this.SeSu.Name = "SeSu";
            this.SeSu.Size = new System.Drawing.Size(125, 39);
            this.SeSu.TabIndex = 3;
            this.SeSu.Text = "Send";
            this.SeSu.UseVisualStyleBackColor = false;
            this.SeSu.Click += new System.EventHandler(this.SeSu_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(700, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 0;
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // resend
            // 
            this.resend.AutoSize = true;
            this.resend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resend.Location = new System.Drawing.Point(703, 279);
            this.resend.Name = "resend";
            this.resend.Size = new System.Drawing.Size(76, 24);
            this.resend.TabIndex = 2;
            this.resend.TabStop = true;
            this.resend.Text = "Resend";
            // 
            // Invalid
            // 
            this.Invalid.AutoSize = true;
            this.Invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invalid.ForeColor = System.Drawing.Color.Red;
            this.Invalid.Location = new System.Drawing.Point(394, 91);
            this.Invalid.Name = "Invalid";
            this.Invalid.Size = new System.Drawing.Size(75, 36);
            this.Invalid.TabIndex = 0;
            this.Invalid.Text = "OTP";
            this.Invalid.Click += new System.EventHandler(this.label3_Click);
            // 
            // Mno
            // 
            this.Mno.Location = new System.Drawing.Point(437, 160);
            this.Mno.Name = "Mno";
            this.Mno.Size = new System.Drawing.Size(200, 22);
            this.Mno.TabIndex = 1;
            this.Mno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cpass
            // 
            this.Cpass.Location = new System.Drawing.Point(437, 211);
            this.Cpass.Name = "Cpass";
            this.Cpass.PasswordChar = '*';
            this.Cpass.Size = new System.Drawing.Size(200, 22);
            this.Cpass.TabIndex = 2;
            this.Cpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // otp
            // 
            this.otp.Location = new System.Drawing.Point(437, 276);
            this.otp.Name = "otp";
            this.otp.PasswordChar = '*';
            this.otp.Size = new System.Drawing.Size(200, 22);
            this.otp.TabIndex = 4;
            this.otp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Npass
            // 
            this.Npass.Location = new System.Drawing.Point(437, 324);
            this.Npass.Name = "Npass";
            this.Npass.PasswordChar = '*';
            this.Npass.Size = new System.Drawing.Size(200, 22);
            this.Npass.TabIndex = 5;
            this.Npass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rpass
            // 
            this.Rpass.Location = new System.Drawing.Point(437, 380);
            this.Rpass.Name = "Rpass";
            this.Rpass.PasswordChar = '*';
            this.Rpass.Size = new System.Drawing.Size(200, 22);
            this.Rpass.TabIndex = 6;
            this.Rpass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.Rpass);
            this.Controls.Add(this.Npass);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.Cpass);
            this.Controls.Add(this.Mno);
            this.Controls.Add(this.resend);
            this.Controls.Add(this.SeSu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Invalid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changepa);
            this.Name = "ChangePass";
            this.Size = new System.Drawing.Size(817, 478);
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changepa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SeSu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel resend;
        private System.Windows.Forms.Label Invalid;
        private System.Windows.Forms.TextBox Mno;
        private System.Windows.Forms.TextBox Cpass;
        private System.Windows.Forms.TextBox otp;
        private System.Windows.Forms.TextBox Npass;
        private System.Windows.Forms.TextBox Rpass;
        private System.Windows.Forms.Timer timer1;
    }
}
