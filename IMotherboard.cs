using System.Collections.Generic;

namespace Computer
{
    public interface IMotherboard
    {
        public void AttachComponent(IComponent component);
        public IComponent DetachComponent(ComponentType componentType);
        public bool HasBrokenComponents();
        public List<IComponent> FindBrokenComponents();
        public List<IComponent> FindAllComponents();
    }
}