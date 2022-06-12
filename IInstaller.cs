namespace Computer
{
    public interface IInstaller
    {
        public bool TryInstallApplication(IUserApplication application);
    }
}