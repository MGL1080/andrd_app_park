using Android.App;
using Android.Widget;
using Android.OS;

using MySql.Data.MySqlClient;

namespace test1_prk
{
    [Activity(Label = "test1_prk", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnCnnx = FindViewById<Button>(Resource.Id.btnCnnx);
            var txtUsr = FindViewById<TextView>(Resource.Id.txtUsr);
            var txtPss = FindViewById<TextView>(Resource.Id.txtPss);
            var txtfUsr = FindViewById<EditText>(Resource.Id.txtfUsr);
            var txtfPss = FindViewById<EditText>(Resource.Id.txtfPss);

            btnCnnx.Click += delegate 
            {
                string error;
                MySqlConn conn = new MySqlConn(txtfUsr.Text, txtfPss.Text);
                if(conn.TryConnection(out error))
                {
                    Toast.MakeText(this, "Conexion Exitosa", ToastLength.Long).Show();   
                }else{
                    Toast.MakeText(this, "Error! " + error, ToastLength.Long ).Show();
                }
            
            };
        
            
        
        }
    }
}

