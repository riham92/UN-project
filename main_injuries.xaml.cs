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
    /// Interaction logic for main_injuries.xaml
    /// </summary>
    public partial class main_injuries : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        main_injuries_info v = new main_injuries_info();
        Validation i = new Validation();

        public main_injuries()
        {
            InitializeComponent();
            button3.IsEnabled = false;
            button5.IsEnabled = false;
        }

        public bool localValidated()
        {
            int numberOfchilds;
            bool canParse = int.TryParse(child_number.Text, out numberOfchilds);
            if (!canParse || numberOfchilds > 20 || numberOfchilds < 0)
            {
                MessageBox.Show("يرجى إدخال قيمة صحيحة في حقل عدد الأولاد", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            canParse = int.TryParse(family_number.Text, out numberOfchilds);
            if (!canParse || numberOfchilds > 20 || numberOfchilds < 0)
            {
                MessageBox.Show("يرجى إدخال قيمة صحيحة في حقل عدد أفراد العائلة", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (national_num.Text == "")
            {

                MessageBox.Show("يرجى إدخال قيمة صحيحة في حقل الرقم الوطني ", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }


          
           
                var query_where1 = from u in OdContext.main_injuries_infos
                                   where u.national_num==national_num.Text
                                  
                                   select u;

                if (query_where1.Count() == 1)
                {
                    MessageBox.Show(" .راجع الرقم الوطني أو العسكري","خطأ",MessageBoxButton.OK,MessageBoxImage.Error);

                    return false;
                }



                






            return true;




        }

        public bool fillMainInjuriesInfo()
        {
            if (!localValidated())
                return false;
            // object
            try
            {
                v = new main_injuries_info();
                v.national_num_type = comboBox1.Text;
                v.national_num = national_num.Text;
                v.full_name = p_name.Text;
                v.m_name = m_name.Text;
                v.govern = c_name.Text;
                v.b_date = b_date.Text;
                v.study_degree = Educational_degree.Text;
                v.child_number = int.Parse(child_number.Text);
                v.phone_number = phone_number.Text;
                v.family_number = int.Parse(family_number.Text);
                v.family_state = f_status.Text;
                v.house_state = home_state.Text;
                v.money_state = moeny_state.Text;
                v.another_funder = another_funder.Text;
                v.live_place = live_place.Text;
                v.Restriction_num = restriction_num.Text;
                if (is_owner.IsChecked == true)
                {
                    v.is_owner = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("راجع البيانات المدخلة", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public void submitObject()
        {
            //submit
            if (i.isMainInjuriesValidated(v))
            {

                OdContext.main_injuries_infos.InsertOnSubmit(v);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت إضافة المصاب " + v.full_name + " و" + " في حال قمت بإضافة إصابة أو مشروع فإن ذلك سيتم على السجلات الخاصة به";
                button3.IsEnabled = true;
                button5.IsEnabled = true;
                reset();
                if (comboBox1.SelectedIndex == 0)
                {
                    medicine_state ms = new medicine_state(v);
                    ms.Show();
                }
                else
                {
                    military m = new military(v);
                    m.Show();
                }


            }
        }
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            if (fillMainInjuriesInfo())
                submitObject();
            else
                return;
            
        }

        public void reset()
        {
            p_name.Text = "";
            m_name.Text = "";
            restriction_num.Text = "";
            moeny_state.Text = "";
            Educational_degree.Text = "";
            child_number.Text = "";
            phone_number.Text = "";
            live_place.Text = "";
            family_number.Text = "";
            home_state.Text = "";
            another_funder.Text = "";
            national_num.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                medicine_state ms = new medicine_state(v);
                ms.Show();
            }
            else
            {
                military m = new military(v);
                m.Show();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            project_state p = new project_state(v);
            p.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
    }
}






        