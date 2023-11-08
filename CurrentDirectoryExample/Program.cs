using System.Reflection;
namespace CurrentDirectoryExample
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Directory path from AppContext.BaseDirectory:                 {AppContext.BaseDirectory}");
            Console.WriteLine($"Directory path from Directory.GetCurrentDirectory:            {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Directory path from Assembly.GetExecutingAssembly().Location: {Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}");
            Console.WriteLine($"Directory path from Assembly.GetEntryAssembly().Location:     {Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}");
            Console.WriteLine($"Directory path from external assembly (OtherProject.dll):     {GetDirectoryPathFromExternalAssembly()}");
        }

        private static string GetDirectoryPathFromExternalAssembly()
        {
            Assembly assembly = Assembly.LoadFrom($"{AppContext.BaseDirectory}\\plugins\\OtherProject.dll");
            Type type = assembly.GetType("OtherProject.Util");
            object instanceOfMyType = Activator.CreateInstance(type);
            var methodInfo = type.GetMethod("GetDirectoryPath");
            var result = methodInfo.Invoke(instanceOfMyType, new object[0]);
            return result.ToString();
        }
    }
}