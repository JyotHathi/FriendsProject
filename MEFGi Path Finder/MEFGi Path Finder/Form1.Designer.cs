namespace MEFGi_Path_Finder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lower = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Upper = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Panel();
            this.SideC = new System.Windows.Forms.Panel();
            this.lmarker1 = new MEFGi_Path_Finder.Lmarker();
            this.bookmarks1 = new MEFGi_Path_Finder.Bookmarks();
            this.rplaces1 = new MEFGi_Path_Finder.Rplaces();
            this.mView1 = new MEFGi_Path_Finder.MView();
            this.notification1 = new MEFGi_Path_Finder.Notification();
            this.changePass1 = new MEFGi_Path_Finder.ChangePass();
            this.aLocation1 = new MEFGi_Path_Finder.ALocation();
            this.Side = new System.Windows.Forms.Panel();
            this.Indicator = new System.Windows.Forms.Panel();
            this.Sop7 = new System.Windows.Forms.Button();
            this.Sop1 = new System.Windows.Forms.Button();
            this.Sop6 = new System.Windows.Forms.Button();
            this.Sop2 = new System.Windows.Forms.Button();
            this.Sop5 = new System.Windows.Forms.Button();
            this.Sop3 = new System.Windows.Forms.Button();
            this.Sop4 = new System.Windows.Forms.Button();
            this.Lower.SuspendLayout();
            this.Upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Back.SuspendLayout();
            this.SideC.SuspendLayout();
            this.Side.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lower
            // 
            this.Lower.BackColor = System.Drawing.Color.DarkCyan;
            this.Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lower.Controls.Add(this.label1);
            this.Lower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lower.Location = new System.Drawing.Point(0, 693);
            this.Lower.Name = "Lower";
            this.Lower.Size = new System.Drawing.Size(1136, 26);
            this.Lower.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(376, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Knowledge is Currency of  21st Century";
            // 
            // Upper
            // 
            this.Upper.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Upper.Controls.Add(this.pictureBox2);
            this.Upper.Controls.Add(this.pictureBox1);
            this.Upper.Controls.Add(this.Logout);
            this.Upper.Controls.Add(this.User);
            this.Upper.Controls.Add(this.label4);
            this.Upper.Controls.Add(this.label2);
            this.Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.Upper.Location = new System.Drawing.Point(0, 0);
            this.Upper.Name = "Upper";
            this.Upper.Size = new System.Drawing.Size(1136, 215);
            this.Upper.TabIndex = 11;
            this.Upper.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MEFGi_Path_Finder.Properties.Resources.Sidei1;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MEFGi_Path_Finder.Properties.Resources.Sidei2;
            this.pictureBox1.Location = new System.Drawing.Point(988, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Blue;
            this.Logout.Location = new System.Drawing.Point(1046, 180);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(90, 35);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.User.Location = new System.Drawing.Point(3, 186);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(64, 29);
            this.User.TabIndex = 8;
            this.User.Text = "User";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(368, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Knowledge Is A Currency Of  21st Century";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marwadi University";
            // 
            // Back
            // 
            this.Back.Controls.Add(this.SideC);
            this.Back.Controls.Add(this.Side);
            this.Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Back.Location = new System.Drawing.Point(0, 215);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(1136, 478);
            this.Back.TabIndex = 2;
            // 
            // SideC
            // 
            this.SideC.Controls.Add(this.lmarker1);
            this.SideC.Controls.Add(this.bookmarks1);
            this.SideC.Controls.Add(this.rplaces1);
            this.SideC.Controls.Add(this.mView1);
            this.SideC.Controls.Add(this.notification1);
            this.SideC.Controls.Add(this.changePass1);
            this.SideC.Controls.Add(this.aLocation1);
            this.SideC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideC.Location = new System.Drawing.Point(319, 0);
            this.SideC.Name = "SideC";
            this.SideC.Size = new System.Drawing.Size(817, 478);
            this.SideC.TabIndex = 4;
            // 
            // lmarker1
            // 
            this.lmarker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lmarker1.Location = new System.Drawing.Point(0, 0);
            this.lmarker1.Name = "lmarker1";
            this.lmarker1.Size = new System.Drawing.Size(817, 478);
            this.lmarker1.TabIndex = 6;
            // 
            // bookmarks1
            // 
            this.bookmarks1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookmarks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarks1.Location = new System.Drawing.Point(0, 0);
            this.bookmarks1.Name = "bookmarks1";
            this.bookmarks1.Size = new System.Drawing.Size(817, 478);
            this.bookmarks1.TabIndex = 5;
            // 
            // rplaces1
            // 
            this.rplaces1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rplaces1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rplaces1.Location = new System.Drawing.Point(0, 0);
            this.rplaces1.Name = "rplaces1";
            this.rplaces1.Size = new System.Drawing.Size(817, 478);
            this.rplaces1.TabIndex = 4;
            // 
            // mView1
            // 
            this.mView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mView1.Location = new System.Drawing.Point(0, 0);
            this.mView1.Name = "mView1";
            this.mView1.Size = new System.Drawing.Size(817, 478);
            this.mView1.TabIndex = 3;
            // 
            // notification1
            // 
            this.notification1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.notification1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification1.Location = new System.Drawing.Point(0, 0);
            this.notification1.Name = "notification1";
            this.notification1.Size = new System.Drawing.Size(817, 478);
            this.notification1.TabIndex = 2;
            // 
            // changePass1
            // 
            this.changePass1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.changePass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changePass1.Location = new System.Drawing.Point(0, 0);
            this.changePass1.Name = "changePass1";
            this.changePass1.Size = new System.Drawing.Size(817, 478);
            this.changePass1.TabIndex = 1;
            // 
            // aLocation1
            // 
            this.aLocation1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aLocation1.Location = new System.Drawing.Point(0, 0);
            this.aLocation1.Name = "aLocation1";
            this.aLocation1.Size = new System.Drawing.Size(817, 478);
            this.aLocation1.TabIndex = 0;
            // 
            // Side
            // 
            this.Side.AutoScroll = true;
            this.Side.AutoScrollMinSize = new System.Drawing.Size(200, 380);
            this.Side.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Side.Controls.Add(this.Indicator);
            this.Side.Controls.Add(this.Sop7);
            this.Side.Controls.Add(this.Sop1);
            this.Side.Controls.Add(this.Sop6);
            this.Side.Controls.Add(this.Sop2);
            this.Side.Controls.Add(this.Sop5);
            this.Side.Controls.Add(this.Sop3);
            this.Side.Controls.Add(this.Sop4);
            this.Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side.Location = new System.Drawing.Point(0, 0);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(319, 478);
            this.Side.TabIndex = 3;
            // 
            // Indicator
            // 
            this.Indicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Indicator.Location = new System.Drawing.Point(28, 57);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(263, 10);
            this.Indicator.TabIndex = 1111;
            // 
            // Sop7
            // 
            this.Sop7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop7.ForeColor = System.Drawing.Color.Blue;
            this.Sop7.Location = new System.Drawing.Point(28, 416);
            this.Sop7.Name = "Sop7";
            this.Sop7.Padding = new System.Windows.Forms.Padding(2);
            this.Sop7.Size = new System.Drawing.Size(266, 42);
            this.Sop7.TabIndex = 7;
            this.Sop7.Text = "Change Password";
            this.Sop7.UseVisualStyleBackColor = false;
            this.Sop7.Click += new System.EventHandler(this.Sop7_Click);
            // 
            // Sop1
            // 
            this.Sop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop1.ForeColor = System.Drawing.Color.Blue;
            this.Sop1.Location = new System.Drawing.Point(28, 12);
            this.Sop1.Name = "Sop1";
            this.Sop1.Padding = new System.Windows.Forms.Padding(2);
            this.Sop1.Size = new System.Drawing.Size(266, 42);
            this.Sop1.TabIndex = 1;
            this.Sop1.Text = "All MEFGI Location";
            this.Sop1.UseVisualStyleBackColor = false;
            this.Sop1.Click += new System.EventHandler(this.Sop1_Click);
            // 
            // Sop6
            // 
            this.Sop6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop6.ForeColor = System.Drawing.Color.Blue;
            this.Sop6.Location = new System.Drawing.Point(28, 352);
            this.Sop6.Name = "Sop6";
            this.Sop6.Padding = new System.Windows.Forms.Padding(2);
            this.Sop6.Size = new System.Drawing.Size(266, 42);
            this.Sop6.TabIndex = 6;
            this.Sop6.Text = "Notification";
            this.Sop6.UseVisualStyleBackColor = false;
            this.Sop6.Click += new System.EventHandler(this.Sop6_Click);
            // 
            // Sop2
            // 
            this.Sop2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop2.ForeColor = System.Drawing.Color.Blue;
            this.Sop2.Location = new System.Drawing.Point(28, 79);
            this.Sop2.Name = "Sop2";
            this.Sop2.Padding = new System.Windows.Forms.Padding(2);
            this.Sop2.Size = new System.Drawing.Size(266, 42);
            this.Sop2.TabIndex = 2;
            this.Sop2.Text = "Most Visted Places";
            this.Sop2.UseVisualStyleBackColor = false;
            this.Sop2.Click += new System.EventHandler(this.Sop2_Click);
            // 
            // Sop5
            // 
            this.Sop5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop5.ForeColor = System.Drawing.Color.Blue;
            this.Sop5.Location = new System.Drawing.Point(28, 282);
            this.Sop5.Name = "Sop5";
            this.Sop5.Padding = new System.Windows.Forms.Padding(2);
            this.Sop5.Size = new System.Drawing.Size(266, 42);
            this.Sop5.TabIndex = 5;
            this.Sop5.Text = "Bookmarks";
            this.Sop5.UseVisualStyleBackColor = false;
            this.Sop5.Click += new System.EventHandler(this.Sop5_Click);
            // 
            // Sop3
            // 
            this.Sop3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop3.ForeColor = System.Drawing.Color.Blue;
            this.Sop3.Location = new System.Drawing.Point(28, 147);
            this.Sop3.Name = "Sop3";
            this.Sop3.Padding = new System.Windows.Forms.Padding(2);
            this.Sop3.Size = new System.Drawing.Size(266, 42);
            this.Sop3.TabIndex = 3;
            this.Sop3.Text = "Location Marker";
            this.Sop3.UseVisualStyleBackColor = false;
            this.Sop3.Click += new System.EventHandler(this.Sop3_Click);
            // 
            // Sop4
            // 
            this.Sop4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Sop4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sop4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sop4.ForeColor = System.Drawing.Color.Blue;
            this.Sop4.Location = new System.Drawing.Point(28, 214);
            this.Sop4.Name = "Sop4";
            this.Sop4.Padding = new System.Windows.Forms.Padding(2);
            this.Sop4.Size = new System.Drawing.Size(266, 42);
            this.Sop4.TabIndex = 4;
            this.Sop4.Text = "Recent places";
            this.Sop4.UseVisualStyleBackColor = false;
            this.Sop4.Click += new System.EventHandler(this.Sop4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.Logout;
            this.ClientSize = new System.Drawing.Size(1136, 719);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Upper);
            this.Controls.Add(this.Lower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MEFGI Path Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Lower.ResumeLayout(false);
            this.Lower.PerformLayout();
            this.Upper.ResumeLayout(false);
            this.Upper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Back.ResumeLayout(false);
            this.SideC.ResumeLayout(false);
            this.Side.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Lower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Upper;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Panel Side;
        private System.Windows.Forms.Button Sop7;
        private System.Windows.Forms.Button Sop1;
        private System.Windows.Forms.Button Sop6;
        private System.Windows.Forms.Button Sop2;
        private System.Windows.Forms.Button Sop5;
        private System.Windows.Forms.Button Sop3;
        private System.Windows.Forms.Button Sop4;
        private System.Windows.Forms.Panel SideC;
        private System.Windows.Forms.Panel Indicator;
        private MView mView1;
        private Notification notification1;
        private ChangePass changePass1;
        private ALocation aLocation1;
        private Rplaces rplaces1;
        private Bookmarks bookmarks1;
        private Lmarker lmarker1;
    }
}

