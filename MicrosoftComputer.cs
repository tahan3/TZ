namespace Computer
{
    public class MicrosoftComputer : PersonalComputer
    {
        public override Computer Type => Computer.MicrosoftComputer;

        public MicrosoftComputer(IInstaller Installer) : base(Installer)
        {
        }

        protected override bool IsAppCompatible(IUserApplication application)
        {
            //amount of microsoft compatibility requirements
            return application.IsMatchRequirements(this);
        }
    }
}