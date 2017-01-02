using System;

namespace DevNotes.DotNet.DP.Decorator
{
    public abstract class Director : IComponent
    {
        protected IComponent component;

        protected Director(IComponent _component)
        {
            component = _component;
        }

        public virtual void Operate()
        {
            if (null != component)
            {
                component.Operate();
            }

        }
    }
}