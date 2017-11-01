using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

public class MySqlConn
{

        string usr;
        string pass;

     public MySqlConn(string User, string Password)
     {
        usr = User;
        pass = Password;
      }
    //MySqlConnection ms;
    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

    public bool TryConnection(out string Error)
    //public string Connection()
    {
        builder.Server = "localhost";
        builder.Database = "arduino";
        builder.UserID = usr;
        builder.Password = pass;
        try
        {
            //new I18N.West.CP1250();
            //MySqlConnection ms;
            MySqlConnection ms = new MySqlConnection(Builder.ToString());
            ms.Open();
            Error = "";
            return true;

        }catch(Exception ex){

            Error = ex.ToString();
            return false;
        }
    }

}
