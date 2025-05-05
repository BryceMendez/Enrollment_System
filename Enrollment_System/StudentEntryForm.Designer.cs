using System.Windows.Forms;

namespace Enrollment_System
{
    partial class StudentEntryForm
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
            this.IDNumberTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.RemarksComboBox = new System.Windows.Forms.ComboBox();
            this.StudentEntryLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleInitialLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StudentEntryPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentEntryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNumberTextBox.Location = new System.Drawing.Point(309, 237);
            this.IDNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(140, 28);
            this.IDNumberTextBox.TabIndex = 7;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(309, 308);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(140, 28);
            this.FirstNameTextBox.TabIndex = 8;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNameTextBox.Location = new System.Drawing.Point(309, 378);
            this.MiddleNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(66, 28);
            this.MiddleNameTextBox.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(309, 447);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(140, 28);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTextBox.Location = new System.Drawing.Point(637, 237);
            this.CourseTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(66, 28);
            this.CourseTextBox.TabIndex = 11;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(637, 308);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(66, 28);
            this.YearTextBox.TabIndex = 12;
            // 
            // RemarksComboBox
            // 
            this.RemarksComboBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksComboBox.FormattingEnabled = true;
            this.RemarksComboBox.Location = new System.Drawing.Point(637, 377);
            this.RemarksComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RemarksComboBox.Name = "RemarksComboBox";
            this.RemarksComboBox.Size = new System.Drawing.Size(122, 29);
            this.RemarksComboBox.TabIndex = 13;
            this.RemarksComboBox.Text = "- Choose -";
            // 
            // StudentEntryLabel
            // 
            this.StudentEntryLabel.AutoSize = true;
            this.StudentEntryLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEntryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentEntryLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.StudentEntryLabel.Location = new System.Drawing.Point(138, 120);
            this.StudentEntryLabel.Name = "StudentEntryLabel";
            this.StudentEntryLabel.Size = new System.Drawing.Size(470, 75);
            this.StudentEntryLabel.TabIndex = 37;
            this.StudentEntryLabel.Text = "STUDENT ENTRY";
            this.StudentEntryLabel.Click += new System.EventHandler(this.StudentEntryLabel_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.YearLabel.Location = new System.Drawing.Point(525, 309);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(50, 20);
            this.YearLabel.TabIndex = 36;
            this.YearLabel.Text = "Year:";
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RemarksLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.RemarksLabel.Location = new System.Drawing.Point(525, 379);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(82, 20);
            this.RemarksLabel.TabIndex = 35;
            this.RemarksLabel.Text = "Remarks:";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.CourseLabel.Location = new System.Drawing.Point(525, 238);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(70, 20);
            this.CourseLabel.TabIndex = 33;
            this.CourseLabel.Text = "Course:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastNameLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.LastNameLabel.Location = new System.Drawing.Point(166, 455);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(97, 20);
            this.LastNameLabel.TabIndex = 32;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // MiddleInitialLabel
            // 
            this.MiddleInitialLabel.AutoSize = true;
            this.MiddleInitialLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleInitialLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiddleInitialLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.MiddleInitialLabel.Location = new System.Drawing.Point(166, 386);
            this.MiddleInitialLabel.Name = "MiddleInitialLabel";
            this.MiddleInitialLabel.Size = new System.Drawing.Size(118, 20);
            this.MiddleInitialLabel.TabIndex = 31;
            this.MiddleInitialLabel.Text = "Middle Initial:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstNameLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.FirstNameLabel.Location = new System.Drawing.Point(166, 309);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(100, 20);
            this.FirstNameLabel.TabIndex = 30;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdNumberLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.IdNumberLabel.Location = new System.Drawing.Point(166, 238);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.IdNumberLabel.TabIndex = 29;
            this.IdNumberLabel.Text = "ID Number:";
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButtonNotClicked;
            this.EnrollmentButton.Location = new System.Drawing.Point(935, 27);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(103, 24);
            this.EnrollmentButton.TabIndex = 28;
            this.EnrollmentButton.UseVisualStyleBackColor = false;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubjectScheduleEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectScheduleEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtonNotClicked;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(709, 21);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(202, 33);
            this.SubjectScheduleEntryButton.TabIndex = 27;
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectEntryButtonNotClicked;
            this.SubjectEntryButton.Location = new System.Drawing.Point(571, 23);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(132, 33);
            this.SubjectEntryButton.TabIndex = 26;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentEntryButton.FlatAppearance.BorderSize = 0;
            this.StudentEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentEntryButton.Image = global::Enrollment_System.Properties.Resources.StudentEntryButtonClicked;
            this.StudentEntryButton.Location = new System.Drawing.Point(400, 19);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(151, 37);
            this.StudentEntryButton.TabIndex = 25;
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton.Image = global::Enrollment_System.Properties.Resources.CancelButton;
            this.CancelButton.Location = new System.Drawing.Point(265, 530);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 39);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Image = global::Enrollment_System.Properties.Resources.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(134, 530);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 39);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StudentEntryPictureBox
            // 
            this.StudentEntryPictureBox.Image = global::Enrollment_System.Properties.Resources.StudentEntry;
            this.StudentEntryPictureBox.Location = new System.Drawing.Point(-2, -1);
            this.StudentEntryPictureBox.Name = "StudentEntryPictureBox";
            this.StudentEntryPictureBox.Size = new System.Drawing.Size(1078, 636);
            this.StudentEntryPictureBox.TabIndex = 18;
            this.StudentEntryPictureBox.TabStop = false;
            // 
            // StudentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1073, 633);
            this.Controls.Add(this.StudentEntryLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.MiddleInitialLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Controls.Add(this.RemarksComboBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.IDNumberTextBox);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StudentEntryPictureBox);
            this.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "StudentEntryForm";
            this.Text = "Student Entry";
            ((System.ComponentModel.ISupportInitialize)(this.StudentEntryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDNumberTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.ComboBox RemarksComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox StudentEntryPictureBox;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private Label IdNumberLabel;
        private Label FirstNameLabel;
        private Label MiddleInitialLabel;
        private Label LastNameLabel;
        private Label CourseLabel;
        private Label RemarksLabel;
        private Label YearLabel;
        private Label StudentEntryLabel;
    }
}
