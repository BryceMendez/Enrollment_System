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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.OfferingsComboBox = new System.Windows.Forms.ComboBox();
            this.CurriculumYearTextBox = new System.Windows.Forms.TextBox();
            this.UnitsTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.RequisiteInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.CoRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.PreRequisiteRadioButton = new System.Windows.Forms.RadioButton();
            this.SubjectDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectRequisiteTextBox = new System.Windows.Forms.TextBox();
            this.RequisiteSubjectCodeLabel = new System.Windows.Forms.Label();
            this.EntryLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectInformationLabel = new System.Windows.Forms.Label();
            this.CurriculumYearLabel = new System.Windows.Forms.Label();
            this.CourseCodeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.OfferingLabel = new System.Windows.Forms.Label();
            this.UnitsLabel = new System.Windows.Forms.Label();
            this.DescriptiopnLabel = new System.Windows.Forms.Label();
            this.SubjectCodeLabel = new System.Windows.Forms.Label();
            this.EnrollmentButton = new System.Windows.Forms.Button();
            this.SubjectScheduleEntryButton = new System.Windows.Forms.Button();
            this.SubjectEntryButton = new System.Windows.Forms.Button();
            this.StudentEntryButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SubjectEntryPictureBox = new System.Windows.Forms.PictureBox();
            this.RequisiteInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectEntryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseCodeComboBox
            // 
            this.CourseCodeComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseCodeComboBox.FormattingEnabled = true;
            this.CourseCodeComboBox.Items.AddRange(new object[] {
            "BSIT",
            "BSIS"});
            this.CourseCodeComboBox.Location = new System.Drawing.Point(590, 243);
            this.CourseCodeComboBox.Name = "CourseCodeComboBox";
            this.CourseCodeComboBox.Size = new System.Drawing.Size(96, 21);
            this.CourseCodeComboBox.TabIndex = 14;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Lecture",
            "Laboratory"});
            this.CategoryComboBox.Location = new System.Drawing.Point(560, 152);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(126, 21);
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
            this.OfferingsComboBox.Location = new System.Drawing.Point(347, 290);
            this.OfferingsComboBox.Name = "OfferingsComboBox";
            this.OfferingsComboBox.Size = new System.Drawing.Size(121, 21);
            this.OfferingsComboBox.TabIndex = 12;
            // 
            // CurriculumYearTextBox
            // 
            this.CurriculumYearTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurriculumYearTextBox.Location = new System.Drawing.Point(602, 291);
            this.CurriculumYearTextBox.Name = "CurriculumYearTextBox";
            this.CurriculumYearTextBox.Size = new System.Drawing.Size(84, 20);
            this.CurriculumYearTextBox.TabIndex = 10;
            // 
            // UnitsTextBox
            // 
            this.UnitsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitsTextBox.Location = new System.Drawing.Point(347, 244);
            this.UnitsTextBox.Name = "UnitsTextBox";
            this.UnitsTextBox.Size = new System.Drawing.Size(57, 20);
            this.UnitsTextBox.TabIndex = 9;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptionTextBox.Location = new System.Drawing.Point(347, 200);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(203, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(347, 153);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(106, 20);
            this.SubjectCodeTextBox.TabIndex = 7;
            // 
            // RequisiteInformationGroupBox
            // 
            this.RequisiteInformationGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RequisiteInformationGroupBox.Controls.Add(this.CoRequisiteRadioButton);
            this.RequisiteInformationGroupBox.Controls.Add(this.PreRequisiteRadioButton);
            this.RequisiteInformationGroupBox.Controls.Add(this.SubjectDataGridView);
            this.RequisiteInformationGroupBox.Controls.Add(this.SubjectRequisiteTextBox);
            this.RequisiteInformationGroupBox.Controls.Add(this.RequisiteSubjectCodeLabel);
            this.RequisiteInformationGroupBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequisiteInformationGroupBox.Location = new System.Drawing.Point(155, 377);
            this.RequisiteInformationGroupBox.Name = "RequisiteInformationGroupBox";
            this.RequisiteInformationGroupBox.Size = new System.Drawing.Size(618, 196);
            this.RequisiteInformationGroupBox.TabIndex = 1;
            this.RequisiteInformationGroupBox.TabStop = false;
            this.RequisiteInformationGroupBox.Text = "Requisite Information";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.SubjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.SubjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectCodeColumn,
            this.DescriptionColumn,
            this.UnitsColumn,
            this.CoPreColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectDataGridView.Location = new System.Drawing.Point(70, 77);
            this.SubjectDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // RequisiteSubjectCodeLabel
            // 
            this.RequisiteSubjectCodeLabel.AutoSize = true;
            this.RequisiteSubjectCodeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequisiteSubjectCodeLabel.Location = new System.Drawing.Point(21, 34);
            this.RequisiteSubjectCodeLabel.Name = "RequisiteSubjectCodeLabel";
            this.RequisiteSubjectCodeLabel.Size = new System.Drawing.Size(81, 17);
            this.RequisiteSubjectCodeLabel.TabIndex = 7;
            this.RequisiteSubjectCodeLabel.Text = "Subject Code";
            // 
            // EntryLabel
            // 
            this.EntryLabel.AutoSize = true;
            this.EntryLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EntryLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.EntryLabel.Location = new System.Drawing.Point(876, 413);
            this.EntryLabel.Name = "EntryLabel";
            this.EntryLabel.Size = new System.Drawing.Size(209, 75);
            this.EntryLabel.TabIndex = 50;
            this.EntryLabel.Text = "ENTRY";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.SubjectLabel.Location = new System.Drawing.Point(822, 353);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(263, 75);
            this.SubjectLabel.TabIndex = 49;
            this.SubjectLabel.Text = "SUBJECT";
            // 
            // SubjectInformationLabel
            // 
            this.SubjectInformationLabel.AutoSize = true;
            this.SubjectInformationLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectInformationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectInformationLabel.Image = global::Enrollment_System.Properties.Resources.LightBlueBackgroundImage;
            this.SubjectInformationLabel.Location = new System.Drawing.Point(221, 103);
            this.SubjectInformationLabel.Name = "SubjectInformationLabel";
            this.SubjectInformationLabel.Size = new System.Drawing.Size(163, 21);
            this.SubjectInformationLabel.TabIndex = 48;
            this.SubjectInformationLabel.Text = "Subject Information";
            // 
            // CurriculumYearLabel
            // 
            this.CurriculumYearLabel.AutoSize = true;
            this.CurriculumYearLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurriculumYearLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CurriculumYearLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.CurriculumYearLabel.Location = new System.Drawing.Point(469, 290);
            this.CurriculumYearLabel.Name = "CurriculumYearLabel";
            this.CurriculumYearLabel.Size = new System.Drawing.Size(130, 18);
            this.CurriculumYearLabel.TabIndex = 47;
            this.CurriculumYearLabel.Text = "Curriculum Year:";
            // 
            // CourseCodeLabel
            // 
            this.CourseCodeLabel.AutoSize = true;
            this.CourseCodeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseCodeLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.CourseCodeLabel.Location = new System.Drawing.Point(469, 246);
            this.CourseCodeLabel.Name = "CourseCodeLabel";
            this.CourseCodeLabel.Size = new System.Drawing.Size(110, 18);
            this.CourseCodeLabel.TabIndex = 46;
            this.CourseCodeLabel.Text = "Course Code:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.CategoryLabel.Location = new System.Drawing.Point(469, 155);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(81, 18);
            this.CategoryLabel.TabIndex = 45;
            this.CategoryLabel.Text = "Category:";
            // 
            // OfferingLabel
            // 
            this.OfferingLabel.AutoSize = true;
            this.OfferingLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OfferingLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.OfferingLabel.Location = new System.Drawing.Point(235, 293);
            this.OfferingLabel.Name = "OfferingLabel";
            this.OfferingLabel.Size = new System.Drawing.Size(75, 18);
            this.OfferingLabel.TabIndex = 44;
            this.OfferingLabel.Text = "Offering:";
            // 
            // UnitsLabel
            // 
            this.UnitsLabel.AutoSize = true;
            this.UnitsLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitsLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.UnitsLabel.Location = new System.Drawing.Point(235, 246);
            this.UnitsLabel.Name = "UnitsLabel";
            this.UnitsLabel.Size = new System.Drawing.Size(49, 18);
            this.UnitsLabel.TabIndex = 43;
            this.UnitsLabel.Text = "Units:";
            // 
            // DescriptiopnLabel
            // 
            this.DescriptiopnLabel.AutoSize = true;
            this.DescriptiopnLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptiopnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescriptiopnLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.DescriptiopnLabel.Location = new System.Drawing.Point(235, 200);
            this.DescriptiopnLabel.Name = "DescriptiopnLabel";
            this.DescriptiopnLabel.Size = new System.Drawing.Size(97, 18);
            this.DescriptiopnLabel.TabIndex = 42;
            this.DescriptiopnLabel.Text = "Description:";
            // 
            // SubjectCodeLabel
            // 
            this.SubjectCodeLabel.AutoSize = true;
            this.SubjectCodeLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCodeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectCodeLabel.Image = global::Enrollment_System.Properties.Resources.BlueBackgroundImage;
            this.SubjectCodeLabel.Location = new System.Drawing.Point(235, 153);
            this.SubjectCodeLabel.Name = "SubjectCodeLabel";
            this.SubjectCodeLabel.Size = new System.Drawing.Size(113, 18);
            this.SubjectCodeLabel.TabIndex = 41;
            this.SubjectCodeLabel.Text = "Subject Code:";
            // 
            // EnrollmentButton
            // 
            this.EnrollmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EnrollmentButton.FlatAppearance.BorderSize = 0;
            this.EnrollmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollmentButton.Image = global::Enrollment_System.Properties.Resources.EnrollmentButtonNotClicked;
            this.EnrollmentButton.Location = new System.Drawing.Point(893, 29);
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
            this.SubjectScheduleEntryButton.Image = global::Enrollment_System.Properties.Resources.SubjectScheduleEntryButtonNotClicked;
            this.SubjectScheduleEntryButton.Location = new System.Drawing.Point(671, 25);
            this.SubjectScheduleEntryButton.Name = "SubjectScheduleEntryButton";
            this.SubjectScheduleEntryButton.Size = new System.Drawing.Size(202, 33);
            this.SubjectScheduleEntryButton.TabIndex = 39;
            this.SubjectScheduleEntryButton.UseVisualStyleBackColor = false;
            this.SubjectScheduleEntryButton.Click += new System.EventHandler(this.SubjectScheduleEntryButton_Click);
            // 
            // SubjectEntryButton
            // 
            this.SubjectEntryButton.BackgroundImage = global::Enrollment_System.Properties.Resources.SubjectEntryButtonClicked1;
            this.SubjectEntryButton.FlatAppearance.BorderSize = 0;
            this.SubjectEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectEntryButton.Location = new System.Drawing.Point(495, 22);
            this.SubjectEntryButton.Name = "SubjectEntryButton";
            this.SubjectEntryButton.Size = new System.Drawing.Size(152, 38);
            this.SubjectEntryButton.TabIndex = 38;
            this.SubjectEntryButton.UseVisualStyleBackColor = false;
            this.SubjectEntryButton.Click += new System.EventHandler(this.SubjectEntryButton_Click);
            // 
            // StudentEntryButton
            // 
            this.StudentEntryButton.BackgroundImage = global::Enrollment_System.Properties.Resources.StudentEntryButtonNotClicked;
            this.StudentEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentEntryButton.FlatAppearance.BorderSize = 0;
            this.StudentEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentEntryButton.Location = new System.Drawing.Point(353, 26);
            this.StudentEntryButton.Name = "StudentEntryButton";
            this.StudentEntryButton.Size = new System.Drawing.Size(115, 30);
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
            this.ClearButton.Location = new System.Drawing.Point(737, 188);
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
            this.SaveButton.Location = new System.Drawing.Point(737, 132);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 41);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // SubjectEntryPictureBox
            // 
            this.SubjectEntryPictureBox.Image = global::Enrollment_System.Properties.Resources.SubjectEntry;
            this.SubjectEntryPictureBox.Location = new System.Drawing.Point(-2, 0);
            this.SubjectEntryPictureBox.Name = "SubjectEntryPictureBox";
            this.SubjectEntryPictureBox.Size = new System.Drawing.Size(1115, 644);
            this.SubjectEntryPictureBox.TabIndex = 33;
            this.SubjectEntryPictureBox.TabStop = false;
            this.SubjectEntryPictureBox.Click += new System.EventHandler(this.SubjectEntryPictureBox_Click);
            // 
            // SubjectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1110, 634);
            this.Controls.Add(this.EntryLabel);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.SubjectInformationLabel);
            this.Controls.Add(this.CurriculumYearLabel);
            this.Controls.Add(this.CourseCodeLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.OfferingLabel);
            this.Controls.Add(this.UnitsLabel);
            this.Controls.Add(this.DescriptiopnLabel);
            this.Controls.Add(this.SubjectCodeLabel);
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
            this.Controls.Add(this.RequisiteInformationGroupBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.SubjectEntryPictureBox);
            this.Name = "SubjectEntry";
            this.Text = "Subject Entry";
            this.RequisiteInformationGroupBox.ResumeLayout(false);
            this.RequisiteInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectEntryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox RequisiteInformationGroupBox;
        private System.Windows.Forms.Label RequisiteSubjectCodeLabel;
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
        private System.Windows.Forms.PictureBox SubjectEntryPictureBox;
        private System.Windows.Forms.Button StudentEntryButton;
        private System.Windows.Forms.Button SubjectEntryButton;
        private System.Windows.Forms.Button SubjectScheduleEntryButton;
        private System.Windows.Forms.Button EnrollmentButton;
        private System.Windows.Forms.Label SubjectCodeLabel;
        private System.Windows.Forms.Label DescriptiopnLabel;
        private System.Windows.Forms.Label UnitsLabel;
        private System.Windows.Forms.Label OfferingLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CourseCodeLabel;
        private System.Windows.Forms.Label CurriculumYearLabel;
        private System.Windows.Forms.Label SubjectInformationLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label EntryLabel;
    }
}