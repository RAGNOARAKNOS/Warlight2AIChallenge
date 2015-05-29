using GalaSoft.MvvmLight;
//Tutorial http://www.dotnetcurry.com/showarticle.aspx?ID=1037


using System.Collections.ObjectModel;
using DevGUI.Model;
using DevGUI.Services;
using GalaSoft.MvvmLight.Command;

namespace DevGUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        IDataAccessService _serviceProxy;

        ObservableCollection<Name> _Names;

        public ObservableCollection<Name> Names
        {
            get
            {
                return _Names;
            }
            set
            {
                _Names = value;
                RaisePropertyChanged("Employees");
            }
        }

        void GetNames()
        {
            Names.Clear();
            foreach (var item in _serviceProxy.GetNames())
            {
                Names.Add(item);
            }
        }

        public RelayCommand ReadAllCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}