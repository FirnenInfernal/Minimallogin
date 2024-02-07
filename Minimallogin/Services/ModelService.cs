using Minimallogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimallogin.Services
{
    public class ModelService : IModelService
    {
        private ModelMain model;

        public ModelMain Model { get { return model; } }

        public ModelService(IMessageBoxService messageBoxService)
        {
            model = new ModelMain(messageBoxService);
        }

    }
}
