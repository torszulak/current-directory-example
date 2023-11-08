using System.Reflection;

namespace OtherProject
{
    public class Util
    {
        public string GetDirectoryPath() => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}