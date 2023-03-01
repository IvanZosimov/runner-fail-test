using System.Reflection;
using System.Xml.Schema;
using System.Xml;

namespace FileLoader.Tests
{
    public static class ResourceLoaderHelper
    {
        private static readonly Assembly ResourcesAssembly = typeof(ResourceLoaderHelper).Assembly;

        public static string LoadTestDataAsString(string resourceName)
        {
            var resourceStream = LoadTestData(resourceName);
            using var reader = new StreamReader(resourceStream);
            return reader.ReadToEnd();
        }

        public static Stream LoadTestData(string resourceName)
        {
            string resourceNameEnding = resourceName.Replace('/', '.');
            string embeddedResourceName = ResourcesAssembly.GetManifestResourceNames()
                .Single(x => x.EndsWith(resourceNameEnding));
            return ResourcesAssembly.GetManifestResourceStream(embeddedResourceName);
        }
        
        public static string[] GetResourceNames()
        {
            return ResourcesAssembly.GetManifestResourceNames();
        }
    }
}
