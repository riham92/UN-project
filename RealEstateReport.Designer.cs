namespace UN
{
    partial class RealEstateReport
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
            this.RealEtateReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RealEtateReportViewTableAdapter = new UN.UNdbDataSet1TableAdapters.RealEtateReportViewTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.fullname_combo = new System.Windows.Forms.ComboBox();
            this.realEtateReportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.mother_name_combo = new System.Windows.Forms.ComboBox();
            this.realEtateReportViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.quarter_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.name_panel = new System.Windows.Forms.Panel();
            this.quarter_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.category_combo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quarter_combo2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.category_combo2 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.category_panel = new System.Windows.Forms.Panel();
            this.category_quarter_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RealEtateReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEtateReportViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEtateReportViewBindingSource2)).BeginInit();
            this.name_panel.SuspendLayout();
            this.quarter_panel.SuspendLayout();
            this.category_panel.SuspendLayout();
            this.category_quarter_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RealEtateReportViewBindingSource
            // 
            this.RealEtateReportViewBindingSource.DataMember = "RealEtateReportView";
            this.RealEtateReportViewBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RealEtateReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(275, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(790, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // RealEtateReportViewTableAdapter
            // 
            this.RealEtateReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 32);
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
            this.fullname_combo.DataSource = this.realEtateReportViewBindingSource1;
            this.fullname_combo.DisplayMember = "name";
            this.fullname_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fullname_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fullname_combo.FormattingEnabled = true;
            this.fullname_combo.Location = new System.Drawing.Point(335, 34);
            this.fullname_combo.Name = "fullname_combo";
            this.fullname_combo.Size = new System.Drawing.Size(121, 21);
            this.fullname_combo.TabIndex = 2;
            // 
            // realEtateReportViewBindingSource1
            // 
            this.realEtateReportViewBindingSource1.DataMember = "RealEtateReportView";
            this.realEtateReportViewBindingSource1.DataSource = this.UNdbDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاسم الثلاثي";
            // 
            // mother_name_combo
            // 
            this.mother_name_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mother_name_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mother_name_combo.DataSource = this.realEtateReportViewBindingSource2;
            this.mother_name_combo.DisplayMember = "mother_name";
            this.mother_name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mother_name_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mother_name_combo.FormattingEnabled = true;
            this.mother_name_combo.Location = new System.Drawing.Point(121, 34);
            this.mother_name_combo.Name = "mother_name_combo";
            this.mother_name_combo.Size = new System.Drawing.Size(121, 21);
            this.mother_name_combo.TabIndex = 4;
            // 
            // realEtateReportViewBindingSource2
            // 
            this.realEtateReportViewBindingSource2.DataMember = "RealEtateReportView";
            this.realEtateReportViewBindingSource2.DataSource = this.UNdbDataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الأم";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quarter_combo
            // 
            this.quarter_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quarter_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.quarter_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quarter_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quarter_combo.FormattingEnabled = true;
            this.quarter_combo.Items.AddRange(new object[] {
            "أول",
            "ثان",
            "ثالث",
            "رابع"});
            this.quarter_combo.Location = new System.Drawing.Point(126, 26);
            this.quarter_combo.Name = "quarter_combo";
            this.quarter_combo.Size = new System.Drawing.Size(121, 21);
            this.quarter_combo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "الربع";
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "اسم متضرر",
            "ربع",
            "فئة المتضرر",
            "فئة المتضرر و الربع"});
            this.comboBox4.Location = new System.Drawing.Point(227, 43);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "عرض حسب";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(967, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "عرض الجميع";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // name_panel
            // 
            this.name_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_panel.Controls.Add(this.button1);
            this.name_panel.Controls.Add(this.label2);
            this.name_panel.Controls.Add(this.fullname_combo);
            this.name_panel.Controls.Add(this.label1);
            this.name_panel.Controls.Add(this.mother_name_combo);
            this.name_panel.Location = new System.Drawing.Point(386, 16);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(546, 82);
            this.name_panel.TabIndex = 12;
            // 
            // quarter_panel
            // 
            this.quarter_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quarter_panel.Controls.Add(this.label3);
            this.quarter_panel.Controls.Add(this.quarter_combo);
            this.quarter_panel.Controls.Add(this.button2);
            this.quarter_panel.Location = new System.Drawing.Point(504, 12);
            this.quarter_panel.Name = "quarter_panel";
            this.quarter_panel.Size = new System.Drawing.Size(334, 70);
            this.quarter_panel.TabIndex = 13;
            this.quarter_panel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // category_combo1
            // 
            this.category_combo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_combo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category_combo1.FormattingEnabled = true;
            this.category_combo1.Items.AddRange(new object[] {
            "مدني",
            "عسكري"});
            this.category_combo1.Location = new System.Drawing.Point(91, 25);
            this.category_combo1.Name = "category_combo1";
            this.category_combo1.Size = new System.Drawing.Size(121, 21);
            this.category_combo1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "فئة المتضرر";
            // 
            // quarter_combo2
            // 
            this.quarter_combo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quarter_combo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.quarter_combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quarter_combo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quarter_combo2.FormattingEnabled = true;
            this.quarter_combo2.Items.AddRange(new object[] {
            "أول",
            "ثان",
            "ثالث",
            "رابع"});
            this.quarter_combo2.Location = new System.Drawing.Point(145, 15);
            this.quarter_combo2.Name = "quarter_combo2";
            this.quarter_combo2.Size = new System.Drawing.Size(121, 21);
            this.quarter_combo2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "الربع";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "فئة المتضرر";
            // 
            // category_combo2
            // 
            this.category_combo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_combo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_combo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.category_combo2.FormattingEnabled = true;
            this.category_combo2.Items.AddRange(new object[] {
            "مدني",
            "عسكري"});
            this.category_combo2.Location = new System.Drawing.Point(354, 17);
            this.category_combo2.Name = "category_combo2";
            this.category_combo2.Size = new System.Drawing.Size(121, 21);
            this.category_combo2.TabIndex = 21;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(40, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "بحث";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // category_panel
            // 
            this.category_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_panel.Controls.Add(this.label5);
            this.category_panel.Controls.Add(this.category_combo1);
            this.category_panel.Controls.Add(this.button4);
            this.category_panel.Location = new System.Drawing.Point(526, 8);
            this.category_panel.Name = "category_panel";
            this.category_panel.Size = new System.Drawing.Size(295, 70);
            this.category_panel.TabIndex = 23;
            this.category_panel.Visible = false;
            // 
            // category_quarter_panel
            // 
            this.category_quarter_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_quarter_panel.Controls.Add(this.label7);
            this.category_quarter_panel.Controls.Add(this.category_combo2);
            this.category_quarter_panel.Controls.Add(this.button6);
            this.category_quarter_panel.Controls.Add(this.label6);
            this.category_quarter_panel.Controls.Add(this.quarter_combo2);
            this.category_quarter_panel.Location = new System.Drawing.Point(371, 24);
            this.category_quarter_panel.Name = "category_quarter_panel";
            this.category_quarter_panel.Size = new System.Drawing.Size(572, 56);
            this.category_quarter_panel.TabIndex = 24;
            this.category_quarter_panel.Visible = false;
            // 
            // RealEstateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 547);
            this.Controls.Add(this.category_quarter_panel);
            this.Controls.Add(this.category_panel);
            this.Controls.Add(this.quarter_panel);
            this.Controls.Add(this.name_panel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "RealEstateReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير أضرار العقارات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RealEstateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealEtateReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEtateReportViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEtateReportViewBindingSource2)).EndInit();
            this.name_panel.ResumeLayout(false);
            this.name_panel.PerformLayout();
            this.quarter_panel.ResumeLayout(false);
            this.quarter_panel.PerformLayout();
            this.category_panel.ResumeLayout(false);
            this.category_panel.PerformLayout();
            this.category_quarter_panel.ResumeLayout(false);
            this.category_quarter_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RealEtateReportViewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.RealEtateReportViewTableAdapter RealEtateReportViewTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fullname_combo;
        private System.Windows.Forms.BindingSource realEtateReportViewBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox mother_name_combo;
        private System.Windows.Forms.BindingSource realEtateReportViewBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox quarter_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel name_panel;
        private System.Windows.Forms.Panel quarter_panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox category_combo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox quarter_combo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox category_combo2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.Panel category_quarter_panel;
    }
}