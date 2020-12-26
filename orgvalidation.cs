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
using System.Text.RegularExpressions;

namespace UN
{
    class orgvalidation
    {
        string datePattern = "^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$";
        string spare = @"\b\w{2,25}\b";



        public bool ValidateDate(string dateInput)
        {
            Regex datePattern = new Regex("^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$");
            //Regex spare = new Regex(@"\b\w{2,25}\b");
            if (datePattern.IsMatch(dateInput) )
                return true;
            else
            {
                return false;
            }
        }




        public bool isOrgValidated(org_table o)
        {
            if ( match(o.visit_purpose, "spare") &&
                match(o.visitor_name, "spare"))
                return true;

            return false;
        }





        public bool match(string input, string type)
        {
            Match result;
            switch (type)
            {
                case "datePattern":
                    {
                        result = Regex.Match(input, datePattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال التاريخ بشكل صحيح");
                        break;
                    }
                case "spare":
                    {
                        result = Regex.Match(input, spare);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال الاسم بشكل صحيح");
                        break;
                    }
            }




                    return false;
            }


        }
    }
