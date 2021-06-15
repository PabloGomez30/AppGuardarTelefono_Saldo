using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Xml.Serialization;
using System.IO;
using System.Data;

namespace AppTelefonia
{
    [Activity(Label = "Abonar")]
    public class Abonar : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.interfazabonar);
           var btnAbonar = FindViewById<Button>(Resource.Id.botonAbono);
            var txtTelefono = FindViewById<EditText>(Resource.Id.txtTelefono);
            var txtAbono = FindViewById<EditText>(Resource.Id.txtAbono);
            btnAbonar.Click += delegate
            {
                try
                {
                    var WS = new ServicioWeb.ServicioWeb();
                    if (WS.Actualizar(long.Parse(txtTelefono.Text),
                        double.Parse(txtAbono.Text)))
                        Toast.MakeText(this, "Abono Insertado Correctamente",
                            ToastLength.Long).Show();
                    else
                        Toast.MakeText(this, "No Abonado",
                       ToastLength.Long).Show();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message,
                   ToastLength.Long).Show();
                }
            };

        }
    }
}