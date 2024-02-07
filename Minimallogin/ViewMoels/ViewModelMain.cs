using Minimallogin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimallogin.ViewMoels
{
    public class ViewModelMain : ViewModelBase
    {
        private IMessageBoxService _messageBoxService;
        private IModelService _modelService;

        public ViewModelMain(IModelService modelMain, IMessageBoxService MBService)
        {
            _modelService = modelMain;
            _messageBoxService = MBService;
            _modelService.Model.PropertyChanged += Model_PropertyChanged; ;
        }

        private string selectedMode;
        private int count;
        private int scale;
        private string productDesignation;
        private string factoryNumber;
        private string softwareVersion;
        private string description;

        public string SelectedMode
        {
            get => selectedMode;
            set => Set(ref selectedMode, value);
        }

        public int Count
        {
            get => count;
            set => Set(ref count, value);
        }

        public int Scale
        {
            get => scale;
            set => Set(ref scale, value);
        }

        public string ProductDesignation
        {
            get => productDesignation;
            set => Set(ref productDesignation, value);
        }
        public string FactoryNumber
        {
            get => factoryNumber;
            set => Set(ref factoryNumber, value);
        }
        public string SoftwareVersion
        {
            get => softwareVersion;
            set => Set(ref softwareVersion, value);
        }
        public string Description
        {
            get => description;
            set => Set(ref description, value);
        }


        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            // Проверяется имя изменившегося свойства и производятся необходимые действия

            // Тут пишем для всех свойств логику обработки изменений?

            //if (propertyName == "YouPropertyName")
            //{
            //}
        }
    }
}
