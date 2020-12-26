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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UN
{
    /// <summary>
    /// Interaction logic for medicine_state.xaml
    /// </summary>
    public partial class medicine_state : Window
    {
        UNClassesDataContext OdContext = new UNClassesDataContext();
        medcin_info g = new medcin_info();
        main_injuries_info v;
        Validation validation = new Validation();

        public medicine_state(main_injuries_info v)
        {
            this.v = v;
            InitializeComponent();
            national_num.Text = v.national_num;
            national_num.IsEnabled = false;
        }

        public medicine_state()
        {     
            InitializeComponent();
        }
        public void reset()
        {
            injury_type.Text = "";
            deficit_ratio.Text = "";
            injury_details.Text = "";
            how_to_Execution.Text = "";
            who_helps.Text = "";
            injury_details.Text = "";
            is_self_rely.IsChecked = false;
            is_Permanent_care.IsChecked = false;
            another_helps.IsChecked = false;
            is_Permanent_disability.IsChecked = false;

        }

        public bool fillMedcinInfo()
        {
            //object


            var query_where1 = from u in OdContext.main_injuries_infos
                               where u.national_num == national_num.Text

                               select u;

            if (query_where1.Count() == 0)
            {
                System.Windows.MessageBox.Show(" .راجع الرقم الوطني أو العسكري", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);

                return false;
            }


            try
            {
                g = new medcin_info();
                g.national_num = national_num.Text;
                g.injury_type = injury_type.Text;
                int res;
                bool canParse = int.TryParse(deficit_ratio.Text, out res);
                if (!canParse || res > 100 || res < 0)
                {
                    System.Windows.MessageBox.Show("يرجى إدخال نسبة العجز بشكل صحيح", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                g.Deficit_ratio = deficit_ratio.Text;
                g.injury_details = injury_details.Text;
                g.how_to_Execution = how_to_Execution.Text;
                g.who_helps = who_helps.Text;
                if (is_self_rely.IsChecked == true)
                {
                    g.is_self_rely = true;
                }
                else
                {
                    g.is_self_rely = false;
                }
                if (is_Permanent_disability.IsChecked == true)
                {
                    g.is_Permanent_disability = true;
                }
                else
                {
                    g.is_Permanent_disability = false;
                }
                if (is_Permanent_care.IsChecked == true)
                {
                    g.is_Permanent_care = true;
                }
                else
                {
                    g.is_Permanent_care = false;
                }
                if (another_helps.IsChecked == true)
                {
                    g.another_helps = true;
                }
                else
                {
                    g.another_helps = false;
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
            if (validation.isMedicineStateValidated(g))
            {
                    OdContext.medcin_infos.InsertOnSubmit(g);
                    OdContext.SubmitChanges();
                    //notify
                    status.Text = "تمت إضافة الإصابة إلى المصاب ذي الرقم الوطني" + national_num.Text + " بنجاح. ";
                    reset();
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (fillMedcinInfo())
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
