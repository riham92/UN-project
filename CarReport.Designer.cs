namespace UN
{
    partial class CarReport
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
            this.carReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carReportViewTableAdapter = new UN.UNdbDataSet1TableAdapters.carReportViewTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.full_name_combo = new System.Windows.Forms.ComboBox();
            this.carReportViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uNdbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.carReportViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.quarterCombo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mother_name_combo = new System.Windows.Forms.ComboBox();
            this.carReportViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.name_panel = new System.Windows.Forms.Panel();
            this.quarter_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.category_panel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.category_combo1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.category_quarter_panel = new System.Windows.Forms.Panel();
            this.category_combo2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.quarter_combo2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource3)).BeginInit();
            this.name_panel.SuspendLayout();
            this.quarter_panel.SuspendLayout();
            this.category_panel.SuspendLayout();
            this.category_quarter_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // carReportViewBindingSource
            // 
            this.carReportViewBindingSource.DataMember = "carReportView";
            this.carReportViewBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.carReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(235, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // carReportViewTableAdapter
            // 
            this.carReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // full_name_combo
            // 
            this.full_name_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.full_name_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.full_name_combo.DataSource = this.carReportViewBindingSource2;
            this.full_name_combo.DisplayMember = "name";
            this.full_name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.full_name_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.full_name_combo.FormattingEnabled = true;
            this.full_name_combo.Location = new System.Drawing.Point(384, 33);
            this.full_name_combo.Name = "full_name_combo";
            this.full_name_combo.Size = new System.Drawing.Size(121, 21);
            this.full_name_combo.TabIndex = 2;
            // 
            // carReportViewBindingSource2
            // 
            this.carReportViewBindingSource2.DataMember = "carReportView";
            this.carReportViewBindingSource2.DataSource = this.uNdbDataSet1BindingSource;
            // 
            // uNdbDataSet1BindingSource
            // 
            this.uNdbDataSet1BindingSource.DataSource = this.UNdbDataSet1;
            this.uNdbDataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "الاسم الثلاثي";
            // 
            // carReportViewBindingSource1
            // 
            this.carReportViewBindingSource1.DataMember = "carReportView";
            this.carReportViewBindingSource1.DataSource = this.uNdbDataSet1BindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "الربع";
            // 
            // quarterCombo
            // 
            this.quarterCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quarterCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.quarterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quarterCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quarterCombo.FormattingEnabled = true;
            this.quarterCombo.Items.AddRange(new object[] {
            "أول",
            "ثان",
            "ثالث",
            "رابع"});
            this.quarterCombo.Location = new System.Drawing.Point(129, 30);
            this.quarterCombo.Name = "quarterCombo";
            this.quarterCombo.Size = new System.Drawing.Size(121, 21);
            this.quarterCombo.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "اسم الأم";
            // 
            // mother_name_combo
            // 
            this.mother_name_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mother_name_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mother_name_combo.DataSource = this.carReportViewBindingSource3;
            this.mother_name_combo.DisplayMember = "mother_name";
            this.mother_name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mother_name_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mother_name_combo.FormattingEnabled = true;
            this.mother_name_combo.Location = new System.Drawing.Point(154, 33);
            this.mother_name_combo.Name = "mother_name_combo";
            this.mother_name_combo.Size = new System.Drawing.Size(121, 21);
            this.mother_name_combo.TabIndex = 7;
            // 
            // carReportViewBindingSource3
            // 
            this.carReportViewBindingSource3.DataMember = "carReportView";
            this.carReportViewBindingSource3.DataSource = this.uNdbDataSet1BindingSource;
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
            "فئة متضرر",
            "ربع و فئة متضرر"});
            this.comboBox4.Location = new System.Drawing.Point(258, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // name_panel
            // 
            this.name_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_panel.Controls.Add(this.full_name_combo);
            this.name_panel.Controls.Add(this.label1);
            this.name_panel.Controls.Add(this.label3);
            this.name_panel.Controls.Add(this.button1);
            this.name_panel.Controls.Add(this.mother_name_combo);
            this.name_panel.Location = new System.Drawing.Point(396, 32);
            this.name_panel.Name = "name_panel";
            this.name_panel.Size = new System.Drawing.Size(618, 73);
            this.name_panel.TabIndex = 10;
            // 
            // quarter_panel
            // 
            this.quarter_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quarter_panel.Controls.Add(this.button2);
            this.quarter_panel.Controls.Add(this.quarterCombo);
            this.quarter_panel.Controls.Add(this.label2);
            this.quarter_panel.Location = new System.Drawing.Point(395, 30);
            this.quarter_panel.Name = "quarter_panel";
            this.quarter_panel.Size = new System.Drawing.Size(332, 83);
            this.quarter_panel.TabIndex = 11;
            this.quarter_panel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "عرض حسب";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1029, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "عرض الجميع";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // category_panel
            // 
            this.category_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_panel.Controls.Add(this.button4);
            this.category_panel.Controls.Add(this.category_combo1);
            this.category_panel.Controls.Add(this.label5);
            this.category_panel.Location = new System.Drawing.Point(399, 26);
            this.category_panel.Name = "category_panel";
            this.category_panel.Size = new System.Drawing.Size(343, 83);
            this.category_panel.TabIndex = 14;
            this.category_panel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
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
            this.category_combo1.Location = new System.Drawing.Point(129, 30);
            this.category_combo1.Name = "category_combo1";
            this.category_combo1.Size = new System.Drawing.Size(121, 21);
            this.category_combo1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "فئة المتضرر";
            // 
            // category_quarter_panel
            // 
            this.category_quarter_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_quarter_panel.Controls.Add(this.category_combo2);
            this.category_quarter_panel.Controls.Add(this.label6);
            this.category_quarter_panel.Controls.Add(this.label7);
            this.category_quarter_panel.Controls.Add(this.button5);
            this.category_quarter_panel.Controls.Add(this.quarter_combo2);
            this.category_quarter_panel.Location = new System.Drawing.Point(395, 28);
            this.category_quarter_panel.Name = "category_quarter_panel";
            this.category_quarter_panel.Size = new System.Drawing.Size(618, 73);
            this.category_quarter_panel.TabIndex = 11;
            this.category_quarter_panel.Visible = false;
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
            this.category_combo2.Location = new System.Drawing.Point(384, 33);
            this.category_combo2.Name = "category_combo2";
            this.category_combo2.Size = new System.Drawing.Size(121, 21);
            this.category_combo2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "فئة المتضرر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "الربع";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.quarter_combo2.Location = new System.Drawing.Point(154, 33);
            this.quarter_combo2.Name = "quarter_combo2";
            this.quarter_combo2.Size = new System.Drawing.Size(121, 21);
            this.quarter_combo2.TabIndex = 7;
            // 
            // CarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 571);
            this.Controls.Add(this.category_quarter_panel);
            this.Controls.Add(this.category_panel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quarter_panel);
            this.Controls.Add(this.name_panel);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "CarReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير السيارات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportViewBindingSource3)).EndInit();
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
        private System.Windows.Forms.BindingSource carReportViewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.carReportViewTableAdapter carReportViewTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox full_name_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource carReportViewBindingSource1;
        private System.Windows.Forms.BindingSource uNdbDataSet1BindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox quarterCombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mother_name_combo;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Panel name_panel;
        private System.Windows.Forms.Panel quarter_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource carReportViewBindingSource2;
        private System.Windows.Forms.BindingSource carReportViewBindingSource3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel category_panel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox category_combo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel category_quarter_panel;
        private System.Windows.Forms.ComboBox category_combo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox quarter_combo2;
    }
}