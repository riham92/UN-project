namespace UN
{
    partial class militaryreport
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
            this.militaryreportviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.militaryreportviewTableAdapter = new UN.UNdbDataSet1TableAdapters.militaryreportviewTableAdapter();
            this.full_name_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.military_combo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.militaryreportviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryreportviewBindingSource
            // 
            this.militaryreportviewBindingSource.DataMember = "militaryreportview";
            this.militaryreportviewBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.militaryreportviewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report12.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 118);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // militaryreportviewTableAdapter
            // 
            this.militaryreportviewTableAdapter.ClearBeforeFill = true;
            // 
            // full_name_combo
            // 
            this.full_name_combo.DataSource = this.militaryreportviewBindingSource;
            this.full_name_combo.DisplayMember = "full_name";
            this.full_name_combo.FormattingEnabled = true;
            this.full_name_combo.Location = new System.Drawing.Point(443, 29);
            this.full_name_combo.Name = "full_name_combo";
            this.full_name_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.full_name_combo.Size = new System.Drawing.Size(121, 21);
            this.full_name_combo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "الاسم الثلاثي";
            // 
            // military_combo
            // 
            this.military_combo.DataSource = this.militaryreportviewBindingSource;
            this.military_combo.DisplayMember = "miltary_number";
            this.military_combo.FormattingEnabled = true;
            this.military_combo.Location = new System.Drawing.Point(193, 31);
            this.military_combo.Name = "military_combo";
            this.military_combo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.military_combo.Size = new System.Drawing.Size(121, 21);
            this.military_combo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "الرقم العسكري";
            // 
            // militaryreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.military_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.full_name_combo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "militaryreport";
            this.Text = "militaryreport";
            this.Load += new System.EventHandler(this.militaryreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryreportviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource militaryreportviewBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.militaryreportviewTableAdapter militaryreportviewTableAdapter;
        private System.Windows.Forms.ComboBox full_name_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox military_combo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}