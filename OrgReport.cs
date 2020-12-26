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
    public partial class OrgReport : Form
    {

        Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];
        public OrgReport()
        {
            InitializeComponent();
            setMonthReportParametersAndRefresh("جميع الزيارات");
        }
        public void setMonthReportParametersAndRefresh(string x)
        {
            parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_Text", x);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }

        private void OrgReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.org_table' table. You can move, or remove it, as needed.
            this.org_tableTableAdapter.Fill(this.UNdbDataSet1.org_table);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.org_table' table. You can move, or remove it, as needed.
            setMonthReportParametersAndRefresh("الزائر:"+" "+visitorNameCombo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.org_tableTableAdapter.FillBy(this.UNdbDataSet1.org_table, visitorNameCombo.Text);

            this.reportViewer1.RefreshReport();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("جميع الزيارات");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.org_tableTableAdapter.Fill(this.UNdbDataSet1.org_table);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.org_table' table. You can move, or remove it, as needed.

            setMonthReportParametersAndRefresh(orgNameCombo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.org_tableTableAdapter.FillBy1(this.UNdbDataSet1.org_table, orgNameCombo.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الزيارات بين" + " " + visitStartPicker1.Value.ToShortDateString()+" "+"و"+" "+visitEndPicker1.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.org_tableTableAdapter.FillBy2(this.UNdbDataSet1.org_table, visitStartPicker1.Value.ToShortDateString(), visitEndPicker1.Value.ToShortDateString());

            this.reportViewer1.RefreshReport();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("تاريخ الورود بين" + " " + comeStartPicker.Value.ToShortDateString() + " " + "و" + " " + comeEndPicker.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.org_tableTableAdapter.FillBy2(this.UNdbDataSet1.org_table, comeStartPicker.Value.ToShortDateString(), comeEndPicker.Value.ToShortDateString());
            this.reportViewer1.RefreshReport();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                
                org_panel.Visible = false;
                visit_date_panel.Visible = false;
                come_date_panel.Visible = false;
                visitor_panel.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                visitor_panel.Visible = false;
                
                visit_date_panel.Visible = false;
                come_date_panel.Visible = false;
                org_panel.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                visitor_panel.Visible = false;
                org_panel.Visible = false;
                visit_date_panel.Visible = false;
                come_date_panel.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                visitor_panel.Visible = false;
                org_panel.Visible = false;
               
                come_date_panel.Visible = false;
                visit_date_panel.Visible = true;
            }
            else
            {
                visitor_panel.Visible = false;
                org_panel.Visible = false;
                visit_date_panel.Visible = false;
                come_date_panel.Visible = false;
            }
        }
    }
}
