namespace Enrollment_System
{
    partial class StudentEnrollmentEntry
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
            this.YearLabel = new System.Windows.Forms.Label();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.IDNumberTextBox = new System.Windows.Forms.TextBox();
            this.TotalUnitsLabel = new System.Windows.Forms.Label();
            this.SubjectChoosedDataGridView = new System.Windows.Forms.DataGridView();
            this.EDPCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncoderTextBox = new System.Windows.Forms.TextBox();
            this.DateEnrolledDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EnrollmentLabel = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.EnrollmentTotalUnitsLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EncodedByLabel = new System.Windows.Forms.Label();
            this.StudentYearLabel = new System.Windows.Forms.Label();
            this.EdpCodeLabel = new System.Windows.Forms.Label();
            this.StudentCourseLabel = new System.Windows.Forms.Label();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.IdNumberLabel = new System.Windows.Forms.Label();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.StudentEnrollmentPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentEnrollmentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // YearLabel
            // 
            this.YearLabel.BackColor = System.Drawing.Color.White;
            this.YearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearLabel.Location = new System.Drawing.Point(951, 228);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(87, 23);
            this.YearLabel.TabIndex = 12;
            // 
            // CourseLabel
            // 
            this.CourseLabel.BackColor = System.Drawing.Color.White;
            this.CourseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseLabel.Location = new System.Drawing.Point(786, 228);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(93, 23);
            this.CourseLabel.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.White;
            this.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLabel.Location = new System.Drawing.Point(786, 176);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 23);
            this.NameLabel.TabIndex = 10;
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(786, 279);
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(137, 20);
            this.EDPCodeTextBox.TabIndex = 9;
            this.EDPCodeTextBox.TextChanged += new System.EventHandler(this.EDPCodeTextBox_TextChanged);
            this.EDPCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDPCodeTextBox_KeyPress);
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.Location = new System.Drawing.Point(786, 129);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(137, 20);
            this.IDNumberTextBox.TabIndex = 5;
            this.IDNumberTextBox.TextChanged += new System.EventHandler(this.IDNumberTextBox_TextChanged);
            this.IDNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNumberTextBox_KeyPress);
            // 
            // TotalUnitsLabel
            // 
            this.TotalUnitsLabel.BackColor = System.Drawing.Color.White;
            this.TotalUnitsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalUnitsLabel.Location = new System.Drawing.Point(976, 557);
            this.TotalUnitsLabel.Name = "TotalUnitsLabel";
            this.TotalUnitsLabel.Size = new System.Drawing.Size(78, 22);
            this.TotalUnitsLabel.TabIndex = 15;
            // 
            // SubjectChoosedDataGridView
            // 
            this.SubjectChoosedDataGridView.AllowUserToAddRows = false;
            this.SubjectChoosedDataGridView.AllowUserToDeleteRows = false;
            this.SubjectChoosedDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.SubjectChoosedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectChoosedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCodeColumn,
            this.SubjectCodeColumn,
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.DaysColumn,
            this.RoomColumn,
            this.UnitsColumn});
            this.SubjectChoosedDataGridView.Location = new System.Drawing.Point(316, 347);
            this.SubjectChoosedDataGridView.Name = "SubjectChoosedDataGridView";
            this.SubjectChoosedDataGridView.Size = new System.Drawing.Size(738, 202);
            this.SubjectChoosedDataGridView.TabIndex = 2;
            this.SubjectChoosedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectChoosedDataGridView_CellContentClick);
            this.SubjectChoosedDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectChoosedDataGridView_CellValueChanged);
            this.SubjectChoosedDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SubjectChoosedDataGridView_RowsAdded);
            // 
            // EDPCodeColumn
            // 
            this.EDPCodeColumn.HeaderText = "EDP Code";
            this.EDPCodeColumn.Name = "EDPCodeColumn";
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.Name = "StartTimeColumn";
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DaysColumn
            // 
            this.DaysColumn.HeaderText = "Days";
            this.DaysColumn.Name = "DaysColumn";
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "Room";
            this.RoomColumn.Name = "RoomColumn";
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            // 
            // EncoderTextBox
            // 
            this.EncoderTextBox.Location = new System.Drawing.Point(414, 559);
            this.EncoderTextBox.Name = "EncoderTextBox";
            this.EncoderTextBox.Size = new System.Drawing.Size(119, 20);
            this.EncoderTextBox.TabIndex = 10;
            // 
            // DateEnrolledDateTimePicker
            // 
            this.DateEnrolledDateTimePicker.Location = new System.Drawing.Point(633, 559);
            this.DateEnrolledDateTimePicker.Name = "DateEnrolledDateTimePicker";
            this.DateEnrolledDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateEnrolledDateTimePicker.TabIndex = 12;
            // 
            // EnrollmentLabel
            // 
            this.EnrollmentLabel.AutoSize = true;
            this.EnrollmentLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 45.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnrollmentLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.EnrollmentLabel.Location = new System.Drawing.Point(178, 228);
            this.EnrollmentLabel.Name = "EnrollmentLabel";
            this.EnrollmentLabel.Size = new System.Drawing.Size(405, 77);
            this.EnrollmentLabel.TabIndex = 51;
            this.EnrollmentLabel.Text = "ENROLLMENT";
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 45.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.StudentLabel.Location = new System.Drawing.Point(178, 159);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(282, 77);
            this.StudentLabel.TabIndex = 50;
            this.StudentLabel.Text = "STUDENT";
            // 
            // EnrollmentTotalUnitsLabel
            // 
            this.EnrollmentTotalUnitsLabel.AutoSize = true;
            this.EnrollmentTotalUnitsLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnrollmentTotalUnitsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnrollmentTotalUnitsLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.EnrollmentTotalUnitsLabel.Location = new System.Drawing.Point(878, 561);
            this.EnrollmentTotalUnitsLabel.Name = "EnrollmentTotalUnitsLabel";
            this.EnrollmentTotalUnitsLabel.Size = new System.Drawing.Size(92, 18);
            this.EnrollmentTotalUnitsLabel.TabIndex = 49;
            this.EnrollmentTotalUnitsLabel.Text = "Total Units:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.DateLabel.Location = new System.Drawing.Point(580, 561);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(47, 18);
            this.DateLabel.TabIndex = 48;
            this.DateLabel.Text = "Date:";
            // 
            // EncodedByLabel
            // 
            this.EncodedByLabel.AutoSize = true;
            this.EncodedByLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodedByLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EncodedByLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.EncodedByLabel.Location = new System.Drawing.Point(313, 559);
            this.EncodedByLabel.Name = "EncodedByLabel";
            this.EncodedByLabel.Size = new System.Drawing.Size(99, 18);
            this.EncodedByLabel.TabIndex = 47;
            this.EncodedByLabel.Text = "Encoded By:";
            // 
            // StudentYearLabel
            // 
            this.StudentYearLabel.AutoSize = true;
            this.StudentYearLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentYearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentYearLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.StudentYearLabel.Location = new System.Drawing.Point(900, 228);
            this.StudentYearLabel.Name = "StudentYearLabel";
            this.StudentYearLabel.Size = new System.Drawing.Size(45, 18);
            this.StudentYearLabel.TabIndex = 46;
            this.StudentYearLabel.Text = "Year:";
            // 
            // EdpCodeLabel
            // 
            this.EdpCodeLabel.AutoSize = true;
            this.EdpCodeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdpCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EdpCodeLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.EdpCodeLabel.Location = new System.Drawing.Point(688, 281);
            this.EdpCodeLabel.Name = "EdpCodeLabel";
            this.EdpCodeLabel.Size = new System.Drawing.Size(86, 18);
            this.EdpCodeLabel.TabIndex = 45;
            this.EdpCodeLabel.Text = "EDP Code:";
            // 
            // StudentCourseLabel
            // 
            this.StudentCourseLabel.AutoSize = true;
            this.StudentCourseLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentCourseLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.StudentCourseLabel.Location = new System.Drawing.Point(688, 228);
            this.StudentCourseLabel.Name = "StudentCourseLabel";
            this.StudentCourseLabel.Size = new System.Drawing.Size(65, 18);
            this.StudentCourseLabel.TabIndex = 44;
            this.StudentCourseLabel.Text = "Course:";
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentNameLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.StudentNameLabel.Location = new System.Drawing.Point(688, 181);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(55, 18);
            this.StudentNameLabel.TabIndex = 43;
            this.StudentNameLabel.Text = "Name:";
            // 
            // IdNumberLabel
            // 
            this.IdNumberLabel.AutoSize = true;
            this.IdNumberLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdNumberLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.IdNumberLabel.Location = new System.Drawing.Point(688, 131);
            this.IdNumberLabel.Name = "IdNumberLabel";
            this.IdNumberLabel.Size = new System.Drawing.Size(92, 18);
            this.IdNumberLabel.TabIndex = 42;
            this.IdNumberLabel.Text = "ID Number:";
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButtonClicked;
            this.EnrollmentButton.Location = new System.Drawing.Point(941, 23);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(125, 40);
            this.EnrollmentButton.TabIndex = 39;
            this.EnrollmentButton.UseVisualStyleBackColor = false;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubjectScheduleEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectScheduleEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtonNotClicked;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(721, 27);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(202, 33);
            this.SubjectScheduleEntryButton.TabIndex = 38;
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectEntryButtonNotClicked;
            this.SubjectEntryButton.Location = new System.Drawing.Point(574, 28);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(132, 33);
            this.SubjectEntryButton.TabIndex = 37;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentEntryButton.FlatAppearance.BorderSize = 0;
            this.StudentEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentEntryButton.Image = global::Enrollment_System.Properties.Resources.StudentEntryButtonNotClicked;
            this.StudentEntryButton.Location = new System.Drawing.Point(434, 28);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(123, 32);
            this.StudentEntryButton.TabIndex = 36;
            this.StudentEntryButton.UseVisualStyleBackColor = false;
            this.StudentEntryButton.Click += new System.EventHandler(this.StudentEntryButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Image = global::Enrollment_System.Properties.Resources.CancelButton;
            this.CancelButton.Location = new System.Drawing.Point(533, 162);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 42);
            this.CancelButton.TabIndex = 34;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = global::Enrollment_System.Properties.Resources.EnrollButton;
            this.SaveButton.Location = new System.Drawing.Point(533, 115);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 41);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // StudentEnrollmentPictureBox
            // 
            this.StudentEnrollmentPictureBox.Image = global::Enrollment_System.Properties.Resources.StudentEnrollment;
            this.StudentEnrollmentPictureBox.Location = new System.Drawing.Point(-1, -2);
            this.StudentEnrollmentPictureBox.Name = "StudentEnrollmentPictureBox";
            this.StudentEnrollmentPictureBox.Size = new System.Drawing.Size(1095, 639);
            this.StudentEnrollmentPictureBox.TabIndex = 35;
            this.StudentEnrollmentPictureBox.TabStop = false;
            this.StudentEnrollmentPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentEnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 629);
            this.Controls.Add(this.EnrollmentLabel);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.EnrollmentTotalUnitsLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EncodedByLabel);
            this.Controls.Add(this.StudentYearLabel);
            this.Controls.Add(this.EdpCodeLabel);
            this.Controls.Add(this.StudentCourseLabel);
            this.Controls.Add(this.StudentNameLabel);
            this.Controls.Add(this.IdNumberLabel);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.TotalUnitsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DateEnrolledDateTimePicker);
            this.Controls.Add(this.EncoderTextBox);
            this.Controls.Add(this.IDNumberTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SubjectChoosedDataGridView);
            this.Controls.Add(this.StudentEnrollmentPictureBox);
            this.Name = "StudentEnrollmentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enrollment Entry Form";
            this.Load += new System.EventHandler(this.StudentEnrollmentEntry_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentEnrollmentEntry_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentEnrollmentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.TextBox IDNumberTextBox;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label TotalUnitsLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox StudentEnrollmentPictureBox;
        private System.Windows.Forms.DataGridView SubjectChoosedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.TextBox EncoderTextBox;
        private System.Windows.Forms.DateTimePicker DateEnrolledDateTimePicker;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Label IdNumberLabel;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Label StudentCourseLabel;
        private System.Windows.Forms.Label EdpCodeLabel;
        private System.Windows.Forms.Label StudentYearLabel;
        private System.Windows.Forms.Label EncodedByLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label EnrollmentTotalUnitsLabel;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.Label EnrollmentLabel;
    }
}