using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Multilang.Shared.Vm
{
    public class MainVm : ViewModelBase
    {
        private string _sampleText;

        public MainVm()
        {
            SampleText = "Sample text";
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