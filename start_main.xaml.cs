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
    /// Interaction logic for start_main.xaml
    /// </summary>
    public partial class start_main : Window
    {
        bool loggedin = false;
        public start_main()
        {
            InitializeComponent();
            enjury_reports.Visibility = Visibility.Hidden;
            damage_reports.Visibility = Visibility.Hidden;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            main_injuries w = new main_injuries();
            w.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow h = new MainWindow();
            //h.Show();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            organixation k = new organixation();
            k.Show();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ;
        }
        private void add_subItem1_Click(object sender, RoutedEventArgs e)
        {
            main_injuries m = new main_injuries();
            m.Show();
        }

        private void add_subItem2_Click(object sender, RoutedEventArgs e)
        {
            medicine_state ms = new medicine_state();
            ms.Show();
        }

        private void add_subItem3_Click(object sender, RoutedEventArgs e)
        {
            military m = new military();
            m.Show();
        }
        private void add_subItem4_Click(object sender, RoutedEventArgs e)
        {
            project_state p = new project_state();
            p.Show();
        }

        private void add_subItem6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow d = new MainWindow();
            d.Show();
        }

        private void add_subItem7_Click(object sender, RoutedEventArgs e)
        {
            car_tb d = new car_tb();
            d.Show();
        }

        private void add_subItem8_Click(object sender, RoutedEventArgs e)
        {
            real_stal_damag d = new real_stal_damag();
            d.Show();
        }

        private void add_subItem9_Click(object sender, RoutedEventArgs e)
        {
            organixation o = new organixation();
            o.Show();
        }

        private void add_subItem10_Click(object sender, RoutedEventArgs e)
        {
            OrgReport or = new OrgReport();
            or.Show();
        }
        private void add_subItem11_Click(object sender, RoutedEventArgs e)
        {
            CarReport cr = new CarReport();
            cr.Show();
        }
        private void add_subItem12_Click(object sender, RoutedEventArgs e)
        {
            RealEstateReport r = new RealEstateReport();
            r.Show();
        }
        private void add_subItem13_Click(object sender, RoutedEventArgs e)
        {
            projectrepocs p = new projectrepocs();
            p.Show();
        }



        private void add_subItem5_Click(object sender, RoutedEventArgs e)
        {
            if (!loggedin)
                login_panel.Visibility = Visibility.Visible;
            else
                logout();
            
        }


        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            UNClassesDataContext OdContext = new UNClassesDataContext();
            
           
           
                var query_where1 = from u in OdContext.users
                                   where u.username==username.Text
                                   where u.password==password.Password.ToString()
                                   select u;
             MessageBox.Show(query_where1.ToString(), "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);

                if (query_where1.Count() == 0)
                {
                    MessageBox.Show(" .راجع اسم المستخدم و كلمة المرور","خطأ",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                else
                    foreach (var u in query_where1)
                        if (u.username == "sahar")
                            login();
        }
        private void add_subItem14_Click(object sender, RoutedEventArgs e)
        {
            civilreport c = new civilreport();
            c.Show();
        }


        private void add_subItem15_Click(object sender, RoutedEventArgs e)
        {
            militaryreport c = new militaryreport();
            c.Show();
        }

        public void login()
        {
            
            enjury_reports.Visibility = Visibility.Visible;
            damage_reports.Visibility = Visibility.Visible;
            orgReports.Visibility = Visibility.Visible;
            login_panel.Visibility = Visibility.Hidden;
            button11.Visibility = Visibility.Visible;
            button12.Visibility = Visibility.Visible;
            button13.Visibility = Visibility.Visible;
            button14.Visibility = Visibility.Visible;
            button15.Visibility = Visibility.Visible;
            button16.Visibility = Visibility.Visible;
            loginOut.Header = "تسجيل خروج";
            loggedin = true;
        }

        public void logout()
        {
            enjury_reports.Visibility = Visibility.Hidden;
            damage_reports.Visibility = Visibility.Hidden;
            orgReports.Visibility = Visibility.Hidden;
            login_panel.Visibility = Visibility.Visible;
            button11.Visibility = Visibility.Hidden;
            button12.Visibility = Visibility.Hidden;
            button13.Visibility = Visibility.Hidden;
            button14.Visibility = Visibility.Hidden;
            button15.Visibility = Visibility.Hidden;
            button16.Visibility = Visibility.Hidden;
            loginOut.Header = "تسجيل دخول";
            username.Text = "";
            password.Password = "";
            loggedin = false;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            main_injuries m = new main_injuries();
            m.ShowDialog();
           // m.Show();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            medicine_state m = new medicine_state();
            m.Show();
            
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            military m = new military();
            m.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            car_tb c = new car_tb();
            c.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            real_stal_damag r = new real_stal_damag();
            r.Show();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
        
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("هل تريد إغلاق البرنامج بالتأكيد؟", "إغلاق", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
               
            }
            
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            organixation o = new organixation();
            o.Show();
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            OrgReport o = new OrgReport();
            o.Show();
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            CarReport c = new CarReport();
            c.Show();
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            RealEstateReport r = new RealEstateReport();
            r.Show();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //ProjectReport p = new ProjectReport();
            projectrepocs p = new projectrepocs();
            p.Show();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            civilreport c = new civilreport();
            c.Show();
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            militaryreport m = new militaryreport();
            m.Show();

        }

       
        
        

    }
}
