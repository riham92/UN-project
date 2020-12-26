namespace UN
{
    partial class civilreport
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
            this.civilreportviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.civilreportviewTableAdapter = new UN.UNdbDataSet1TableAdapters.civilreportviewTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.full_name_combo = new System.Windows.Forms.ComboBox();
            this.uNdbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uNdbDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.national_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.civilreportviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // civilreportviewBindingSource
            // 
            this.civilreportviewBindingSource.DataMember = "civilreportview";
            this.civilreportviewBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.civilreportviewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(112, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1216, 585);
            this.reportViewer1.TabIndex = 0;
            // 
            // civilreportviewTableAdapter
            // 
            this.civilreportviewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم الثلاثي";
            // 
            // full_name_combo
            // 
            this.full_name_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.full_name_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.full_name_combo.DataSource = this.civilreportviewBindingSource;
            this.full_name_combo.DisplayMember = "full_name";
            this.full_name_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.full_name_combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.full_name_combo.FormattingEnabled = true;
            this.full_name_combo.Location = new System.Drawing.Point(357, 20);
            this.full_name_combo.Name = "full_name_combo";
            this.full_name_combo.Size = new System.Drawing.Size(140, 21);
            this.full_name_combo.TabIndex = 2;
            // 
            // uNdbDataSet1BindingSource
            // 
            this.uNdbDataSet1BindingSource.DataSource = this.UNdbDataSet1;
            this.uNdbDataSet1BindingSource.Position = 0;
            // 
            // uNdbDataSet1BindingSource1
            // 
            this.uNdbDataSet1BindingSource1.DataSource = this.UNdbDataSet1;
            this.uNdbDataSet1BindingSource1.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "الرقم الوطني";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.national_combo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.full_name_combo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(420, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 64);
            this.panel1.TabIndex = 6;
            // 
            // national_combo
            // 
            this.national_combo.DataSource = this.civilreportviewBindingSource;
            this.national_combo.DisplayMember = "national_num";
            this.national_combo.FormattingEnabled = true;
            this.national_combo.Location = new System.Drawing.Point(128, 20);
            this.national_combo.Name = "national_combo";
            this.national_combo.Size = new System.Drawing.Size(121, 21);
            this.national_combo.TabIndex = 6;
            // 
            // civilreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1370, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Name = "civilreport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الإصابات المدنية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.civilreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.civilreportviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet1BindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource civilreportviewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.civilreportviewTableAdapter civilreportviewTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox full_name_combo;
        private System.Windows.Forms.BindingSource uNdbDataSet1BindingSource;
        private System.Windows.Forms.BindingSource uNdbDataSet1BindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox national_combo;
    }
}