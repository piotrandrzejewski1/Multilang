using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Multilang.LanguageResources;

namespace Multilang.Shared.Vm
{
    public class MainVm : ViewModelBase
    {
        private string _sampleText;

        public MainVm()
        {
            SampleText = AppResources.Main_RealHelloWorld;
        }
        
        public string SampleText
        {
            get => _sampleText;
            set
            {
                _sampleText = value;
                RaisePropertyChanged(() => SampleText);
            }
        }

        public RelayCommand ChangeTextCommand => new RelayCommand(() => { SampleText = "Changed!"; });
    }
}