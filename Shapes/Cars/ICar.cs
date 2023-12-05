namespace Cars
{
    public interface ICar
    {
        public string Model { get; protected set; }
        public string Color { get; protected set; }
        public string Start();
        public string Stop();
    }
}