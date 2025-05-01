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
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButtonClicked;
            this.EnrollmentButton.Location = new System.Drawing.Point(951, 24);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(123, 39);
            this.EnrollmentButton.TabIndex = 39;
            this.EnrollmentButton.UseVisualStyleBackColor = false;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubjectScheduleEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectScheduleEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtons;
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
            this.SubjectEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectEntryButtons;
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
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = global::Enrollment_System.Properties.Resources.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(533, 115);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 41);
            this.SaveButton.TabIndex = 33;
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Enrollment_System.Properties.Resources.SE;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1095, 639);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // StudentEnrollmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 629);
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
            this.Controls.Add(this.pictureBox2);
            this.Name = "StudentEnrollmentEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentEnrollmentEntryForm";
            this.Load += new System.EventHandler(this.StudentEnrollmentEntry_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentEnrollmentEntry_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChoosedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}