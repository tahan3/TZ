namespace Computer
{
    public interface IComputer
    {
        public Computer Type { get; }
        public void Boot();
        public void Reboot();
        public void ShutDown();
    }
}