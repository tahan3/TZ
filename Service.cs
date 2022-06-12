namespace Computer
{
    public class Service : IService
    {
        public void ReplaceMotherboard(PersonalComputer computer, IMotherboard motherboard)
        {
            computer.ShutDown();
            
            var detachedMotherboard = computer.DetachMotherboard();
            var components = detachedMotherboard.FindAllComponents();
            
            components.ForEach(motherboard.AttachComponent);

            computer.AttachMotherboard(motherboard);
        }
    }
}