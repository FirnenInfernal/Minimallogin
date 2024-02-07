
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Minimallogin
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow mainWindow;
        LoginWindow loginWindow;
        private Locator locator;

        public App()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
        }

        protected void OnStartup(object sender, StartupEventArgs e)
        {
            locator = (Locator)Resources["locator"];
            MainWindow = mainWindow = new MainWindow();
            loginWindow = new LoginWindow();
            //loginWindow.Closing += LoginWindow_Closing;
            locator.LoginVM.PropertyChanged += LoginVM_PropertyChanged;
            loginWindow.Show();
        }

        //private void LoginWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (!locator.LoginVM.IsLogged) { Current.Shutdown(); }
        //}

        private void LoginVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsLogged")
            {
                if (locator.LoginVM.IsLogged)
                {
                    MainWindow.Show();
                    loginWindow.Close();
                }
                else
                {
                    Current.Shutdown();
                }
            }
        }
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MessageBox.Show("MyHandler caught : " + e.Message);
            MessageBox.Show("Runtime terminating: {0}", args.IsTerminating.ToString());

        }
    }
}
