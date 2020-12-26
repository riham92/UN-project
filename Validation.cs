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
    class Validation
    {
        string fullNamePattern = @"\b\w{2,25}\s\b{1,2}\w{2,25}\s\b{1,2}\w{2,25}";
        string namePattern = @"\b\w{2,25}\b";
        string nationalNumberPattern = @"\b\d{8,13}\b";
        string phoneNumberPattern = @"\b\d{9,10}\b";
        string addressNumPattern = @"\b\w{2,25}\s\d{1,5}\b";
        string childrenNumPattern = @"\b\d{0,2}\b"; //family_num and children_num
        string carNumPattern = @"\b\d{3,10}\b";
        string damageValuePattern = @"\b\d{4,8}\b";
        string compWorthNumberPattern = @"\b\d{4,8}\b";


        RemotingProject.Customer c = new RemotingProject.Customer();
        public bool isAddCustomerValidated(customer c)
        {
            if (match(c.name, "full_name") && 
                match(c.phone_number, "phone_number") && match(c.address,"address_num" ))
                return true;

            return false;
        }

        public bool isCarDamageValidated(car_damage cd)
        {
            if (match(cd.number, "car_num") && match(cd.damage_value.ToString(), "damage_value") &&
                match(cd.comp_worth_number.ToString(), "comp_worth_number"))
                return true;

            return false;
        }

        public bool isRealEstateDamageValidated(real_estale_damage rd)
        {
            if (match(rd.comp_worth.ToString(), "comp_worth_number") && match(rd.damage_value.ToString(), "damage_value") &&
                match(rd.comp_accepted.ToString(), "comp_accepted") && match(rd.final_comp_int.ToString(), "final_comp_int"))
                return true;

            return false;
        }



        public bool isMainInjuriesValidated(main_injuries_info m)
        {
            if (match(m.full_name.ToString(), "full_name") &&
                match(m.m_name, "name") &&
                match(m.Restriction_num, "restriction_num") &&
                match(m.phone_number, "phone_number") &&
                match(m.child_number.ToString(), "children_num") &&
                match(m.family_number.ToString(), "children_num")
                )
                        return true;

            return false;
        }

        public bool isMedicineStateValidated(medcin_info g)
        {
            if (match(g.national_num, "national_number"))
                return true;

            return false;
        }

        public bool isMilitaryValidated(mititary_info j)
        {
            if (match(j.miltary_number, "national_number"))
                return true;

            return false;
        }

        public bool isProjectValidated(project_info k)
        {
            if (match(k.national_num, "national_number"))
                return true;

            return false;
        }



        public bool isOrganValidated(org_table k)
        {
            if (match(k.visitor_name, "full_name"))
                return true;

            return false;
        }





        public bool match(string input, string type)
        {
            Match result;
            switch (type)
            {
                case "full_name":
                    {
                        result = Regex.Match(input, fullNamePattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال الاسم الثلاثي بشكل صحيح","خطأ إدخال",MessageBoxButton.OK,MessageBoxImage.Error);
                        break;
                    }
                case "name":
                    {
                        result = Regex.Match(input, namePattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال اسم الأم بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                case "national_number":
                    {
                        result = Regex.Match(input, nationalNumberPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال الرقم الوطني بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                case "phone_number":
                    {
                        result = Regex.Match(input, phoneNumberPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال رقم الهاتف بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }

                case "address_num":
                    {
                        result = Regex.Match(input, addressNumPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال العنوان بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }

                case "children_num":
                    {
                        result = Regex.Match(input, childrenNumPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال عدد الأطفال بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }

                case "car_num":
                    {
                        result = Regex.Match(input, carNumPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال رقم لوحة بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                case "damage_value":
                    {
                        result = Regex.Match(input, damageValuePattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال قيمة الضرر بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                case "comp_worth_number":
                    {
                        result = Regex.Match(input, compWorthNumberPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال قيمة التعويض المستحق بشكل صحيح", "خطأ إدخال", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }

                case "comp_accepted":
                    {
                        result = Regex.Match(input, compWorthNumberPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال قيمة التعويض المقبوض بشكل صحيح");
                        break;
                    }
                case "final_comp_int":
                    {
                        result = Regex.Match(input, compWorthNumberPattern);
                        if (result.Success)
                            return true;
                        else
                            MessageBox.Show("يرجى إدخال قيمة التعويض النهائي بشكل صحيح");
                        break;
                    }


            }

            return false;
        }
    }
}
