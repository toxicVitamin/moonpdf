using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Base
{
    /// <summary>
    /// Базовый класс ViewModel
    /// </summary>
    public class BaseViewModel: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Realization

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #endregion
    }
}
