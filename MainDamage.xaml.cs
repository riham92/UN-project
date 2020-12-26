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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        Validation validation = new Validation();
        damage_person_tb p = new damage_person_tb();
        Validation i = new Validation();

        public MainWindow()
        {
            InitializeComponent();
            add.IsEnabled = false;
        }

        public bool fillDamagePersonTb()
        {
            // object
            try
            {
                p = new damage_person_tb();
                p.name = name.Text;
                p.mother_name = mother_name.Text;
                p.national_number = nation_num.Text;
                p.national_number_type = nation_name.Text;
                p.phone_number = phone_num.Text;
                p.quarter = quarter_num.Text;
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
            if (validation.isDamagePersonValidated(p))
            {
                //submit
                OdContext.damage_person_tbs.InsertOnSubmit(p);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت إضافة المصاب " + p.name + " و" + " في حال قمت بإضافة ضرر فإن ذلك سيتم على السجلات الخاصة به";
                add.IsEnabled = true;
                reset();
                if (damage_type1.SelectedIndex == 3)
                {
                    car_tb c = new car_tb(p);
                    c.Show();
                }
                else
                {
                    real_stal_damag r = new real_stal_damag(p);
                    r.Show();
                }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            if (fillDamagePersonTb())
                submitObject();
            else
                return;
               
            
        }

        public void reset()
        {
            name.Text = "";
            mother_name.Text = "";
            nation_num.Text = "";
            phone_num.Text = "";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

           // if (validation.isDamagePersonValidated(p))
            //{
                if (damage_type1.SelectedIndex == 3)
                {
                    car_tb ct = new car_tb(p);
                    ct.Show();
                }
                else
                {
                    real_stal_damag da = new real_stal_damag(p);
                    da.Show();
                }
            //}
        }


 

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           //carsReport f = new carsReport();
           //f.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //realestate_report f = new realestate_report();
            //f.Show();

        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            reset();
        }

       
    }
}
