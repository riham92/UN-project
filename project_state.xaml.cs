using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UN
{
    
    public partial class project_state : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        project_info k = new project_info();
        main_injuries_info v;
        Validation validation = new Validation();

        public project_state(main_injuries_info v)
        {
            this.v = v;
            InitializeComponent();
            national_number.Text = v.national_num;
            national_number.IsEnabled = false;

        }

        public project_state()
        {
            InitializeComponent();
        }

        public void reset()
        {
            money_amount.Text = "";
            given_side.Text = "";
        }

        public bool fillProjectInfo()




        {



            var query_where1 = from u in OdContext.main_injuries_infos
                               where u.national_num == national_number.Text

                               select u;

            if (query_where1.Count() == 0)
            {
                System.Windows.MessageBox.Show(" .راجع الرقم الوطني أو العسكري", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);

                return false;
            }



            long res;

            bool canParse = long.TryParse(money_amount.Text, out res);
            if (!canParse)
            {
                MessageBox.Show("يرجى إدخال قيمة المبلغ بشكل صحيح", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                k = new project_info();
                k.mony_amount = money_amount.Text;
                k.given_side = given_side.Text;
                k.given_date = given_date.Text;
                k.national_num = national_number.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("يرجى مراجعة البيانات المدخلة", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }

        public void submitObject()
        {
            if (validation.isProjectValidated(k))
            {

                OdContext.project_infos.InsertOnSubmit(k);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت إضافة المشروع إلى المصاب ذي الرقم الوطني" + national_number.Text + " بنجاح. ";
                reset();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (fillProjectInfo())
                submitObject();
            else
                return;
            if (System.Windows.MessageBox.Show("هل تريد إضافة مشروع جديد؟", "إضافة جديدة", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                reset();
            }
            else
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
    }
}