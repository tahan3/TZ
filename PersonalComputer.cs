using System;
using System.Collections.Generic;
using System.Linq;

namespace Computer
{
    public abstract class PersonalComputer : IComputer
    {
        protected IInstaller installer;

        private ComputerState state;

        private IMotherboard motherboard;
        
        protected readonly List<IUserApplication> applications = new List<IUserApplication>();
        
        public List<IUserApplication> Applications => applications.ToList();
        
        public abstract Computer Type { get; }

        protected abstract bool IsAppCompatible(IUserApplication application);
        
        public PersonalComputer(IInstaller Installer)
        {
            installer = Installer;
        }
        
        public bool TryInstallApplication(IUserApplication application)
        {
            if (application == null)
            {
                return false;
            }

            if (IsAppCompatible(application) && installer.TryInstallApplication(application))
            {
                applications.Add(application);
                return true;
            }

            return false;
        }

        public IMotherboard DetachMotherboard()
        {
            ShutDown();
            
            return motherboard;
        }

        public bool AttachMotherboard(IMotherboard newMotherboard)
        {
            if (!IsMotherboardValid(newMotherboard))
            {
                throw new ArgumentException();
            }
            
            if (motherboard == null)
            {
                motherboard = newMotherboard;
                return true;
            }

            return false;
        }

        private bool IsMotherboardValid(IMotherboard motherboard)
        {
            return !(motherboard == null || motherboard.HasBrokenComponents());
        }
        
        public virtual void Boot()
        {
            if (!IsMotherboardValid(motherboard))
            {
                throw new Exception();
            }
            
            state = ComputerState.Running;
        }

        public virtual void Reboot()
        {
            ShutDown();
            Boot();
        }

        public void ShutDown()
        {
            state = ComputerState.ShutDown;
        }
    }
}