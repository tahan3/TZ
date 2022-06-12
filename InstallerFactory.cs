using System;

namespace Computer
{
    public static class InstallerFactory
    {
        public static IInstaller Create(Computer type)
        {
            return type switch
            {
                Computer.AppleComputer => new AppleInstaller(),
                Computer.MicrosoftComputer => new MicrosoftInstaller(),
                _ => throw new ArgumentException()
            };
        }
    }
}