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

namespace AppTelefonia
{
    [Activity(Label = "GuardarNuevo")]
    public class GuardarNuevo : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.interfazguardar);
            var btnGuardar = FindViewById<Button>(Resource.Id.botonGuardar);
            var txtTelefono = FindViewById<EditText>(Resource.Id.txtTelefono);
            var txtNombre = FindViewById<EditText>(Resource.Id.txtNombre);
            var txtApellido = FindViewById<EditText>(Resource.Id.txtApellido);
            var txtSaldo = FindViewById<EditText>(Resource.Id.txtSaldo);


            btnGuardar.Click += delegate
            {
                try
                {
                    var WS = new ServicioWeb.ServicioWeb();
                    if (WS.Guardar(long.Parse(txtTelefono.Text), txtNombre.Text,
                        txtApellido.Text, double.Parse(txtSaldo.Text)))
                        Toast.MakeText(this, "Nuevo Usuario Guardado Correctamente",
                            ToastLength.Long).Show();
                    else
                        Toast.MakeText(this, "Usuario No Guardado",
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