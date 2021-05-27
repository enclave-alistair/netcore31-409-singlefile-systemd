using System;

namespace BundlingIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AppDirectory: {0}", AppContext.BaseDirectory);
            Console.WriteLine("User: {0}", Environment.UserName);
        }
    }
}
