
using Minimallogin.ViewMoels;
using Minimallogin.Services;
using System.Threading.Tasks;

namespace Minimallogin.Models
{
    public class ModelMain : ViewModelBase
    {
        private IMessageBoxService _messageBoxService;

        bool isLogged = false;

        public ModelMain(IMessageBoxService messageBoxService) 
        {
            _messageBoxService = messageBoxService;
        }

        public bool GetLogRes() 
        {
            return isLogged;
        }

        public void Login(string login, string password, bool remember)
        {
            isLogged = true;
            OnPropertyChanged("Login");

            
        }
    }
}
