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
    public partial class RealEstateReport : Form
    {

        Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];
        public RealEstateReport()
        {
            InitializeComponent();
            setMonthReportParametersAndRefresh("جميع الأضرار العقارية");
        }
        public void setMonthReportParametersAndRefresh(string x)
        {
            parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_text", x);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }

        private void RealEstateReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.RealEtateReportView' table. You can move, or remove it, as needed.
            setMonthReportParametersAndRefresh("جميع الأضرار العقارية");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.Fill(this.UNdbDataSet1.RealEtateReportView);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الأضرار العقارية الخاصة بالمصاب " + fullname_combo.Text + "  بن" + " " + mother_name_combo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.FillBy(this.UNdbDataSet1.RealEtateReportView,fullname_combo.Text,mother_name_combo.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الأضرار العقارية في الربع " + " " +"ال"+ quarter_combo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.FillBy1(this.UNdbDataSet1.RealEtateReportView,quarter_combo.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("جميع الأضرار العقارية ");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.Fill(this.UNdbDataSet1.RealEtateReportView);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                name_panel.Visible = true;
                quarter_panel.Visible = false;
                category_panel.Visible = false;
                category_quarter_panel.Visible = false;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                quarter_panel.Visible = true;
                name_panel.Visible = false;
                category_panel.Visible = false;
                category_quarter_panel.Visible = false;
            }
            else if (comboBox4.SelectedIndex == 2)
            {

                category_panel.Visible = true;
                quarter_panel.Visible = false;
                name_panel.Visible = false;
                category_quarter_panel.Visible = false;
            }
            else
            {
                category_quarter_panel.Visible = true;
                quarter_panel.Visible = false;
                name_panel.Visible = false;
                category_panel.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الأضرار العقارية لفئة: " + " " + category_combo1.Text+"ون");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.FillBy2(this.UNdbDataSet1.RealEtateReportView, category_combo1.Text);

            this.reportViewer1.RefreshReport();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الأضرار العقارية لفئة"+ " " + category_combo2.Text + "ون"+ " " + "في الربع" + " " +"ال"+ quarter_combo2.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.RealEtateReportViewTableAdapter.FillBy3(this.UNdbDataSet1.RealEtateReportView, category_combo2.Text,quarter_combo2.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
