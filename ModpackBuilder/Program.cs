using System;
using Cake.Core;
using Cake.Core.IO;
using Cake.Frosting;

namespace ModpackBuilder;

public static class Program
{
    [STAThread] 
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

public class BuildContext : FrostingContext
{
    public DirectoryPath RootDirectory { get; set; }
    
    public BuildContext(ICakeContext context) : base(context)
    {
        RootDirectory = context.Environment.WorkingDirectory.GetParent();
    }
}