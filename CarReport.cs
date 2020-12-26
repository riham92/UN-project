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
    public partial class CarReport : Form
    {
        Microsoft.Reporting.WinForms.ReportParameter[] parms = new Microsoft.Reporting.WinForms.ReportParameter[1];
        public CarReport()
        {
            InitializeComponent();
            setMonthReportParametersAndRefresh("جميع أضرار سيارات");
        }

        public void setMonthReportParametersAndRefresh(string x)
        {
            parms[0] = new Microsoft.Reporting.WinForms.ReportParameter("header_text", x);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.reportViewer1.RefreshReport();
        }

        private void CarReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.carReportView' table. You can move, or remove it, as needed.
            this.carReportViewTableAdapter.Fill(this.UNdbDataSet1.carReportView);
            // TODO: This line of code loads data into the 'UNdbDataSet1.carReportView' table. You can move, or remove it, as needed.
            this.carReportViewTableAdapter.Fill(this.UNdbDataSet1.carReportView);
            // TODO: This line of code loads data into the 'UNdbDataSet1.carReportView' table. You can move, or remove it, as needed.
            this.carReportViewTableAdapter.Fill(this.UNdbDataSet1.carReportView);

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
                quarter_panel.Visible = false;
                name_panel.Visible = false;
                category_panel.Visible = true;
                category_quarter_panel.Visible = false;
            }
            else
            {
                quarter_panel.Visible = false;
                name_panel.Visible = false;
                category_panel.Visible = false;
                category_quarter_panel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("أضرار السيارات في الربع " + " " + "ال" + quarterCombo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.carReportViewTableAdapter.FillBy1(this.UNdbDataSet1.carReportView, quarterCombo.Text);
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("أضرار السيارات الخاصة بالمصاب " + full_name_combo.Text + "  بن" + " " + mother_name_combo.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.carReportViewTableAdapter.FillBy(this.UNdbDataSet1.carReportView,full_name_combo.Text,mother_name_combo.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("جميع أضرار السيارات " );
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.carReportViewTableAdapter.Fill(this.UNdbDataSet1.carReportView);

            this.reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("أضرار السيارات لفئة: " + " " + category_combo1.Text + "ون");
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.carReportViewTableAdapter.FillBy2(this.UNdbDataSet1.carReportView, category_combo1.Text);

            this.reportViewer1.RefreshReport();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            setMonthReportParametersAndRefresh("الأضرار العقارية لفئة"  + " " + category_combo2.Text +  "ون"+" " + "في الربع" + " " + "ال" + quarter_combo2.Text);
            this.reportViewer1.LocalReport.SetParameters(parms);
            this.carReportViewTableAdapter.FillBy3(this.UNdbDataSet1.carReportView, category_combo2.Text, quarter_combo2.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
