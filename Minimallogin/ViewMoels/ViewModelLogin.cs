using Minimallogin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Minimallogin.ViewMoels
{
    public class ViewModelLogin : ViewModelBase
    {
        private string username;
        private string password;
        private bool remember;
        private bool isLogged;
        private IModelService _modelService;

        public ViewModelLogin(IModelService modelMain)
        {
            _modelService = modelMain;
            Username = "Konivec";
            Password = "fltr";
            _modelService.Model.PropertyChanged += Model_PropertyChanged;
        }

        private ICommand _loginComm;
        public ICommand LoginComm => _loginComm ?? (_loginComm = new RelayCommand(OnLogin));
        public virtual void OnLogin(object Value = null) => _modelService.Model.Login(Username, Password, Remember);

        public string Username
        {
            get => username;
            set => Set(ref username, value);
        }
        public string Password
        {
            get => password;
            set => Set(ref password, value);
        }
        public bool Remember
        {
            get => remember;
            set => Set(ref remember, value);
        }
        public bool IsLogged 
        {
            get => _modelService.Model.GetLogRes();
        }
        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName) 
            {
                case "Login":
                    OnPropertyChanged(nameof(IsLogged));
                    break;
            }
        }
    }
}
