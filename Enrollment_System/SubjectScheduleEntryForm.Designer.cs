namespace Enrollment_System
{
    partial class SubjectScheduleEntryForm
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
            this.SubjectEdpCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.SchoolYearTextBox = new System.Windows.Forms.TextBox();
            this.MaxSizeTextBox = new System.Windows.Forms.TextBox();
            this.ClassSizeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.EndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectEdpCodeTextBox
            // 
            this.SubjectEdpCodeTextBox.Location = new System.Drawing.Point(440, 230);
            this.SubjectEdpCodeTextBox.Multiline = true;
            this.SubjectEdpCodeTextBox.Name = "SubjectEdpCodeTextBox";
            this.SubjectEdpCodeTextBox.Size = new System.Drawing.Size(128, 23);
            this.SubjectEdpCodeTextBox.TabIndex = 0;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(440, 278);
            this.SubjectCodeTextBox.Multiline = true;
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(128, 25);
            this.SubjectCodeTextBox.TabIndex = 1;
            this.SubjectCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectCodeTextBox_KeyPress);
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(440, 484);
            this.DaysTextBox.Multiline = true;
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(125, 27);
            this.DaysTextBox.TabIndex = 5;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Location = new System.Drawing.Point(816, 226);
            this.SectionTextBox.Multiline = true;
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(109, 27);
            this.SectionTextBox.TabIndex = 6;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(816, 278);
            this.RoomTextBox.Multiline = true;
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(109, 25);
            this.RoomTextBox.TabIndex = 7;
            // 
            // SchoolYearTextBox
            // 
            this.SchoolYearTextBox.Location = new System.Drawing.Point(816, 327);
            this.SchoolYearTextBox.Multiline = true;
            this.SchoolYearTextBox.Name = "SchoolYearTextBox";
            this.SchoolYearTextBox.Size = new System.Drawing.Size(109, 25);
            this.SchoolYearTextBox.TabIndex = 8;
            // 
            // MaxSizeTextBox
            // 
            this.MaxSizeTextBox.Location = new System.Drawing.Point(816, 376);
            this.MaxSizeTextBox.Multiline = true;
            this.MaxSizeTextBox.Name = "MaxSizeTextBox";
            this.MaxSizeTextBox.Size = new System.Drawing.Size(68, 25);
            this.MaxSizeTextBox.TabIndex = 9;
            // 
            // ClassSizeTextBox
            // 
            this.ClassSizeTextBox.Location = new System.Drawing.Point(816, 436);
            this.ClassSizeTextBox.Multiline = true;
            this.ClassSizeTextBox.Name = "ClassSizeTextBox";
            this.ClassSizeTextBox.Size = new System.Drawing.Size(68, 27);
            this.ClassSizeTextBox.TabIndex = 10;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(437, 336);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(90, 16);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description here";
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(440, 436);
            this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
            this.EndTimeDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.EndTimeDateTimePicker.TabIndex = 19;
            // 
            // StartTimeDateTimePicker
            // 
            this.StartTimeDateTimePicker.CustomFormat = "hh : mm";
            this.StartTimeDateTimePicker.Location = new System.Drawing.Point(440, 381);
            this.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker";
            this.StartTimeDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.StartTimeDateTimePicker.TabIndex = 19;
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButton;
            this.EnrollmentButton.Location = new System.Drawing.Point(965, 31);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(103, 24);
            this.EnrollmentButton.TabIndex = 41;
            this.EnrollmentButton.UseVisualStyleBackColor = false;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubjectScheduleEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectScheduleEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtonClicked;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(723, 24);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(222, 39);
            this.SubjectScheduleEntryButton.TabIndex = 40;
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectEntryButtons;
            this.SubjectEntryButton.Location = new System.Drawing.Point(571, 27);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(132, 33);
            this.SubjectEntryButton.TabIndex = 39;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentEntryButton.FlatAppearance.BorderSize = 0;
            this.StudentEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentEntryButton.Image = global::Enrollment_System.Properties.Resources.StudentEntryButtonNotClicked;
            this.StudentEntryButton.Location = new System.Drawing.Point(422, 29);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(123, 29);
            this.StudentEntryButton.TabIndex = 38;
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Image = global::Enrollment_System.Properties.Resources.CancelButton;
            this.ClearButton.Location = new System.Drawing.Point(631, 568);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(121, 38);
            this.ClearButton.TabIndex = 27;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = global::Enrollment_System.Properties.Resources.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(506, 568);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 38);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enrollment_System.Properties.Resources.sses;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 638);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // SubjectScheduleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Controls.Add(this.MaxSizeTextBox);
            this.Controls.Add(this.ClassSizeTextBox);
            this.Controls.Add(this.SchoolYearTextBox);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.EndTimeDateTimePicker);
            this.Controls.Add(this.StartTimeDateTimePicker);
            this.Controls.Add(this.SubjectEdpCodeTextBox);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "SubjectScheduleEntryForm";
            this.Text = "SubjectScheduleEntry";
            this.Load += new System.EventHandler(this.SubjectScheduleEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SubjectEdpCodeTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.TextBox SchoolYearTextBox;
        private System.Windows.Forms.TextBox MaxSizeTextBox;
        private System.Windows.Forms.TextBox ClassSizeTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DateTimePicker EndTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimeDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentButton;
    }
}