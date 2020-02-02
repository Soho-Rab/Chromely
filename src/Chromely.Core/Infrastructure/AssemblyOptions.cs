﻿using System.Reflection;

namespace Chromely.Core.Infrastructure
{
    public class AssemblyOptions
    {
        public Assembly TargetAssembly { get; set; }
        public string DefaultNamespace { get; set; }
        public string RootFolder { get; set; }

        public AssemblyOptions(string targetAssemblyName, string defaultNamespace = null, string rootFolder = null)
        {
            TargetAssembly = LoadAssembly(targetAssemblyName);
            DefaultNamespace = defaultNamespace;
            RootFolder = rootFolder;

            if (TargetAssembly != null && string.IsNullOrWhiteSpace(DefaultNamespace))
            {
                DefaultNamespace = TargetAssembly.GetName().Name;
            }
        }

        public AssemblyOptions(Assembly target, string defaultNamespace = null, string rootFolder = null)
        {
            TargetAssembly = target;
            DefaultNamespace = defaultNamespace;
            RootFolder = rootFolder;

            if (TargetAssembly != null && string.IsNullOrWhiteSpace(DefaultNamespace))
            {
                DefaultNamespace = TargetAssembly.GetName().Name;
            }
        }

        private Assembly LoadAssembly(string targetAssemblyName)
        {
            try
            {
                return Assembly.LoadFrom(targetAssemblyName);
            }
            catch {}

            return null;
        }
    }
}
