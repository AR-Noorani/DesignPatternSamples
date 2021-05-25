using System;
using System.Collections.Generic;

namespace Command
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> services = new();

        public static T GetService<T>()
        {
            return (T)services[typeof(T)];
        }

        public static void Register<T>() where T : new()
        {
            services[typeof(T)] = new T();
        }

        public static void Reset()
        {
            services.Clear();
        }
    }
}
