using System.Collections.Generic;

namespace Computer
{
    public class Scrapper : IScrapper
    {
        public List<IComponent> GetBrokenComponents(PersonalComputer computer)
        {
            var motherboard = computer.DetachMotherboard();
            var brokenMotherboardComponents = motherboard.FindBrokenComponents();

            List<IComponent> brokenComponents = new List<IComponent>();
            
            foreach (var brokenComponent in brokenMotherboardComponents)
            {
                brokenComponents.Add(motherboard.DetachComponent(brokenComponent.Type));
            }

            computer.AttachMotherboard(motherboard);
            
            return brokenComponents;
        }
    }
}