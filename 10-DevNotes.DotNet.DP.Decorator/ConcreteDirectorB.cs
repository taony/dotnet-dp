namespace DevNotes.DotNet.DP.Decorator
{
    public class ConcreteDirectorB : Director
    {
        public ConcreteDirectorB(IComponent component) : base(component)
        {

        }

        private void DrictorBOprate()
        {

        }

        public override void Operate()
        {
            base.Operate();
            DrictorBOprate();

        }
    }
}