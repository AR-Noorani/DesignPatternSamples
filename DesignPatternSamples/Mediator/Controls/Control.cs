namespace Mediator
{
    public abstract class Control
    {
        private readonly DialogDirector director;

        public Control(DialogDirector director)
        {
            this.director = director;
        }

        protected void Changed()
        {
            director.ControlChanged(this);
        }
    }
}