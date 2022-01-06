using SecurityGuard.Infrastructure.Commands;
using SecurityGuard.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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


        #region команды


        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion



        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute); 

            #endregion

        }
    }
}
