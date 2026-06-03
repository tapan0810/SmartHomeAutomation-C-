using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeAutomation.Services
{
    public class ServiceContainer
    {
        private readonly Dictionary<Type, object> _services = new();

        public void Register<T>(T service)
        {
            _services[typeof(T)] = service!;
        }

        public T Resolve<T>()
        {
            return (T)_services[typeof(T)];
        }

    }
}
