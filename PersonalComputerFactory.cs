using System;

namespace Computer
{
    public static class PersonalComputerFactory
    {
        public static IComputer Create(Computer type)
        {
            return type switch
            {
                Computer.AppleComputer => new AppleComputer(InstallerFactory.Create(type)),
                Computer.MicrosoftComputer => new MicrosoftComputer(InstallerFactory.Create(type)),
                _ => throw new ArgumentException()
            };
        }
    }
}