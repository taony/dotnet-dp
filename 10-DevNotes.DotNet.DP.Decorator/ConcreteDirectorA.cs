namespace DevNotes.DotNet.DP.Decorator
{
    public class ConcreteDirectorA: Director
    {
        public ConcreteDirectorA(IComponent component) : base(component)
        {

        }

        private void DrictorAOprate()
        {

        }

        public override void Operate()
        {
            base.Operate();
            DrictorAOprate();
        }
    }
}