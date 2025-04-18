namespace Enrollment_System
{
    partial class MenuForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentEnrollmentButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-2, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 18, 10, 18);
            this.label1.Size = new System.Drawing.Size(525, 83);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enrollment System";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.StudentEnrollmentButton);
            this.groupBox1.Controls.Add(this.StudentEntryButton);
            this.groupBox1.Controls.Add(this.SubjectEntryButton);
            this.groupBox1.Controls.Add(this.SubjectScheduleEntryButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(129, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 323);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // StudentEnrollmentButton
            // 
            this.StudentEnrollmentButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StudentEnrollmentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentEnrollmentButton.Location = new System.Drawing.Point(29, 246);
            this.StudentEnrollmentButton.Name = "StudentEnrollmentButton";
            this.StudentEnrollmentButton.Size = new System.Drawing.Size(190, 50);
            this.StudentEnrollmentButton.TabIndex = 9;
            this.StudentEnrollmentButton.Text = "Enroll Now!";
            this.StudentEnrollmentButton.UseVisualStyleBackColor = false;
            this.StudentEnrollmentButton.Click += new System.EventHandler(this.StudentEnrollmentButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.StudentEntryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentEntryButton.Location = new System.Drawing.Point(29, 175);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(190, 50);
            this.StudentEntryButton.TabIndex = 8;
            this.StudentEntryButton.Text = "Student Entry";
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SubjectEntryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectEntryButton.Location = new System.Drawing.Point(29, 102);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(190, 50);
            this.SubjectEntryButton.TabIndex = 7;
            this.SubjectEntryButton.Text = "Subject  Entry";
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SubjectScheduleEntryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(29, 30);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(190, 50);
            this.SubjectScheduleEntryButton.TabIndex = 6;
            this.SubjectScheduleEntryButton.Text = "Subject Schedule Entry";
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button StudentEnrollmentButton;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
    }
}