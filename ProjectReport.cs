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
    public partial class ProjectReport : Form
    {
        Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];
        public ProjectReport()
        {
            InitializeComponent();
            setMonthReportParametersAndRefresh("جميع المشاريع");
        }
        public void setMonthReportParametersAndRefresh(string x)
        {
            parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_Text", x);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }

        private void ProjectReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.ProjectReportView' table. You can move, or remove it, as needed.
            this.ProjectReportViewTableAdapter.Fill(this.UNdbDataSet1.ProjectReportView);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("المشاريع الخاصة بالمصاب "+fullname_combo.Text+ "  بن" +" "+m_name.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.FillBy(this.UNdbDataSet1.ProjectReportView,fullname_combo.Text,m_name.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh(category_combo.Text + " , " + " بين" + " " + given_start_picker1.Value.ToShortDateString() +" "+"و" + " " + given_end_picker1.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.FillBy1(this.UNdbDataSet1.ProjectReportView,category_combo.Text,given_start_picker1.Value.ToShortDateString(),given_end_picker1.Value.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh(given_side_combo1.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.FillBy2(this.UNdbDataSet1.ProjectReportView,given_side_combo1.Text );
            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("المشاريع" + " بين" + " " + given_start_picker2.Value.ToShortDateString()+" "+"و"+" "+ given_end_picker2.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.FillBy3(this.UNdbDataSet1.ProjectReportView, given_start_picker2.Value.ToShortDateString(), given_end_picker2.Value.ToShortDateString());

            this.reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh(given_side_combo2.Text + " "+given_start_picker3.Value.ToShortDateString() + " " + "-" + " " + given_end_picker3.Value.ToShortDateString());
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.FillBy4(this.UNdbDataSet1.ProjectReportView, given_side_combo2.Text, given_start_picker3.Value.ToShortDateString(), given_end_picker3.Value.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                fullname_panel.Visible = true;
                category_panel.Visible = false;
                given_side_panel.Visible = false;
                given_date_panel.Visible = false;
                given_date_side_panel.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                fullname_panel.Visible = false;
                category_panel.Visible = true;
                given_side_panel.Visible = false;
                given_date_panel.Visible = false;
                given_date_side_panel.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                fullname_panel.Visible = false;
                category_panel.Visible = false;
                given_side_panel.Visible = true;
                given_date_panel.Visible = false;
                given_date_side_panel.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                fullname_panel.Visible = false;
                category_panel.Visible = false;
                given_side_panel.Visible = false;
                given_date_panel.Visible = true;
                given_date_side_panel.Visible = false;
            }
            else
            {
                fullname_panel.Visible = false;
                category_panel.Visible = false;
                given_side_panel.Visible = false;
                given_date_panel.Visible = false;
                given_date_side_panel.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("جميع المشاريع");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.ProjectReportViewTableAdapter.Fill(this.UNdbDataSet1.ProjectReportView);

            this.reportViewer1.RefreshReport();
        }
    }
}
