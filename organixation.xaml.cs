using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Media;
using System.Reflection;
using System.Windows.Threading;

namespace UN
{
    /// <summary>
    /// Interaction logic for organixation.xaml
    /// </summary>
    public partial class organixation : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();

        org_table ot = new org_table();
        Validation m = new Validation();
       
       // main_injuries_info v;
        
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\UNdb.mdf;Integrated Security=True;User Instance=True");
        public organixation()
        {
            InitializeComponent();
        }

        public void reset()
        {
            visit_purpose.Text = "";
            visitor_name.Text = "";
        }

        public bool fillOrg()
        {
            try
            {
                ot = new org_table();
                ot.org_name = organization_name.Text;
                ot.coming_date = coming_date.Text;
                ot.visit_date = visit_date.Text;
                ;

                
                ot.visit_purpose = visit_purpose.Text;
                ot.visitor_name = visitor_name.Text;
                if (checkBox1.IsChecked == true)
                {

                    ot.visit_state = true;
                }
                else
                {
                    ot.visit_state = false;
                }
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("راجع البيانات المدخلة", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public void submitObject()
        {
            if (m.isOrganValidated(ot))
            {
                OdContext.org_tables.InsertOnSubmit(ot);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت الإضافة بنجاح";
                reset();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(fillOrg())
                submitObject();
            else
                return;
            //if (System.Windows.MessageBox.Show("هل تريد إضافة إصابة جديدة؟", "إضافة جديدة", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    reset();
            //}
            //else
            //{
            //    this.Close();
            //}
         }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }





        
    }
}


