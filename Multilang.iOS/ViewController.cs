using System;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Ioc;
using Multilang.Shared;
using Multilang.Shared.Vm;
using UIKit;

namespace Multilang.iOS
{
    public partial class ViewController : UIViewController
    {
        private MainVm _vm;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SharedStartup.Init();
            _vm = SimpleIoc.Default.GetInstance<MainVm>();

            this.SetBinding(() => _vm.SampleText, () => Label1.Text);
        }

        partial void Button_Clicked(UIButton sender)
        {
            _vm.ChangeTextCommand.Execute(null);
        }
    }
}
