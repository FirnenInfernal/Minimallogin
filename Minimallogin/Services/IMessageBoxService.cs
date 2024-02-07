using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimallogin.Services
{
    public interface IMessageBoxService
    {
        void ShowErrorMessage(string message, string caption);
        void ShowInfoMessage(string message, string caption);
        bool ShowQuestionMessage(string message, string caption);
        bool ShowWarningMessage(string message, string caption);
    }
}
