namespace UN
{
    partial class OrgReport
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
            this.org_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UNdbDataSet1 = new UN.UNdbDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visitorNameCombo = new System.Windows.Forms.ComboBox();
            this.orgtableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.org_tableTableAdapter = new UN.UNdbDataSet1TableAdapters.org_tableTableAdapter();
            this.uNdbDataSet = new UN.UNdbDataSet1();
            this.uNdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orgtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.visitor_panel = new System.Windows.Forms.Panel();
            this.come_date_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comeStartPicker = new System.Windows.Forms.DateTimePicker();
            this.comeEndPicker = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.visit_date_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.visitEndPicker1 = new System.Windows.Forms.DateTimePicker();
            this.visitStartPicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.org_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orgNameCombo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.org_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource)).BeginInit();
            this.visitor_panel.SuspendLayout();
            this.come_date_panel.SuspendLayout();
            this.visit_date_panel.SuspendLayout();
            this.org_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // org_tableBindingSource
            // 
            this.org_tableBindingSource.DataMember = "org_table";
            this.org_tableBindingSource.DataSource = this.UNdbDataSet1;
            // 
            // UNdbDataSet1
            // 
            this.UNdbDataSet1.DataSetName = "UNdbDataSet1";
            this.UNdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.org_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(389, 187);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(619, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(29, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم الزائر";
            // 
            // visitorNameCombo
            // 
            this.visitorNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.visitorNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.visitorNameCombo.DataSource = this.orgtableBindingSource1;
            this.visitorNameCombo.DisplayMember = "visitor_name";
            this.visitorNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitorNameCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitorNameCombo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.visitorNameCombo.FormattingEnabled = true;
            this.visitorNameCombo.Location = new System.Drawing.Point(135, 22);
            this.visitorNameCombo.Name = "visitorNameCombo";
            this.visitorNameCombo.Size = new System.Drawing.Size(121, 21);
            this.visitorNameCombo.TabIndex = 3;
            // 
            // orgtableBindingSource1
            // 
            this.orgtableBindingSource1.DataMember = "org_table";
            this.orgtableBindingSource1.DataSource = this.UNdbDataSet1;
            // 
            // org_tableTableAdapter
            // 
            this.org_tableTableAdapter.ClearBeforeFill = true;
            // 
            // uNdbDataSet
            // 
            this.uNdbDataSet.DataSetName = "UNdbDataSet4";
            this.uNdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNdbDataSetBindingSource
            // 
            this.uNdbDataSetBindingSource.DataSource = this.uNdbDataSet;
            this.uNdbDataSetBindingSource.Position = 0;
            // 
            // orgtableBindingSource
            // 
            this.orgtableBindingSource.DataMember = "org_table";
            this.orgtableBindingSource.DataSource = this.uNdbDataSetBindingSource;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(919, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "عرض الجميع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // visitor_panel
            // 
            this.visitor_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visitor_panel.Controls.Add(this.button1);
            this.visitor_panel.Controls.Add(this.label1);
            this.visitor_panel.Controls.Add(this.visitorNameCombo);
            this.visitor_panel.Location = new System.Drawing.Point(497, 12);
            this.visitor_panel.Name = "visitor_panel";
            this.visitor_panel.Size = new System.Drawing.Size(371, 66);
            this.visitor_panel.TabIndex = 5;
            this.visitor_panel.Visible = false;
            // 
            // come_date_panel
            // 
            this.come_date_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.come_date_panel.Controls.Add(this.label6);
            this.come_date_panel.Controls.Add(this.comeStartPicker);
            this.come_date_panel.Controls.Add(this.comeEndPicker);
            this.come_date_panel.Controls.Add(this.button5);
            this.come_date_panel.Controls.Add(this.label4);
            this.come_date_panel.Location = new System.Drawing.Point(394, 97);
            this.come_date_panel.Name = "come_date_panel";
            this.come_date_panel.Size = new System.Drawing.Size(619, 66);
            this.come_date_panel.TabIndex = 6;
            this.come_date_panel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(296, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "و";
            // 
            // comeStartPicker
            // 
            this.comeStartPicker.Location = new System.Drawing.Point(321, 25);
            this.comeStartPicker.Name = "comeStartPicker";
            this.comeStartPicker.Size = new System.Drawing.Size(200, 20);
            this.comeStartPicker.TabIndex = 8;
            // 
            // comeEndPicker
            // 
            this.comeEndPicker.Location = new System.Drawing.Point(85, 25);
            this.comeEndPicker.Name = "comeEndPicker";
            this.comeEndPicker.Size = new System.Drawing.Size(200, 20);
            this.comeEndPicker.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(4, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "بحث";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(527, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "تاريخ الورود بين";
            // 
            // visit_date_panel
            // 
            this.visit_date_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visit_date_panel.Controls.Add(this.label5);
            this.visit_date_panel.Controls.Add(this.visitEndPicker1);
            this.visit_date_panel.Controls.Add(this.visitStartPicker1);
            this.visit_date_panel.Controls.Add(this.button4);
            this.visit_date_panel.Controls.Add(this.label3);
            this.visit_date_panel.Location = new System.Drawing.Point(389, 97);
            this.visit_date_panel.Name = "visit_date_panel";
            this.visit_date_panel.Size = new System.Drawing.Size(619, 66);
            this.visit_date_panel.TabIndex = 6;
            this.visit_date_panel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(296, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "و";
            // 
            // visitEndPicker1
            // 
            this.visitEndPicker1.Location = new System.Drawing.Point(85, 19);
            this.visitEndPicker1.Name = "visitEndPicker1";
            this.visitEndPicker1.Size = new System.Drawing.Size(200, 20);
            this.visitEndPicker1.TabIndex = 7;
            // 
            // visitStartPicker1
            // 
            this.visitStartPicker1.Location = new System.Drawing.Point(321, 19);
            this.visitStartPicker1.Name = "visitStartPicker1";
            this.visitStartPicker1.Size = new System.Drawing.Size(200, 20);
            this.visitStartPicker1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(4, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "بحث";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(527, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاريخ الزيارة بين";
            // 
            // org_panel
            // 
            this.org_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.org_panel.Controls.Add(this.button3);
            this.org_panel.Controls.Add(this.label2);
            this.org_panel.Controls.Add(this.orgNameCombo);
            this.org_panel.Location = new System.Drawing.Point(501, 12);
            this.org_panel.Name = "org_panel";
            this.org_panel.Size = new System.Drawing.Size(371, 66);
            this.org_panel.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(28, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم المنظمة";
            // 
            // orgNameCombo
            // 
            this.orgNameCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orgNameCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orgNameCombo.DataSource = this.orgtableBindingSource1;
            this.orgNameCombo.DisplayMember = "org_name";
            this.orgNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgNameCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orgNameCombo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.orgNameCombo.FormattingEnabled = true;
            this.orgNameCombo.Location = new System.Drawing.Point(134, 22);
            this.orgNameCombo.Name = "orgNameCombo";
            this.orgNameCombo.Size = new System.Drawing.Size(121, 21);
            this.orgNameCombo.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "اسم الزائر",
            "اسم المنظمة",
            "تاريخ الورود",
            "تاريخ الزيارة"});
            this.comboBox1.Location = new System.Drawing.Point(359, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(272, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "عرض حسب";
            // 
            // OrgReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1320, 680);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.come_date_panel);
            this.Controls.Add(this.visit_date_panel);
            this.Controls.Add(this.org_panel);
            this.Controls.Add(this.visitor_panel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OrgReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تقرير المنظمات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrgReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.org_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UNdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgtableBindingSource)).EndInit();
            this.visitor_panel.ResumeLayout(false);
            this.visitor_panel.PerformLayout();
            this.come_date_panel.ResumeLayout(false);
            this.come_date_panel.PerformLayout();
            this.visit_date_panel.ResumeLayout(false);
            this.visit_date_panel.PerformLayout();
            this.org_panel.ResumeLayout(false);
            this.org_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox visitorNameCombo;
        private System.Windows.Forms.BindingSource org_tableBindingSource;
        private UNdbDataSet1 UNdbDataSet1;
        private UNdbDataSet1TableAdapters.org_tableTableAdapter org_tableTableAdapter;
        private System.Windows.Forms.BindingSource orgtableBindingSource;
        private System.Windows.Forms.BindingSource uNdbDataSetBindingSource;
        private UNdbDataSet1 uNdbDataSet;
        private System.Windows.Forms.BindingSource orgtableBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel visitor_panel;
        private System.Windows.Forms.Panel come_date_panel;
        private System.Windows.Forms.DateTimePicker comeStartPicker;
        private System.Windows.Forms.DateTimePicker comeEndPicker;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel visit_date_panel;
        private System.Windows.Forms.DateTimePicker visitEndPicker1;
        private System.Windows.Forms.DateTimePicker visitStartPicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel org_panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orgNameCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}