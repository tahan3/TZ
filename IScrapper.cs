using System.Collections.Generic;

namespace Computer
{
    public interface IScrapper
    {
        public List<IComponent> GetBrokenComponents(PersonalComputer computer);
    }
}
