using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using Multilang.Shared;
using Multilang.Shared.Vm;

namespace Multilang.Android
{
    [Activity(Label = "Multilang.Android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private MainVm _vm;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main);
            SharedStartup.Init();

            _vm = SimpleIoc.Default.GetInstance<MainVm>();
            
            this.SetBinding(() => _vm.SampleText, () => TextView1.Text);
            
            Button1.Click += (sender, args) => { _vm.ChangeTextCommand.Execute(null); };
        }


        #region Views
        private TextView _textView1;
        private Button _button1;
        private TextView TextView1 => _textView1 ?? (_textView1 = FindViewById<TextView>(Resource.Id.textView1));
        private Button Button1 => _button1 ?? (_button1 = FindViewById<Button>(Resource.Id.button1));
        #endregion
    }
}

