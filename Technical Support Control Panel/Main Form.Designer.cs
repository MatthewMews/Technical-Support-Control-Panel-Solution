namespace Main_Form
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.ISG_Picturebox = new System.Windows.Forms.PictureBox();
            this.office365exe_Button = new System.Windows.Forms.Button();
            this.System_Menu_Button = new System.Windows.Forms.Button();
            this.technical_support_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.Computer_Name_Button = new System.Windows.Forms.Button();
            this.Event_Viewer_Button = new System.Windows.Forms.Button();
            this.Call_Recordings_Button = new System.Windows.Forms.Button();
            this.Website_Links_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ISG_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // ISG_Picturebox
            // 
            this.ISG_Picturebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ISG_Picturebox.BackColor = System.Drawing.Color.White;
            this.ISG_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("ISG_Picturebox.Image")));
            this.ISG_Picturebox.Location = new System.Drawing.Point(0, 0);
            this.ISG_Picturebox.Name = "ISG_Picturebox";
            this.ISG_Picturebox.Size = new System.Drawing.Size(484, 106);
            this.ISG_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ISG_Picturebox.TabIndex = 0;
            this.ISG_Picturebox.TabStop = false;
            this.ISG_Picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Main_Header);
            // 
            // office365exe_Button
            // 
            this.office365exe_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.office365exe_Button.BackColor = System.Drawing.Color.White;
            this.office365exe_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.office365exe_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.office365exe_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.office365exe_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office365exe_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.office365exe_Button.Location = new System.Drawing.Point(110, 219);
            this.office365exe_Button.Name = "office365exe_Button";
            this.office365exe_Button.Size = new System.Drawing.Size(267, 31);
            this.office365exe_Button.TabIndex = 3;
            this.office365exe_Button.TabStop = false;
            this.office365exe_Button.Text = "Get Office Desktop Shortcuts";
            this.office365exe_Button.UseVisualStyleBackColor = false;
            this.office365exe_Button.Click += new System.EventHandler(this.Office_Shortcuts);
            // 
            // System_Menu_Button
            // 
            this.System_Menu_Button.BackColor = System.Drawing.Color.White;
            this.System_Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.System_Menu_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.System_Menu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.System_Menu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.System_Menu_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.System_Menu_Button.Location = new System.Drawing.Point(184, 512);
            this.System_Menu_Button.Name = "System_Menu_Button";
            this.System_Menu_Button.Size = new System.Drawing.Size(121, 45);
            this.System_Menu_Button.TabIndex = 4;
            this.System_Menu_Button.TabStop = false;
            this.System_Menu_Button.Text = "Control Panel";
            this.System_Menu_Button.UseVisualStyleBackColor = false;
            this.System_Menu_Button.Click += new System.EventHandler(this.Control_Panel_Button);
            // 
            // technical_support_label
            // 
            this.technical_support_label.AutoSize = true;
            this.technical_support_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.technical_support_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technical_support_label.ForeColor = System.Drawing.Color.White;
            this.technical_support_label.Location = new System.Drawing.Point(116, 127);
            this.technical_support_label.Name = "technical_support_label";
            this.technical_support_label.Size = new System.Drawing.Size(243, 17);
            this.technical_support_label.TabIndex = 5;
            this.technical_support_label.Text = "Technical Support Control Panel";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_label.ForeColor = System.Drawing.Color.White;
            this.version_label.Location = new System.Drawing.Point(12, 589);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(71, 13);
            this.version_label.TabIndex = 6;
            this.version_label.Text = "Version 1.3";
            // 
            // Computer_Name_Button
            // 
            this.Computer_Name_Button.BackColor = System.Drawing.Color.White;
            this.Computer_Name_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Computer_Name_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.Computer_Name_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Computer_Name_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computer_Name_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Computer_Name_Button.Location = new System.Drawing.Point(28, 512);
            this.Computer_Name_Button.Name = "Computer_Name_Button";
            this.Computer_Name_Button.Size = new System.Drawing.Size(121, 45);
            this.Computer_Name_Button.TabIndex = 7;
            this.Computer_Name_Button.TabStop = false;
            this.Computer_Name_Button.Text = "Computer Name";
            this.Computer_Name_Button.UseVisualStyleBackColor = false;
            this.Computer_Name_Button.Click += new System.EventHandler(this.Computer_Name_Button_Click);
            // 
            // Event_Viewer_Button
            // 
            this.Event_Viewer_Button.BackColor = System.Drawing.Color.White;
            this.Event_Viewer_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event_Viewer_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.Event_Viewer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event_Viewer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Viewer_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Event_Viewer_Button.Location = new System.Drawing.Point(338, 512);
            this.Event_Viewer_Button.Name = "Event_Viewer_Button";
            this.Event_Viewer_Button.Size = new System.Drawing.Size(121, 45);
            this.Event_Viewer_Button.TabIndex = 8;
            this.Event_Viewer_Button.TabStop = false;
            this.Event_Viewer_Button.Text = "Event Viewer";
            this.Event_Viewer_Button.UseVisualStyleBackColor = false;
            this.Event_Viewer_Button.Click += new System.EventHandler(this.Event_Viewer_Button_Click);
            // 
            // Call_Recordings_Button
            // 
            this.Call_Recordings_Button.BackColor = System.Drawing.Color.White;
            this.Call_Recordings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Call_Recordings_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.Call_Recordings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Call_Recordings_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Call_Recordings_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Call_Recordings_Button.Location = new System.Drawing.Point(110, 289);
            this.Call_Recordings_Button.Name = "Call_Recordings_Button";
            this.Call_Recordings_Button.Size = new System.Drawing.Size(267, 31);
            this.Call_Recordings_Button.TabIndex = 9;
            this.Call_Recordings_Button.TabStop = false;
            this.Call_Recordings_Button.Text = "Call Recordings";
            this.Call_Recordings_Button.UseVisualStyleBackColor = false;
            this.Call_Recordings_Button.Click += new System.EventHandler(this.Call_Recordings);
            // 
            // Website_Links_Button
            // 
            this.Website_Links_Button.BackColor = System.Drawing.Color.White;
            this.Website_Links_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Website_Links_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.Website_Links_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Website_Links_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Website_Links_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Website_Links_Button.Location = new System.Drawing.Point(110, 359);
            this.Website_Links_Button.Name = "Website_Links_Button";
            this.Website_Links_Button.Size = new System.Drawing.Size(267, 31);
            this.Website_Links_Button.TabIndex = 10;
            this.Website_Links_Button.TabStop = false;
            this.Website_Links_Button.Text = "Website Links";
            this.Website_Links_Button.UseVisualStyleBackColor = false;
            this.Website_Links_Button.Click += new System.EventHandler(this.Website_Links_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.White;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(179)))), ((int)(((byte)(175)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.Exit_Button.Location = new System.Drawing.Point(110, 429);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(267, 31);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.welcome_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(152, 167);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcome_label.Size = new System.Drawing.Size(70, 17);
            this.welcome_label.TabIndex = 13;
            this.welcome_label.Text = "Welcome,";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Website_Links_Button);
            this.Controls.Add(this.Call_Recordings_Button);
            this.Controls.Add(this.Event_Viewer_Button);
            this.Controls.Add(this.Computer_Name_Button);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.technical_support_label);
            this.Controls.Add(this.System_Menu_Button);
            this.Controls.Add(this.office365exe_Button);
            this.Controls.Add(this.ISG_Picturebox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Support Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.ISG_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ISG_Picturebox;
        private System.Windows.Forms.Button office365exe_Button;
        private System.Windows.Forms.Button System_Menu_Button;
        private System.Windows.Forms.Label technical_support_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Button Computer_Name_Button;
        private System.Windows.Forms.Button Event_Viewer_Button;
        private System.Windows.Forms.Button Call_Recordings_Button;
        private System.Windows.Forms.Button Website_Links_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label welcome_label;
    }
}

