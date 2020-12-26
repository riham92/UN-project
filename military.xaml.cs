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
    /// <summary>
    /// Interaction logic for military.xaml
    /// </summary>
    public partial class military : Window
    {


        UNClassesDataContext OdContext = new UNClassesDataContext();
        mititary_info j = new mititary_info();
        main_injuries_info v;
        Validation m = new Validation();


        public military()
        {
            InitializeComponent();
        }

        public military(main_injuries_info v)
        {
            this.v = v;
            InitializeComponent();
            miltary_number.Text = v.national_num;
            miltary_number.IsEnabled = false;
        }

       

        public void reset()
        {
            service_side.Text="";
            rank.Text="";
            salary.Text="";
            compan_injury.Text="";
            injury_typr.Text="";
            deficit_ratio.Text="";
            how_to_Execution.Text="";
            who_helps.Text="";
            injury_details.Text="";
            injury_typr.Text = "";
            compan_injury.Text = "";
        }

        public bool localValidated()
        {
            long res;
            bool canParse = long.TryParse(salary.Text, out res);
            if (!canParse || res < 1000 || res > 100000)
            {
                MessageBox.Show("يرجى إدخال الراتب بشكل صحيح", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            canParse = long.TryParse(compan_injury.Text, out res);
            if (!canParse || res < 1000)
            {
                MessageBox.Show("يرجى إدخال التعويضات بشكل صحيح", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            int result;
            canParse = int.TryParse(deficit_ratio.Text, out result);
            if (!canParse || result < 0 || result > 100)
            {
                MessageBox.Show("يرجى إدخال نسبة العجز بشكل صحيح", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }


            var query_where1 = from u in OdContext.mititary_infos
                               where u.miltary_number == miltary_number.Text

                               select u;

            //if (query_where1.Count() == 1)
            //{
            //    System.Windows.MessageBox.Show(" .راجع الرقم الوطني أو العسكري", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);

            //    return false;
            //}






            return true;
        }

        public bool fillMititaryInfo()
        {
            if (!localValidated())
                return false;
            //object
            try
            {
                j = new mititary_info();
                j.miltary_number = miltary_number.Text;
                j.service_side = service_side.Text;
                j.rank = rank.Text;
                j.inrol_date = inrol_date.Text;
                j.inrol_date = injury_date.Text;
                j.miltary_number = miltary_number.Text;
                j.salary = salary.Text;
                j.compan_injury = compan_injury.Text;
                j.Deficit_ratio = deficit_ratio.Text;
                j.injury_details = injury_details.Text;
                j.how_to_Execution = how_to_Execution.Text;
                j.who_helps = who_helps.Text;
                j.national_num = miltary_number.Text;
                //g.inj_info_id = v.inj_info_id;
                if (is_self_rely.IsChecked == true)
                {
                    j.is_self_rely = true;
                }
                else
                {
                    j.is_self_rely = false;
                }
                if (is_permanent_care.IsChecked == true)
                {
                    j.is_permanent_care = true;
                }
                else
                {
                    j.is_permanent_care = false;
                }
                if (is_permanent_disability.IsChecked == true)
                {
                    j.is_permanent_disability = true;
                }
                else
                {
                    j.is_permanent_disability = false;
                }
                if (another_helps.IsChecked == true)
                {
                    j.another_helps = true;
                }
                else
                {
                    j.another_helps = false;
                }
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
            if (m.isMilitaryValidated(j))
            {
                //submit
                OdContext.mititary_infos.InsertOnSubmit(j);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت إضافة الإصابة إلى المصاب ذي الرقم الوطني" + miltary_number.Text + " بنجاح. ";
                reset();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (fillMititaryInfo())
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }

        
}
        
    
}
