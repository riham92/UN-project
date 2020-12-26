namespace UN
{
    partial class projectrepocs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProjectReportViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjectReportViewTableAdapter = new UN.UNdbDataSet1TableAdapters.ProjectReportViewTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.full_name_panel = new System.Windows.Forms.Panel();
            this.given_side_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            this.full_name_panel.SuspendLayout();
            this.given_side_panel.SuspendLayout();
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
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ProjectReportViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(922, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjectReportViewTableAdapter
            // 
            this.ProjectReportViewTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ProjectReportViewBindingSource;
            this.comboBox1.DisplayMember = "full_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ProjectReportViewBindingSource;
            this.comboBox2.DisplayMember = "national_num";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "اسم المصاب ",
            "الجهه المانحه",
            "الجهه المانحه وتاريخ المنح"});
            this.comboBox3.Location = new System.Drawing.Point(723, 44);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "الرقم الوطني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(863, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "عرض حسب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "الجهه المانحه";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.ProjectReportViewBindingSource;
            this.comboBox4.DisplayMember = "given_side";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(267, 27);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // full_name_panel
            // 
            this.full_name_panel.Controls.Add(this.label1);
            this.full_name_panel.Controls.Add(this.comboBox1);
            this.full_name_panel.Controls.Add(this.label2);
            this.full_name_panel.Controls.Add(this.comboBox2);
            this.full_name_panel.Controls.Add(this.button1);
            this.full_name_panel.Location = new System.Drawing.Point(78, 0);
            this.full_name_panel.Name = "full_name_panel";
            this.full_name_panel.Size = new System.Drawing.Size(532, 86);
            this.full_name_panel.TabIndex = 11;
            // 
            // given_side_panel
            // 
            this.given_side_panel.Controls.Add(this.label4);
            this.given_side_panel.Controls.Add(this.comboBox4);
            this.given_side_panel.Controls.Add(this.button2);
            this.given_side_panel.Location = new System.Drawing.Point(78, 12);
            this.given_side_panel.Name = "given_side_panel";
            this.given_side_panel.Size = new System.Drawing.Size(639, 77);
            this.given_side_panel.TabIndex = 12;
            // 
            // projectrepocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 382);
            this.Controls.Add(this.given_side_panel);
            this.Controls.Add(this.full_name_panel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "projectrepocs";
            this.Text = "projectrepocs";
            this.Load += new System.EventHandler(this.projectrepocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectReportViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            this.full_name_panel.ResumeLayout(false);
            this.full_name_panel.PerformLayout();
            this.given_side_panel.ResumeLayout(false);
            this.given_side_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProjectReportViewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.ProjectReportViewTableAdapter ProjectReportViewTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel full_name_panel;
        private System.Windows.Forms.Panel given_side_panel;
    }
}