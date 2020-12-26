using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;


namespace UN
{
    public partial class militaryreport : Form
    {

        Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];

        public militaryreport()
        {
            InitializeComponent();
           // setMonthReportParametersAndRefresh("جميع الإصابات");


        }
        //public void setMonthReportParametersAndRefresh(string x)
        //{
        //    parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_text", x);
        //    this.reportViewer1.LocalReport.SetParameters(parms);
        //    this.reportViewer1.RefreshReport();
        //}

        private void militaryreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.militaryreportview' table. You can move, or remove it, as needed.
            this.militaryreportviewTableAdapter.Fill(this.UNdbDataSet1.militaryreportview);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // setMonthReportParametersAndRefresh("الإصابات الخاصة بالمصاب " + " " + comboBox1.Text + " " + "بن" + " " + comboBox2.Text);
            this.militaryreportviewTableAdapter.FillBy(this.UNdbDataSet1.militaryreportview, full_name_combo.Text, military_combo.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
