using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace AppTelefonia
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
             SetContentView(Resource.Layout.activity_main);
            var btnGuardar = FindViewById<Button>(Resource.Id.btnNuevo);
            var btnAbono = FindViewById<Button>(Resource.Id.btnAbonar);
            var Imagen = FindViewById<ImageView>(Resource.Id.imgView);
            Imagen.SetImageResource(Resource.Drawable.telcel);

            btnGuardar.Click += delegate
              {
                  CargarGuardar();
              };

            btnAbono.Click += delegate
            {
                CargarAbonar();
            };
        }

        public void CargarGuardar()
        {
            var vistaGuardar = new Intent(this, typeof(GuardarNuevo));
            StartActivity(vistaGuardar);
        }
        public void CargarAbonar()
        {
            var vistaAbonar = new Intent(this, typeof(Abonar));
            StartActivity(vistaAbonar);
        }


    }
}