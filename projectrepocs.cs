using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UN
{
    public partial class projectrepocs : Form
    {
        public projectrepocs()
        {
            InitializeComponent();
        }

        private void projectrepocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'UNdbDataSet1.ProjectReportView' table. You can move, or remove it, as needed.
            this.ProjectReportViewTableAdapter.Fill(this.UNdbDataSet1.ProjectReportView);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ProjectReportViewTableAdapter.FillBy5(this.UNdbDataSet1.ProjectReportView, comboBox1.Text, comboBox2.Text);

            this.reportViewer1.RefreshReport();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex == 0)
            {
                full_name_panel.Visible = true;

                given_side_panel.Visible = false;

            }

            else
            {
                full_name_panel.Visible = false;

                given_side_panel.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ProjectReportViewTableAdapter.FillBy6(this.UNdbDataSet1.ProjectReportView, comboBox4.Text);

            this.reportViewer1.RefreshReport();

        }

        

       






    }
    }


       
        
        


      


       

      