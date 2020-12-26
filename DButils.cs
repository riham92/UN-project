using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace UN
{
 public static  class  DButils
    {
     public static  string GetConnectionString(){
     

         return "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\UNdb.mdf;Integrated Security=True;User Instance=True"
            ;
     }
     public static bool InsertNewRecord(String name,string mother_name,string national_number_type,string
         national_number,string phone_number,string quarter){
             SqlConnection conn = new SqlConnection(GetConnectionString());
             SqlCommand cmd = conn.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = @"INSERT INTO damage_person_tb VALUES(@name,@mother_name,@national_number_type
              ,@national_number,@phone_number,@quarter)";

             cmd.Parameters.Add("@name",SqlDbType.VarChar,50).Value=name;
             cmd.Parameters.Add("@mother_name", SqlDbType.VarChar, 50).Value=mother_name;
             cmd.Parameters.Add("@national_number_type", SqlDbType.VarChar, -1).Value=national_number_type;
             cmd.Parameters.Add("@national_number", SqlDbType.VarChar, 50).Value=national_number;
             cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 50).Value=phone_number;
             cmd.Parameters.Add("@quarter", SqlDbType.VarChar, 50).Value=quarter;
             try
             {
                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 return true;
             }
             catch (Exception )
             {
                 return false;
             }
             finally {
                 conn.Close();
             }





     }




     public static bool DeletRecord(int id)
     {
         SqlConnection conn = new SqlConnection(GetConnectionString());
         SqlCommand cmd = conn.CreateCommand();
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = @"DELET FROM damage_person_tb WHERE p_id=@id";


         cmd.Parameters.Add("@p_id", SqlDbType.Int).Value = id;
         
         try
         {
             conn.Open();
             cmd.ExecuteNonQuery();
             conn.Close();
             return true;
         }
         catch (Exception)
         {
             return false;
         }
         finally
         {
             conn.Close();
         }





     }


    }
}
