using SecurityGuard.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGuard.ViewModels
{
    internal class MainWindowViewModel : ViewModel 
    {
        #region Заголовок окна
        
        private string _Title = "Охранник";
        
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title 
        {
            get => _Title;

            set => Set(ref _Title, value); //3
            // возможные варианты написание set
            //set
            //{
            //    1//if (Equals(_Title, value)) return;
            //    1//_Title = value;                          
            //    1//OnPropertyChanged();

            //    2//Set(ref _Title, value);
            //}
        }
        #endregion
    }
}
