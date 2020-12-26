using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using Microsoft.Reporting.WinForms;

namespace UN
{
    public partial class civilreport : Form
    {
        //Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];
        public civilreport()
        {
            InitializeComponent();
            //setMonthReportParametersAndRefresh("جميع الإصابات");
        }
        //public void setMonthReportParametersAndRefresh(string x)
        //{
        //    parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_text", x);
        //    this.reportViewer1.LocalReport.SetParameters(parms);
        //    this.reportViewer1.RefreshReport();
        //}
        private void civilreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.civilreportview' table. You can move, or remove it, as needed.
            this.civilreportviewTableAdapter.Fill(this.UNdbDataSet1.civilreportview);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //setMonthReportParametersAndRefresh("الإصابات الخاصة بالمصاب " + " " + full_name_combo.Text + " " + "بن" + " " + national_combo.Text);
           // this.reportViewer1.LocalReport.SetParameters(parms);
            this.civilreportviewTableAdapter.FillBy(this.UNdbDataSet1.civilreportview,full_name_combo.Text,national_combo.Text);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
