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
        private TextView _textView1;
        private Button _button1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main);
            SharedStartup.Init();

            _vm = SimpleIoc.Default.GetInstance<MainVm>();
            
            _textView1 = FindViewById<TextView>(Resource.Id.textView1);
            this.SetBinding(() => _vm.SampleText, () => _textView1.Text);

            _button1 = FindViewById<Button>(Resource.Id.button1);
            _button1.Click += (sender, args) => { _vm.ChangeTextCommand.Execute(null); };
        }
    }
}

