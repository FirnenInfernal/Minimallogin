using Microsoft.Extensions.DependencyInjection;
using System;
using Minimallogin.ViewMoels;
using Minimallogin.Services;

namespace Minimallogin
{
    public class Locator
    {
        public IServiceProvider _serviceProvider;

        public ViewModelMain MainVM { get; set; }
        public ViewModelLogin LoginVM { get; set; }

        public Locator()
        {
            ConfigureServices();
            MainVM = _serviceProvider.GetService<ViewModelMain>();
            LoginVM = _serviceProvider.GetService<ViewModelLogin>();
        }
        private void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection
                .AddTransient<ViewModelMain>()
                .AddTransient<ViewModelLogin>()
                .AddSingleton<IModelService, ModelService>()
                .AddSingleton<IMessageBoxService, MessageBoxService>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
