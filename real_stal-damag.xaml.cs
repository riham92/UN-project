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
    /// Interaction logic for real_stal_damag.xaml
    /// </summary>
    public partial class real_stal_damag : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        real_estale_damage rd = new real_estale_damage();
        damage_person_tb p = new damage_person_tb();
        Validation validation = new Validation();

        public real_stal_damag(damage_person_tb p)
        {
            this.p = p;
            InitializeComponent();
            national_num.Text = this.p.national_number;
            national_num.IsEnabled = false;
        }

        public real_stal_damag()
        {
            InitializeComponent();
        }

        public void reset()
        {
            real_estate_id.Text = "";
            real_estale_place.Text = "";
            damage_value.Text = "";
            comp_worth.Text = "";
            electrical_equipment.Text = "";
            comp_accepted.Text = "";
            final_comp_int.Text = "";
            final_comp_text.Text = "";
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
        }

        public bool fillRealEstaleDamage()
        {
            //object
            try
            {
                rd = new real_estale_damage();
                rd.real_estate_id = real_estate_id.Text;
                rd.real_estale_place = real_estale_place.Text;
                rd.damage_value = damage_value.Text;
                rd.comp_worth = comp_worth.Text;
                rd.electrical_equipment = electrical_equipment.Text;
                rd.final_comp_int = final_comp_int.Text;
                rd.final_comp_text = final_comp_text.Text;
                rd.comp_accepted = comp_accepted.Text;
                rd.national_number = national_num.Text;
                if (real_review.IsChecked == true)
                {

                    rd.real_review = true;
                }
                else
                {
                    rd.real_review = false;
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
            if (validation.isRealEstateDamageValidated(rd))
            {
                //submit
                OdContext.real_estale_damages.InsertOnSubmit(rd);
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
            if (fillRealEstaleDamage())
                submitObject();
            else
                return;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
    }
}
