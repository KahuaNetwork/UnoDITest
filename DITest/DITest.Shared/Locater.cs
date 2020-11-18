using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public static class Locator
    {
        public static void Initialize()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(typeof(IService), typeof(Service));

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var service = serviceProvider.GetService(typeof(IService));
        }
    }
}
