namespace UN
{
    partial class ProjectReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProjectReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectReportViewTableAdapter = new UN.UNdbDataSet1TableAdapters.ProjectReportViewTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.fullname_combo = new System.Windows.Forms.ComboBox();
            this.projectReportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.m_name = new System.Windows.Forms.ComboBox();
            this.projectReportViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category_combo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.given_start_picker1 = new System.Windows.Forms.DateTimePicker();
            this.given_end_picker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.given_side_combo1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.given_end_picker2 = new System.Windows.Forms.DateTimePicker();
            this.given_start_picker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.given_end_picker3 = new System.Windows.Forms.DateTimePicker();
            this.given_start_picker3 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.given_side_combo2 = new System.Windows.Forms.ComboBox();
            this.given_date_panel = new System.Windows.Forms.Panel();
            this.category_panel = new System.Windows.Forms.Panel();
            this.given_side_panel = new System.Windows.Forms.Panel();
            this.fullname_panel = new System.Windows.Forms.Panel();
            this.given_date_side_panel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportViewBindingSource2)).BeginInit();
            this.given_date_panel.SuspendLayout();
            this.category_panel.SuspendLayout();
            this.given_side_panel.SuspendLayout();
            this.fullname_panel.SuspendLayout();
            this.given_date_side_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectReportViewBindingSource
            // 
            this.ProjectReportViewBindingSource.DataMember = "ProjectReportView";
            this.ProjectReportViewBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProjectReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(171, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1102, 423);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjectReportViewTableAdapter
            // 
            this.ProjectReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullname_combo
            // 
            this.fullname_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fullname_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fullname_combo.DataSource = this.projectReportViewBindingSource1;
            this.fullname_combo.DisplayMember = "full_name";
            this.fullname_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullname_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fullname_combo.FormattingEnabled = true;
            this.fullname_combo.Location = new System.Drawing.Point(323, 17);
            this.fullname_combo.Name = "fullname_combo";
            this.fullname_combo.Size = new System.Drawing.Size(121, 21);
            this.fullname_combo.TabIndex = 2;
            // 
            // projectReportViewBindingSource1
            // 
            this.projectReportViewBindingSource1.DataMember = "ProjectReportView";
            this.projectReportViewBindingSource1.DataSource = this.UNdbDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاسم الثلاثي";
            // 
            // m_name
            // 
            this.m_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_name.DataSource = this.projectReportViewBindingSource2;
            this.m_name.DisplayMember = "m_name";
            this.m_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_name.FormattingEnabled = true;
            this.m_name.Location = new System.Drawing.Point(116, 17);
            this.m_name.Name = "m_name";
            this.m_name.Size = new System.Drawing.Size(121, 21);
            this.m_name.TabIndex = 4;
            // 
            // projectReportViewBindingSource2
            // 
            this.projectReportViewBindingSource2.DataMember = "ProjectReportView";
            this.projectReportViewBindingSource2.DataSource = this.UNdbDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الأم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "تاريخ المنح بين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "فئة المصاب";
            // 
            // category_combo
            // 
            this.category_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category_combo.FormattingEnabled = true;
            this.category_combo.Items.AddRange(new object[] {
            "مدني",
            "عسكري"});
            this.category_combo.Location = new System.Drawing.Point(627, 15);
            this.category_combo.Name = "category_combo";
            this.category_combo.Size = new System.Drawing.Size(121, 21);
            this.category_combo.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // given_start_picker1
            // 
            this.given_start_picker1.Location = new System.Drawing.Point(316, 18);
            this.given_start_picker1.Name = "given_start_picker1";
            this.given_start_picker1.Size = new System.Drawing.Size(200, 20);
            this.given_start_picker1.TabIndex = 11;
            // 
            // given_end_picker1
            // 
            this.given_end_picker1.Location = new System.Drawing.Point(91, 18);
            this.given_end_picker1.Name = "given_end_picker1";
            this.given_end_picker1.Size = new System.Drawing.Size(200, 20);
            this.given_end_picker1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "و";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "الجهة المانحة";
            // 
            // given_side_combo1
            // 
            this.given_side_combo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.given_side_combo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.given_side_combo1.DataSource = this.projectReportViewBindingSource1;
            this.given_side_combo1.DisplayMember = "given_side";
            this.given_side_combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.given_side_combo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.given_side_combo1.FormattingEnabled = true;
            this.given_side_combo1.Location = new System.Drawing.Point(100, 18);
            this.given_side_combo1.Name = "given_side_combo1";
            this.given_side_combo1.Size = new System.Drawing.Size(121, 21);
            this.given_side_combo1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "و";
            // 
            // given_end_picker2
            // 
            this.given_end_picker2.Location = new System.Drawing.Point(94, 12);
            this.given_end_picker2.Name = "given_end_picker2";
            this.given_end_picker2.Size = new System.Drawing.Size(200, 20);
            this.given_end_picker2.TabIndex = 20;
            // 
            // given_start_picker2
            // 
            this.given_start_picker2.Location = new System.Drawing.Point(333, 12);
            this.given_start_picker2.Name = "given_start_picker2";
            this.given_start_picker2.Size = new System.Drawing.Size(200, 20);
            this.given_start_picker2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "تاريخ المنح بين";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "و";
            // 
            // given_end_picker3
            // 
            this.given_end_picker3.Location = new System.Drawing.Point(90, 15);
            this.given_end_picker3.Name = "given_end_picker3";
            this.given_end_picker3.Size = new System.Drawing.Size(200, 20);
            this.given_end_picker3.TabIndex = 28;
            // 
            // given_start_picker3
            // 
            this.given_start_picker3.Location = new System.Drawing.Point(317, 15);
            this.given_start_picker3.Name = "given_start_picker3";
            this.given_start_picker3.Size = new System.Drawing.Size(200, 20);
            this.given_start_picker3.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "تاريخ المنح بين";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(740, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "الجهة المانحة";
            // 
            // given_side_combo2
            // 
            this.given_side_combo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.given_side_combo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.given_side_combo2.DataSource = this.projectReportViewBindingSource1;
            this.given_side_combo2.DisplayMember = "given_side";
            this.given_side_combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.given_side_combo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.given_side_combo2.FormattingEnabled = true;
            this.given_side_combo2.Location = new System.Drawing.Point(613, 12);
            this.given_side_combo2.Name = "given_side_combo2";
            this.given_side_combo2.Size = new System.Drawing.Size(121, 21);
            this.given_side_combo2.TabIndex = 23;
            // 
            // given_date_panel
            // 
            this.given_date_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.given_date_panel.Controls.Add(this.button4);
            this.given_date_panel.Controls.Add(this.label8);
            this.given_date_panel.Controls.Add(this.given_start_picker2);
            this.given_date_panel.Controls.Add(this.given_end_picker2);
            this.given_date_panel.Controls.Add(this.label7);
            this.given_date_panel.Location = new System.Drawing.Point(357, 12);
            this.given_date_panel.Name = "given_date_panel";
            this.given_date_panel.Size = new System.Drawing.Size(635, 55);
            this.given_date_panel.TabIndex = 31;
            this.given_date_panel.Visible = false;
            // 
            // category_panel
            // 
            this.category_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_panel.Controls.Add(this.button2);
            this.category_panel.Controls.Add(this.category_combo);
            this.category_panel.Controls.Add(this.label4);
            this.category_panel.Controls.Add(this.label3);
            this.category_panel.Controls.Add(this.given_start_picker1);
            this.category_panel.Controls.Add(this.given_end_picker1);
            this.category_panel.Controls.Add(this.label5);
            this.category_panel.Location = new System.Drawing.Point(310, 13);
            this.category_panel.Name = "category_panel";
            this.category_panel.Size = new System.Drawing.Size(841, 57);
            this.category_panel.TabIndex = 31;
            this.category_panel.Visible = false;
            // 
            // given_side_panel
            // 
            this.given_side_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.given_side_panel.Controls.Add(this.button3);
            this.given_side_panel.Controls.Add(this.given_side_combo1);
            this.given_side_panel.Controls.Add(this.label6);
            this.given_side_panel.Location = new System.Drawing.Point(456, 18);
            this.given_side_panel.Name = "given_side_panel";
            this.given_side_panel.Size = new System.Drawing.Size(340, 53);
            this.given_side_panel.TabIndex = 31;
            this.given_side_panel.Visible = false;
            // 
            // fullname_panel
            // 
            this.fullname_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullname_panel.Controls.Add(this.button1);
            this.fullname_panel.Controls.Add(this.fullname_combo);
            this.fullname_panel.Controls.Add(this.label1);
            this.fullname_panel.Controls.Add(this.m_name);
            this.fullname_panel.Controls.Add(this.label2);
            this.fullname_panel.Location = new System.Drawing.Point(392, 22);
            this.fullname_panel.Name = "fullname_panel";
            this.fullname_panel.Size = new System.Drawing.Size(549, 56);
            this.fullname_panel.TabIndex = 31;
            // 
            // given_date_side_panel
            // 
            this.given_date_side_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.given_date_side_panel.Controls.Add(this.button5);
            this.given_date_side_panel.Controls.Add(this.given_side_combo2);
            this.given_date_side_panel.Controls.Add(this.label11);
            this.given_date_side_panel.Controls.Add(this.label10);
            this.given_date_side_panel.Controls.Add(this.given_start_picker3);
            this.given_date_side_panel.Controls.Add(this.label9);
            this.given_date_side_panel.Controls.Add(this.given_end_picker3);
            this.given_date_side_panel.Location = new System.Drawing.Point(317, 10);
            this.given_date_side_panel.Name = "given_date_side_panel";
            this.given_date_side_panel.Size = new System.Drawing.Size(823, 55);
            this.given_date_side_panel.TabIndex = 31;
            this.given_date_side_panel.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "اسم المصاب",
            "فئة المصاب و تاريخ المنح",
            "الجهة المانحة",
            "تاريخ المنح",
            "الجهة المانحة و تاريخ المنح"});
            this.comboBox1.Location = new System.Drawing.Point(152, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "عرض حسب";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1179, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "عرض الجميع";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProjectReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1370, 529);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.given_date_side_panel);
            this.Controls.Add(this.given_date_panel);
            this.Controls.Add(this.category_panel);
            this.Controls.Add(this.given_side_panel);
            this.Controls.Add(this.fullname_panel);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "ProjectReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير المشاريع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectReportViewBindingSource2)).EndInit();
            this.given_date_panel.ResumeLayout(false);
            this.given_date_panel.PerformLayout();
            this.category_panel.ResumeLayout(false);
            this.category_panel.PerformLayout();
            this.given_side_panel.ResumeLayout(false);
            this.given_side_panel.PerformLayout();
            this.fullname_panel.ResumeLayout(false);
            this.fullname_panel.PerformLayout();
            this.given_date_side_panel.ResumeLayout(false);
            this.given_date_side_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProjectReportViewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.ProjectReportViewTableAdapter ProjectReportViewTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fullname_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projectReportViewBindingSource1;
        private System.Windows.Forms.ComboBox m_name;
        private System.Windows.Forms.BindingSource projectReportViewBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category_combo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker given_start_picker1;
        private System.Windows.Forms.DateTimePicker given_end_picker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox given_side_combo1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker given_end_picker2;
        private System.Windows.Forms.DateTimePicker given_start_picker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker given_end_picker3;
        private System.Windows.Forms.DateTimePicker given_start_picker3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox given_side_combo2;
        private System.Windows.Forms.Panel given_date_panel;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.Panel given_side_panel;
        private System.Windows.Forms.Panel fullname_panel;
        private System.Windows.Forms.Panel given_date_side_panel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
    }
}