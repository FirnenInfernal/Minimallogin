using System;
using System.IO;
using System.Linq;
using System.Windows;

using Microsoft.Win32;

namespace Minimallogin.Services
{
    internal class MessageBoxService : IMessageBoxService
    {
        public void ShowErrorMessage(string message, string caption)
            => MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);

        public void ShowInfoMessage(string message, string caption)
            => MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);

        public bool ShowQuestionMessage(string message, string caption)
        {
            if (MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }

        public bool ShowWarningMessage(string message, string caption)
        {
            if (MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }
    }
}
