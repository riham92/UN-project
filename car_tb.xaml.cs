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
    /// Interaction logic for car_tb.xaml
    /// </summary>
    public partial class car_tb : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        car_damage cd = new car_damage();
        damage_person_tb p = new damage_person_tb();
        Validation validation = new Validation();

        
        public car_tb(damage_person_tb p)
        {
            this.p = p;
            InitializeComponent();
            national_num.Text = this.p.national_number;
            national_num.IsEnabled = false;
        }

        public car_tb()
        {
            InitializeComponent();
        }

        public void reset()
        {
            
            number.Text = "";
            type.Text = "";
            year.Text = "";
            damage_value.Text = "";
            comp_worth_number.Text = "";
            comp_worth_text.Text = "";
            damage_type.Text = "";
        }



        public bool fillCarDamage()
        {
            //object
            try
            {
                cd = new car_damage();
                cd.number = number.Text;
                cd.type = type.Text;
                cd.year = year.SelectedDate.Value.Year;
                cd.category = category.Text;
                cd.damage_type = damage_type.Text;
                cd.damage_value = damage_value.Text;
                cd.comp_worth_number = comp_worth_number.Text;
                cd.comp_worth_text = comp_worth_text.Text;
                cd.national_number = national_num.Text;
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
            if (validation.isCarDamageValidated(cd))
            {
                //submit
                OdContext.car_damages.InsertOnSubmit(cd);
                OdContext.SubmitChanges();
                //notify
                status.Text = "تمت إضافة الضرر إلى المتضرر ذي الرقم الوطني" + national_num.Text + " بنجاح. ";
                reset();
                if (System.Windows.MessageBox.Show("هل تريد إضافة ضرر جديد؟", "إضافة جديدة", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    reset();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (fillCarDamage())
                submitObject();
            else
                return;

        }

        public bool isValidData()
        {

            return true;
        }


     
        private void number_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(number.Text=="رقم")
                number.Text = "";

        }
        private void comp_worth_number_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (comp_worth_number.Text == "رقما")
                comp_worth_number.Text = "";

        }
        private void comp_worth_text_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (comp_worth_text.Text == "رقما")
                comp_worth_text.Text = "";

        } 
        
        


     

       
    }
}
