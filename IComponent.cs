namespace Computer
{
    public interface IComponent
    {
        public ComponentType Type { get; }
        public ComponentState State { get; }
    }
}