namespace Enrollment_System
{
    partial class SubjectEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OfferingsComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CoRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.PreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectRequisiteTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(441, 218);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CourseCodeComboBox.TabIndex = 14;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lecture",
            "Laboratory"});
            this.CategoryComboBox.Location = new System.Drawing.Point(441, 131);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.CategoryComboBox.TabIndex = 13;
            // 
            // OfferingsComboBox
            // 
            this.OfferingsComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OfferingsComboBox.FormattingEnabled = true;
            this.OfferingsComboBox.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "Summer"});
            this.OfferingsComboBox.Location = new System.Drawing.Point(214, 265);
            this.OfferingsComboBox.Name = "OfferingsComboBox";
            this.OfferingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.OfferingsComboBox.TabIndex = 12;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(474, 265);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(88, 20);
            this.CurriculumYearTextBox.TabIndex = 10;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitsTextBox.Location = new System.Drawing.Point(214, 220);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(57, 20);
            this.UnitsTextBox.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionTextBox.Location = new System.Drawing.Point(214, 176);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(203, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(214, 132);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(106, 20);
            this.SubjectCodeTextBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.CoRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.PreRequisiteRadioButton);
            this.groupBox2.Controls.Add(this.SubjectDataGridView);
            this.groupBox2.Controls.Add(this.SubjectRequisiteTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(255, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisite Information";
            // 
            // CoRequisiteRadioButton
            // 
            this.CoRequisiteRadioButton.AutoSize = true;
            this.CoRequisiteRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoRequisiteRadioButton.Location = new System.Drawing.Point(497, 36);
            this.CoRequisiteRadioButton.Name = "CoRequisiteRadioButton";
            this.CoRequisiteRadioButton.Size = new System.Drawing.Size(96, 21);
            this.CoRequisiteRadioButton.TabIndex = 9;
            this.CoRequisiteRadioButton.TabStop = true;
            this.CoRequisiteRadioButton.Text = "Co-Requisite";
            this.CoRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // PreRequisiteRadioButton
            // 
            this.PreRequisiteRadioButton.AutoSize = true;
            this.PreRequisiteRadioButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreRequisiteRadioButton.Location = new System.Drawing.Point(497, 9);
            this.PreRequisiteRadioButton.Name = "PreRequisiteRadioButton";
            this.PreRequisiteRadioButton.Size = new System.Drawing.Size(96, 21);
            this.PreRequisiteRadioButton.TabIndex = 8;
            this.PreRequisiteRadioButton.TabStop = true;
            this.PreRequisiteRadioButton.Text = "Pre-requisite";
            this.PreRequisiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.SubjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.SubjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.CoPreColumn});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.SubjectDataGridView.Location = new System.Drawing.Point(70, 77);
            this.SubjectDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.SubjectDataGridView.RowHeadersWidth = 60;
            this.SubjectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SubjectDataGridView.Size = new System.Drawing.Size(461, 87);
            this.SubjectDataGridView.TabIndex = 12;
            // 
            // SubjectCodeColumn
            // 
            this.SubjectCodeColumn.HeaderText = "Subject Code";
            this.SubjectCodeColumn.Name = "SubjectCodeColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // UnitsColumn
            // 
            this.UnitsColumn.HeaderText = "Units";
            this.UnitsColumn.Name = "UnitsColumn";
            // 
            // CoPreColumn
            // 
            this.CoPreColumn.HeaderText = "Co/Pre-Requisite";
            this.CoPreColumn.Name = "CoPreColumn";
            // 
            // SubjectRequisiteTextBox
            // 
            this.SubjectRequisiteTextBox.Location = new System.Drawing.Point(108, 29);
            this.SubjectRequisiteTextBox.Name = "SubjectRequisiteTextBox";
            this.SubjectRequisiteTextBox.Size = new System.Drawing.Size(136, 22);
            this.SubjectRequisiteTextBox.TabIndex = 11;
            this.SubjectRequisiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectRequisiteTextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Subject Code";
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButton;
            this.EnrollmentButton.Location = new System.Drawing.Point(571, 36);
            this.EnrollmentButton.Name = "EnrollmentButton";
            this.EnrollmentButton.Size = new System.Drawing.Size(103, 24);
            this.EnrollmentButton.TabIndex = 40;
            this.EnrollmentButton.UseVisualStyleBackColor = false;
            this.EnrollmentButton.Click += new System.EventHandler(this.EnrollmentButton_Click);
            // 
            // SubjectScheduleEntryButton
            // 
            this.SubjectScheduleEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubjectScheduleEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectScheduleEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtons;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(351, 32);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(202, 33);
            this.SubjectScheduleEntryButton.TabIndex = 39;
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectEntryButtonClicked;
            this.SubjectEntryButton.Location = new System.Drawing.Point(183, 29);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(152, 38);
            this.SubjectEntryButton.TabIndex = 38;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentEntryButton.FlatAppearance.BorderSize = 0;
            this.StudentEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentEntryButton.Image = global::Enrollment_System.Properties.Resources.StudentEntryButtonNotClicked;
            this.StudentEntryButton.Location = new System.Drawing.Point(32, 32);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(127, 32);
            this.StudentEntryButton.TabIndex = 37;
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
            this.ClearButton.Location = new System.Drawing.Point(611, 276);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(117, 42);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = global::Enrollment_System.Properties.Resources.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(611, 229);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 41);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enrollment_System.Properties.Resources.SubjectEntryBackgroundImage;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 640);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // SubjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1097, 634);
            this.Controls.Add(this.EnrollmentButton);
            this.Controls.Add(this.SubjectScheduleEntryButton);
            this.Controls.Add(this.SubjectEntryButton);
            this.Controls.Add(this.StudentEntryButton);
            this.Controls.Add(this.CurriculumYearTextBox);
            this.Controls.Add(this.CourseCodeComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.OfferingsComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UnitsTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SubjectEntry";
            this.Text = "SubjectEntry";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton CoRequisiteRadioButton;
        private System.Windows.Forms.RadioButton PreRequisiteRadioButton;
        private System.Windows.Forms.ComboBox CourseCodeComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox OfferingsComboBox;
        private System.Windows.Forms.TextBox CurriculumYearTextBox;
        private System.Windows.Forms.TextBox UnitsTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.TextBox SubjectRequisiteTextBox;
        private System.Windows.Forms.DataGridView SubjectDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPreColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentButton;
    }
}