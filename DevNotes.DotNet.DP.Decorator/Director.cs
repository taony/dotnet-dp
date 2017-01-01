using System;

namespace DevNotes.DotNet.DP.Decorator
{
    public abstract  class Director : IComponent
    {
        public IComponent Component;

        protected Director(IComponent component)
        {
            Component = component;
        }

        public virtual void Operate()
        {
            throw new NotImplementedException();
        }
    }
}