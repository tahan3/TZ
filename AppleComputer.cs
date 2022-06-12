using System;

namespace Computer
{
    public class AppleComputer : PersonalComputer
    {
        public override Computer Type => Computer.AppleComputer;
        
        public AppleComputer(IInstaller Installer) : base(Installer)
        {
        }

        protected override bool IsAppCompatible(IUserApplication application)
        {
            //amount of apple compatibility requirements
            return new Random().Next(5) > 2;
        }
    }
}